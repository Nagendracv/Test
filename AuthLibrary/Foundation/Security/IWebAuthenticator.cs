using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace AuthLibrary.Foundation.Security
{
	/// <summary>
	/// Interface for basic authentication of credentials.
	/// Implementation must web elements (Like cookies etc) which will help transmitting the authentication results to the caller.
	/// </summary>
	public interface IWebAuthenticator : IAuthenticator
    {
		/// <summary>
		/// Method to Authenticate the provided credentials. The method is likely to change signature depending on implementation. Remove this comment once frozen.
		/// </summary>
		/// <param name="credentials">HttpRequest object from which credentials can be extracted</param>
		/// <param name="context">HttpContext object from having accesss to cache etc</param>
		/// <param name="oAnyOther">future param</param>
		/// <returns>If Successfully authenticated into the system</returns>
		bool Authenticate(HttpRequest credentials, HttpContext context, object oAnyOther);
	}
}
