// using Microsoft.AspNetCore.Builder;
// using Microsoft.Extensions.Options;
// using Microsoft.IdentityModel.Tokens;

namespace AuthLibrary.Foundation.Security.Impl
{
	/// <summary>
	/// On call at startup, Extends the request pipeline as a middleware 
	/// </summary>
    public static class TokenMiddlewareExtensions
    {
        /// <summary>
        /// Use this in teh startup code
        /// </summary>
        /// <param name="builder">The object being extended</param>
        /// <param name="parameters">Parameters to the object</param>
        /// <returns>Object of type IApplicationBuilder</returns>
        /*
        public static IApplicationBuilder UseTokenProvider(
            this IApplicationBuilder builder, TokenProviderOptions parameters)
        {
            return builder.UseMiddleware<TokenProviderMiddleware>(Options.Create(parameters));
        }
        */
    }
}