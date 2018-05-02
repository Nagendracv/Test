using AuthLibrary.Foundation.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthLibrary.Foundation.Security.Impl
{
	/// <summary>
	/// Implements IAuthorizationResult
	/// </summary>
	public class AuthorizationResult : IAuthorizationResult
	{
		/// <summary>
		/// Whether Authenticated
		/// </summary>
		public bool Result { get; set; }

		/// <summary>
		/// Encrypted accesstoken which is persisted for this resource against that user. Does not usually change over time.
		/// </summary>
		public string PermanentAccessToken { get; set; }

		/// <summary>
		/// Encrypted accesstoken which is not persisted and usually changes over time especially with every access request.
		/// </summary>
		public string TemporaryAccessToken { get; set; }

		/// <summary>
		/// If the Access token is not used for a long time, the time in seconds in which it will expire. 0 for never expires.
		/// </summary>
		public int UnusedAccessTokenExpiresIn { get; set; }

		/// <summary>
		/// Means of specifying reason for faliure. An integer. 
		/// </summary>
		public string FailureId { get; set; }

		/// <summary>
		/// Description of why an Authentication did not succeed. 
		/// </summary>
		public string FailureReasons { get; set; }
	}
}
