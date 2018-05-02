using System;
using System.Collections.Generic;
using System.Text;

namespace AuthLibrary.Foundation.Security
{
	/// <summary>
	/// Result of an Authorization
	/// </summary>
	public interface IAuthorizationResult
	{
		/// <summary>
		/// Whether Authenticated
		/// </summary>
		bool Result { get; set; }

		/// <summary>
		/// Encrypted accesstoken which is persisted for this resource against that user. Does not usually change over time.
		/// </summary>
		string PermanentAccessToken { get; set; }

		/// <summary>
		/// Encrypted accesstoken which is not persisted and usually changes over time especially with every access request.
		/// </summary>
		string TemporaryAccessToken { get; set; }

		/// <summary>
		/// If the Access token is not used for a long time, the time in seconds in which it will expire. 0 for never expires.
		/// </summary>
		int UnusedAccessTokenExpiresIn { get; set; }

		/// <summary>
		/// Means of specifying reason for faliure. An integer. 
		/// </summary>
		string FailureId { get; set; }

		/// <summary>
		/// Description of why an Authentication did not succeed. 
		/// </summary>
		string FailureReasons { get; set; }
	}
}
