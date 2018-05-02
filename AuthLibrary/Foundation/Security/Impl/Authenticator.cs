using System;
using System.Collections.Generic;
using System.Text;
using AuthLibrary.Foundation.Security;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Security.Principal;
using Microsoft.IdentityModel.Tokens;
using System.Web.Http.Cors;
using System.Web.Http;
using System.Web.Http.Filters;
using System.Threading;
using AuthLibrary.Foundation.Security.Impl;
using System.IdentityModel.Tokens.Jwt;
using Newtonsoft.Json;
using System.Web;

namespace AuthLibrary.Foundation.Security.Impl
{
	/// <summary>
	/// Implements IAuthenticator
	/// </summary>
	/// </summary>
	[EnableCors(origins: "*", headers: "*", methods: "*")]
	[Route("api/[controller]")]
	public class Authenticator : IAuthenticationFilter, IAuthenticator
	{
		/// <summary>
		/// Implementation of IConfiguration
		/// </summary>
		private IConfiguration _configuration;
		private static TokenProviderOptions _options;

		/// <summary>
		/// Temporary set of users - to be discarded after actual implementation from cosmos/sql.
		/// </summary>
		private static IDictionary<string, CustomUser> _users;

		public bool AllowMultiple => throw new NotImplementedException();

		/// <summary>
		/// Proper constructor with temporary code which initializes with a static set of users
		/// </summary>
		/// <param name="configuration">Dep Inj Parameter to access configuration</param>
		/// <param name="users">List of users to initialize with</param>
		public Authenticator(IConfiguration configuration)
		{
			_configuration = configuration;
			if (_users == null)
			{
				_users = new Dictionary<string, CustomUser>();
				// Again note that this is temporary code until we have real users from database which is part of next backlog item
				// TODO: To remove after DB Integration
				_users.Add("Chris", new CustomUser { Id = "Chris", Name = "Chris", Password = "Chris" });
				_users.Add("Todd", new CustomUser { Id = "Todd", Name = "Todd", Password = "Todd" });
				_users.Add("Sashwat", new CustomUser { Id = "Sashwat", Name = "Sashwat", Password = "thisisaverylongpasswordwhich may even have spaces" });
			}
		}

		/// <summary>
		/// Implements Authenticate
		/// </summary>
		/// <param name="credentials">ICredentials to authenticate. UserId is used to validate internally</param>
		/// <returns>Results of the authentication with Token</returns>
		public async Task<IAuthenticationResult> Authenticate(ICredentials credentials)
		{
			//HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
			IAuthenticationResult authResults = null;
			JwtSecurityToken token = await GenerateToken(_configuration, credentials);

			string encodedJwt = new JwtSecurityTokenHandler().WriteToken(token);
			if (string.IsNullOrEmpty(encodedJwt)) return null;// The token handler expects null if it fails to authenticate. Any other reason for failure must be logged. It is not allowed to transmit any other reason of failure.

			var response = new {
				access_token = encodedJwt,
				expires_in = (int)_options.Expiration.TotalSeconds
			};

			string serialized = JsonConvert.SerializeObject(response, new JsonSerializerSettings { Formatting = Formatting.Indented });
			if (string.IsNullOrEmpty(serialized)) return null;// The token handler expects null if it fails to authenticate. Any other reason for failure must be logged. It is not allowed to transmit any other reason of failure.

			authResults = new AuthenticationResult { SuccessGrantToken = serialized, Result = true };
			return (AuthenticationResult)authResults;
		}

		/// <summary>
		/// Verifies that the specified identity mentioned in the Credentials object exists
		/// </summary>
		/// <param name="credentials">Credentials to verify against</param>
		/// <returns>The claims Identity object</returns>
		private static Task<ClaimsIdentity> GetIdentity(ICredentials credentials)
		{
			bool bPasswordMatches = false;

			CustomUser user = _users != null && credentials.UserId != null && _users.ContainsKey(credentials.UserId) ? _users[credentials.UserId] : null;
			if (user != null && user.Password == credentials.Password) bPasswordMatches = true;

			// TODO: Don't do this in production, obviously!
			if (credentials.UserId == credentials.Password || bPasswordMatches)
			{
				return Task.FromResult(new ClaimsIdentity(new GenericIdentity(credentials.UserId, "Token"), new Claim[] { }));
			}

			// Credentials are invalid, or account doesn't exist
			return Task.FromResult<ClaimsIdentity>(null);
		}

