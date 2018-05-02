using AuthLibrary.Foundation.Security;
using AuthLibrary.Foundation.Security.Impl;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPIProj.Controllers
{
    /// <summary>
    /// sample controller, to be removed with real api's soon
    /// </summary>
    [Route("api/AuthenticatorService")]
    [EnableCors("*", "*", "*")]
    public class AuthenticatorServiceController : ApiController
    {
		/// <summary>
		/// Implementation of IConfiguration
		/// </summary>
		private IConfiguration _configuration;

		/// <summary>
		/// service object
		/// </summary>
		private IAuthenticator _service;

		/// <summary>
		/// All parameters which are depended on dependency resolver myst be resolved at the level of the dependency resolver. (In this case IConfiguration)
		/// </summary>
		/// <param name="config"></param>
		public AuthenticatorServiceController()
        {
			_configuration = new ConfigReader();
		}
        
		[HttpPost]
        [Route("api/AuthenticatorService/Authenticate")]
        public async Task<IAuthenticationResult> Authenticate([FromBody]ICredentials credentials)
        {
			if (null == _service)
			{
				_service = new Authenticator(_configuration);
			}
			if (null == credentials)
			{
				credentials = new Credentials { UserId = HttpContext.Current.Request.Form["UserId"], CompanyOrContext = HttpContext.Current.Request.Form["CompanyOrContext"], Password = HttpContext.Current.Request.Form["Password"] };
			}
			//[ModelBinder(BinderType = typeof(CustomModelBinder))]
			return await _service.Authenticate(credentials).ConfigureAwait(false);
        }
        
    }

	public class ConfigReader : IConfiguration
	{
		public string this[string key]
		{
			get
			{
				return ConfigurationManager.AppSettings[key];
			}
			set => throw new NotImplementedException();
		}

		public IEnumerable<IConfigurationSection> GetChildren()
		{
			throw new NotImplementedException();
		}

		public IConfigurationSection GetSection(string key)
		{
			throw new NotImplementedException();
		}

		public IChangeToken GetReloadToken()
		{
			throw new NotImplementedException();
		}
	}
}
