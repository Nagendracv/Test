using System;
using System.Collections.Generic;

namespace AuthLibrary.Foundation.Security
{
	/// <summary>
	/// Interface for authentication of credentials using OAuth mechanism.
	/// Few things to remember during implementation - Donot include any web elements in this (Like cookies etc)
	/// </summary>
    public interface IOAuth2Authorizer : IAuthenticator
	{
        /// <summary>
        /// Method to Authorise the already authenticated user to be authorised over a specific resource.
        /// </summary>
        /// <param name="resourceToAuth">Details of the resource being authorised before taking an action. Details include - the action being taken on the resource, ActionParameters and Requested properties in the result.</param>
        /// <returns>Provides the Access Token which can later be used to call the actual action on the resource. Each resourse action requires that an access token be specified each time</returns>
        IAuthorizationResult AuthorizeResource(IResourceAccessRequest resourceToAuth);
	}
}
