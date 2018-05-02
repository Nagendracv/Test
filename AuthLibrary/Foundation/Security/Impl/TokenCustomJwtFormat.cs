// using System.IdentityModel.Tokens.Jwt;
// using Microsoft.AspNetCore.Authentication;
// using Microsoft.IdentityModel.Tokens;
// using AuthenticationProperties = Microsoft.AspNetCore.Authentication.AuthenticationProperties;


namespace AuthLibrary.Foundation.Security.Impl
{
    /// <summary>
    /// Any token based service implemented for JWT must implement this interface
    /// </summary>
    public class TokenCustomJwtFormat // : ISecureDataFormat<AuthenticationTicket>
    {
		/// <summary>
		/// Algorithm for Encryption
		/// </summary>
		private readonly string _algorithm;

        /// <summary>
        /// parameters for the JwtSecurityTokenHandler.ValidateToken
        /// </summary>
        // private readonly TokenValidationParameters _validationParameters;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="algorithm">Encryption algorithm - ususally SecurityAlgorithms.HmacSha256</param>
        /// <param name="validationParameters">Parameters which can be passed to JwtSecurityTokenHandler's ValidateToken method</param>
        /*
        public TokenCustomJwtFormat(string algorithm, TokenValidationParameters validationParameters)
        {
            this._algorithm = algorithm;
            this._validationParameters = validationParameters;
        }
        */

        /// <summary>
        /// Decrypts the token
        /// </summary>
        /// <param name="protectedText">Token value</param>
        /// <returns>Authentication Ticket</returns>
        /*
        public AuthenticationTicket Unprotect(string protectedText)
            => Unprotect(protectedText, null);
        */

        /// <summary>
        /// Decrypts the token
        /// </summary>
        /// <param name="protectedText">Token value</param>
        /// <param name="purpose">Reason (Logged) why the Decryption is requested</param>
        /// <returns>Authentication Ticket</returns>
        /*
        public AuthenticationTicket Unprotect(string protectedText, string purpose)
        {
			// TODO: When using load balancer, Implement own token validator 
			var handler = new JwtSecurityTokenHandler();
            ClaimsPrincipal principal = null;

            try
            {
                SecurityToken validToken = null;
                principal = handler.ValidateToken(protectedText, this._validationParameters, out validToken);

                var validJwt = validToken as JwtSecurityToken;

                if (validJwt == null)
                {
                    throw new ArgumentException("Invalid JWT");
                }

                if (!validJwt.Header.Alg.Equals(_algorithm, StringComparison.Ordinal))
                {
                    throw new ArgumentException($"Algorithm must be '{_algorithm}'");
                }
            }
            catch (SecurityTokenValidationException)
            {
				// TODO: Log information. 
                return null; // Returning Null results in a proper authorization error.
			}
            catch (ArgumentException)
            {
				// TODO: Log information.
				// End user need not know actual reasosn for failure
				// for example whether auth faliure is due to wrong due to wrong algorithm or something else is none of his business
				// only we need to know so we log and continue.
				return null;// Returning Null results in a proper authorization error.
			}

			// VALIDATION PASSED
			return new AuthenticationTicket(principal, new AuthenticationProperties(), "Cookie");
        }
        */

        /// <summary>
        /// Implements Protect interface method. Not applicable here because the authentication is being done via middleware/Authentication Controller. Required in OWIN case only
        /// </summary>
        /// <param name="data">unencrypted/signed authenticated ticket</param>
        /// <returns>Encrypted data</returns>
        /*
        public string Protect(AuthenticationTicket data)
        {
            throw new NotImplementedException();
        }
        */

        /// <summary>
        /// Implements Protect interface method. Not applicable here because the authentication is being done via middleware/Authentication Controller. Required in OWIN case only
        /// </summary>
        /// <param name="data">unencrypted/signed authenticated ticket</param>
        /// <param name="purpose">reason for encrypting</param>
        /// <returns>Encrypted data</returns>
        /*
        public string Protect(AuthenticationTicket data, string purpose)
        {
            throw new NotImplementedException();
        }
        */
    }
}