using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AuthLibrary.Foundation.Security;
using AuthLibrary.Foundation.Security.Impl;

namespace AuthLibrary.Foundation.Security.Impl
{
	/// <summary>
	/// The actual middleware which implements Json Web Token (JWT) Authentication
	/// </summary>
    public class TokenProviderMiddleware
    {
        // private readonly RequestDelegate _next;
        private readonly TokenProviderOptions _options;
        
#pragma warning disable SA1612 // Element parameter documentation must match element parameters

/// <summary>
        /// Construcotr
        /// </summary>
        /// <param name="next">Next middleware to be called (unless the pipeline needs tobe broken)</param>
        /// <param name="options">Options for the current token provider</param>
        /*
        public TokenProviderMiddleware(
            RequestDelegate next,
            IOptions<TokenProviderOptions> options)
        {
            _next = next;

            _options = options.Value;
            ThrowIfInvalidOptions(_options);
        }
        */
        
#pragma warning disable SA1612 // Element parameter documentation must match element parameters

/// <summary>
        /// Method which gets called on authentication request
        /// </summary>
        /// <param name="context">Current HttpContext object</param>
        /// <returns>Next Middleware in pipeline (unless the pipeline needs tobe broken)</returns>
        /*
        public Task Invoke(HttpContext context)
        {
			//takes care of preflight requests
			//context.Response.Headers.Append("Access-Control-Allow-Origin", "*");

			if (!context.Request.Path.Equals(_options.Path, StringComparison.Ordinal))
            {
                return _next(context);
            }

			if (context.Request.Method.Equals("POST", StringComparison.InvariantCultureIgnoreCase) && context.Request.HasFormContentType)
			{
				Credentials credentials = new Credentials { UserId = context.Request.Form["UserId"], CompanyOrContext = context.Request.Form["CompanyOrContext"], Password = context.Request.Form["Password"] };
				return GenerateTokenInternal(context, _options, credentials);
			}
            context.Response.StatusCode = 400;
            return context.Response.WriteAsync("Bad request.");
        }
        */

        /// <summary>
        /// Verify's the existance of the user, generates the token and returns to the web via context object
        /// </summary>
        /// <param name="context">HttpConetxt object to write into</param>
        /// <param name="options">Options for expiry</param>
        /// <param name="credentials">Credentials to verify</param>
        /// <returns>void Task</returns>
        /*
        private async Task GenerateTokenInternal(HttpContext context, TokenProviderOptions options, ICredentials credentials)
		{
			string token = await GenerateToken(options, credentials);
			if (string.IsNullOrEmpty(token)) {
				context.Response.StatusCode = 400;
				await context.Response.WriteAsync("Invalid username or password.");
				return;
			}
			var response = new
			{
				access_token = token,
				expires_in = (int)options.Expiration.TotalSeconds
			};

			string serialized = JsonConvert.SerializeObject(response, new JsonSerializerSettings { Formatting = Formatting.Indented });

			context.Response.ContentType = "application/json";
			await context.Response.WriteAsync(serialized).ConfigureAwait(false);
		}
        */

        /// <summary>
        /// Verify's the existance of the user and generates the token
        /// </summary>
        /// <param name="options">Options for expiry</param>
        /// <param name="credentials">Credentials to verify</param>
        /// <returns>void Task</returns>
        /*
        public static async Task<string> GenerateToken(TokenProviderOptions options, ICredentials credentials)
        {
            var identity = await options.IdentityResolver(credentials);
			if (identity == null) return null;

            var now = DateTime.UtcNow;


            var claims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, credentials.UserId),
                new Claim(JwtRegisteredClaimNames.Jti, await options.NonceGenerator()),
                new Claim(JwtRegisteredClaimNames.Iat,
                    new DateTimeOffset(now).ToUniversalTime().ToUnixTimeSeconds().ToString(), ClaimValueTypes.Integer64)
            };

            // Create the JWT and write it to a string
            var jwt = new JwtSecurityToken(
                issuer: options.Issuer,
                audience: options.Audience,
                claims: claims,
                notBefore: now,
                expires: now.Add(options.Expiration),
                signingCredentials: options.SigningCredentials);
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

			return encodedJwt;
        }
        */

		/// <summary>
		/// Validate options
		/// </summary>
		/// <param name="options">Settings to verify - of existance</param>
        private static void ThrowIfInvalidOptions(TokenProviderOptions options)
#pragma warning restore SA1612 // Element parameter documentation must match element parameters
#pragma warning restore SA1612 // Element parameter documentation must match element parameters
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
            /*
            if (options.SigningCredentials == null)
            {
                throw new ArgumentNullException(nameof(TokenProviderOptions.SigningCredentials));
            }
            */
            if (options.NonceGenerator == null)
            {
                throw new ArgumentNullException(nameof(TokenProviderOptions.NonceGenerator));
            }
        }
    }
}