		public Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Verify's the existance of the user and generates the token
		/// </summary>
		/// <param name="config">IConfiguration object</param>
		/// <param name="credentials">Credentials to verify</param>
		/// <returns>void Task</returns>
		public static async Task<JwtSecurityToken> GenerateToken(IConfiguration config, ICredentials credentials)
		{
			var identity = await GetIdentity(credentials);
			if (identity == null) return null;

			var now = DateTime.UtcNow;

			if (_options == null)
			{
				TokenProviderOptions tokenProviderOptions = new TokenProviderOptions
				{
					Path = config["TokenAuthentication:TokenPath"],
					Audience = config["TokenAuthentication:Audience"],
					Issuer = config["TokenAuthentication:Issuer"],
					SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(config["TokenAuthentication:SecretKey"])), SecurityAlgorithms.HmacSha256),
					IdentityResolver = GetIdentity
				};
				ThrowIfInvalidOptions(tokenProviderOptions);
				_options = tokenProviderOptions;
			}

			Claim[] claims = new Claim[] {
				new Claim(JwtRegisteredClaimNames.Sub, credentials.UserId),
				new Claim(JwtRegisteredClaimNames.Jti, await _options.NonceGenerator()),
				new Claim(JwtRegisteredClaimNames.Iat,
					new DateTimeOffset(now).ToUniversalTime().ToUnixTimeSeconds().ToString(), ClaimValueTypes.Integer64)
			};

			JwtSecurityToken jwt = new JwtSecurityToken(
				issuer: _options.Issuer,
				audience: _options.Audience,
				claims: claims,
				notBefore: now,
				expires: now.Add(_options.Expiration),
				signingCredentials: _options.SigningCredentials);
			return jwt;
		}

		// TODO: Remove
		///// <summary>
		///// 
		///// </summary>
		///// <param name="username"></param>
		///// <returns></returns>
		//private string createToken(string username)
		//{
		//	//Set issued at date
		//	DateTime issuedAt = DateTime.UtcNow;
		//	//set the time when it expires
		//	DateTime expires = DateTime.UtcNow.AddDays(7);

		//	//http://stackoverflow.com/questions/18223868/how-to-encrypt-jwt-security-token
		//	var tokenHandler = new JwtSecurityTokenHandler();

		//	//create a identity and add claims to the user which we want to log in
		//	ClaimsIdentity claimsIdentity = new ClaimsIdentity(new[]
		//	{
		//		new Claim(ClaimTypes.Name, username)
		//	});

		//	string secret = _configuration["TokenAuthentication:SecretKey"];
		//	var securityKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(System.Text.Encoding.Default.GetBytes(secret));
		//	var signingCredentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(securityKey, Microsoft.IdentityModel.Tokens.SecurityAlgorithms.HmacSha256Signature);
		//	var now = DateTime.UtcNow;

		//	//create the jwt
		//	var token =
		//		(JwtSecurityToken)
		//			tokenHandler.CreateJwtSecurityToken(issuer: "http://localhost:50191", audience: "http://localhost:50191",
		//				subject: claimsIdentity, notBefore: issuedAt, expires: expires, signingCredentials: signingCredentials);
		//	var tokenString = tokenHandler.WriteToken(token);

		//	return tokenString;
		//}

		/// <summary>
		/// Validate options
		/// </summary>
		/// <param name="options">Settings to verify - of existance</param>
		private static void ThrowIfInvalidOptions(TokenProviderOptions options)
		{
			if (string.IsNullOrEmpty(options.Path))
			{
				throw new ArgumentNullException(nameof(TokenProviderOptions.Path));
			}

			if (string.IsNullOrEmpty(options.Issuer))
			{
				throw new ArgumentNullException(nameof(TokenProviderOptions.Issuer));
			}

			if (string.IsNullOrEmpty(options.Audience))
			{
				throw new ArgumentNullException(nameof(TokenProviderOptions.Audience));
			}

			if (options.Expiration == TimeSpan.Zero)
			{
				throw new ArgumentException("Must be a non-zero TimeSpan.", nameof(TokenProviderOptions.Expiration));
			}

			if (options.IdentityResolver == null)
			{
				throw new ArgumentNullException(nameof(TokenProviderOptions.IdentityResolver));
			}

			if (options.SigningCredentials == null)
			{
				throw new ArgumentNullException(nameof(TokenProviderOptions.SigningCredentials));
			}

			if (options.NonceGenerator == null)
			{
				throw new ArgumentNullException(nameof(TokenProviderOptions.NonceGenerator));
			}
		}
	}
}
