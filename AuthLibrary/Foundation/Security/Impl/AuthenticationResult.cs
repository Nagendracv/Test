using AuthLibrary.Foundation.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthLibrary.Foundation.Security.Impl
{
	/// <summary>
	/// Implements AuthenticationResult
	/// </summary>
	public class AuthenticationResult : IAuthenticationResult
	{
		/// <summary>
		/// Whether Authenticated
		/// </summary>
		public bool Result { get; set; }

		/// <summary>
		/// UserName
		/// </summary>
		public string UserName { get; set; }
		/// <summary>
		/// UserId
		/// </summary>
		public string UserId { get; set; }

		/// <summary>
		/// Holds a grant token (Usually encrypted).
		/// </summary>
		public string SuccessGrantToken { get; set; }

		/// <summary>
		/// if the grant is not used for a long time, the time in seconds in which it will expire. 0 for never expires.
		/// </summary>
		public int UnusedGrantExpiresIn { get; set; }

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
