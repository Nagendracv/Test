using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AuthLibrary.Foundation.Security
{
	/// <summary>
	/// Interface for basic authentication of credentials.
	/// Few things to remember during implementation - Donot include any web elements in this (Like cookies etc)
	/// </summary>
	public interface IAuthenticator
    {
		/// <summary>
		/// Method to Authenticate the provided credentials.
		/// </summary>
		/// <param name="credentials">Credentials with informaation of credential type</param>
		/// <returns>Provides the GrantToken which can later be used to get access token for specific resources. Each resourse requires a different access token</returns>
		Task<IAuthenticationResult> Authenticate(ICredentials credentials);
	}
}
