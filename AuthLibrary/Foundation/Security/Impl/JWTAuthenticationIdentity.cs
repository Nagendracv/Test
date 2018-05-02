using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AuthLibrary.Foundation.Security.Impl
{
	public class JWTAuthenticationIdentity : GenericIdentity
	{

		public string CompanyName { get; set; }
		public string UserName { get; set; }
		public string UserId { get; set; }

		public JWTAuthenticationIdentity(string userName)
			: base(userName)
		{
			UserName = userName;
		}


	}
}
