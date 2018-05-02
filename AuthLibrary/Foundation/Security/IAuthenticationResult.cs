using System;
using System.Collections.Generic;
using System.Text;

namespace AuthLibrary.Foundation.Security
{
	/// <summary>
	/// Result of an Authentication
	/// </summary>
	public interface IAuthenticationResult
	{
		/// <summary>
		/// Whether Authenticated
		/// </summary>
		bool Result { get; set; }

		/// <summary>
		/// UserName
		/// </summary>
		string UserName { get; set; }

		/// <summary>
		/// UserId
		/// </summary>
		string UserId { get; set; }

		/// <summary>
		/// Holds a grant token (Usually encrypted).
		/// </summary>
		string SuccessGrantToken { get; set; }

		/// <summary>
		/// if the grant is not used for a long time, the time in seconds in which it will expire. 0 for never expires.
		/// </summary>
		int UnusedGrantExpiresIn { get; set; }

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
