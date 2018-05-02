using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using AuthLibrary.Foundation.Foundation.Security;
using AuthLibrary.Foundation.Security;
using AuthLibrary.Foundation.Security.Impl;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace AuthLibrary.Foundation.Security.Impl
{
	public class JWTAuthenticationFilter : AuthorizationFilterAttribute
	{
		/// <summary>
		/// Configuration reader 
		/// </summary>
		private IConfiguration _configuration;
		
		/// <summary>
		/// Algorithm for Encryption
		/// </summary>
		private readonly string _algorithm;

		/// <summary>
		/// parameters for the JwtSecurityTokenHandler.ValidateToken
		/// </summary>
		private static TokenValidationParameters _validationParameters;
		
		/// <summary>
		/// Signing key
		/// </summary>
		private static SymmetricSecurityKey _signingKey;

		public JWTAuthenticationFilter()
		{
			_configuration = new ConfigReader();
		}
		public override void OnAuthorization(HttpActionContext filterContext)
		{
			if (!IsUserAuthorized(filterContext))
			{
				ShowAuthenticationError(filterContext);
				return;
			}
			base.OnAuthorization(filterContext);
		}

		private JWTAuthenticationIdentity PopulateUserIdentity(JwtSecurityToken userPayloadToken)
		{
			string name = ((userPayloadToken)).Claims.FirstOrDefault(m => m.Type == "sub").Value;
			string userId = ((userPayloadToken)).Claims.FirstOrDefault(m => m.Type == "jti").Value;
			return new JWTAuthenticationIdentity(name) { UserId = userId, UserName = name };

		}

		public bool IsUserAuthorized(HttpActionContext actionContext)
		{
			var authHeader = FetchFromHeader(actionContext); //fetch authorization token from header
			if (null == authHeader) return false;

			if (null == _validationParameters)
			{
				string secret = _configuration["TokenAuthentication:SecretKey"];
				_signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secret));

				_validationParameters = new TokenValidationParameters
				{
					// The signing key must match!
					ValidateIssuerSigningKey = true,
					IssuerSigningKey = _signingKey,
					// Validate the JWT Issuer (iss) claim
					ValidateIssuer = true,
					ValidIssuer = _configuration["TokenAuthentication:Issuer"],
					// Validate the JWT Audience (aud) claim
					ValidateAudience = true,
					ValidAudience = _configuration["TokenAuthentication:Audience"],
					// Validate the token expiry
					ValidateLifetime = true,
					// If you want to allow a certain amount of clock drift, set that here:
					ClockSkew = TimeSpan.Zero
				};
			}
			if (authHeader != null)
			{
				JwtSecurityToken userPayloadToken = GenerateUserClaimFromJWT(_validationParameters, authHeader);
				if (userPayloadToken != null)
				{

					var identity = PopulateUserIdentity(userPayloadToken);
					string[] roles = { "All" };
					var genericPrincipal = new GenericPrincipal(identity, roles);
					Thread.CurrentPrincipal = genericPrincipal;
					var authenticationIdentity = Thread.CurrentPrincipal.Identity as JWTAuthenticationIdentity;
					if (authenticationIdentity != null && !string.IsNullOrEmpty(authenticationIdentity.UserName)) {
						authenticationIdentity.UserId = identity.UserId;
						authenticationIdentity.UserName = identity.UserName;
					}
					return true;
				}

			}
			return false;
		}
		/// <summary>
		/// Using the same key used for signing token, user payload is generated back
		/// </summary>
		/// <param name="validationParameters">Validation Params</param>
		/// <param name="authToken">Token from header</param>
		/// <returns>Security Token to be set on IPrincipal</returns>
		public static JwtSecurityToken GenerateUserClaimFromJWT(TokenValidationParameters validationParameters, string authToken)
		{
			var tokenHandler = new JwtSecurityTokenHandler();

			SecurityToken validatedToken;
			try
			{
				tokenHandler.ValidateToken(authToken, validationParameters, out validatedToken);
			}
			catch (Exception)
			{
				return null;
			}

			return validatedToken as JwtSecurityToken;
		}
		private static void ShowAuthenticationError(HttpActionContext filterContext)
		{
			var responseDTO = new { Code = 401, Message = "Unable to access, Please login again" };
			filterContext.Response =
			filterContext.Request.CreateResponse(HttpStatusCode.Unauthorized, responseDTO);
		}

		private string FetchFromHeader(HttpActionContext actionContext)
		{
			string requestToken = null;
			if (null == actionContext.Request || null == actionContext.Request.Headers) return null;

			var authRequest = actionContext.Request.Headers.Authorization;
			if (authRequest != null)
			{
				requestToken = authRequest.Parameter;
			}

			return requestToken;
		}
	}
}
