using System;
using System.Collections.Generic;
using System.Text;

namespace AuthLibrary.Foundation.Security
{
	/// <summary>
	/// Interface for requesting access to a resource recognized by the grant token
	/// </summary>
	public interface IResourceAccessRequest
	{
		/// <summary>
		/// The grant token which was provided at the time of initial Authentication. It uniquely identifies the Identity resource on which the action is being taken
		/// </summary>
		string AuthenticatedGrantToken { get; set; }

		/// <summary>
		/// What action is bein requested on the resource - Values include GetAccessToken, GetProfile etc. See documentation
		/// </summary>
		string ActionOnResource { get; set; }

		/// <summary>
		/// Mostly not needed for get actions. For Put actions (like updating resource by an administrator, this can/will be used).
		/// </summary>
		Dictionary<string, object> ActionParameters { get; set; }

		/// <summary>
		/// Specify what you are requesting. In this case, access token, emailid etc. On request, implementation must ensure that the requested values are not provided if the user does not have permissions.
		/// </summary>
		Dictionary<string, object> RequestedResProperties { get; set; }
	}
}
