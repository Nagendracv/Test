using AuthLibrary.Foundation.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthLibrary.Foundation.Security.Impl
{
	/// <summary>
	/// Credentials used for authentication
	/// </summary>
	public class Credentials : ICredentials
	{
		/// <summary>
		/// Company or Organization Name. Mandatory for Pethealth. Optional in OAuth
		/// </summary>
		public string CompanyOrContext { get; set; }

		/// <summary>
		/// Defaults to UserName if null. Otherwise it could be of various types as supported by the implementation. Maube Guid, maybe FaceBookId, Or whtever we identify as an ID.
		/// </summary>
		public string UserIdType { get; set; }

		/// <summary>
		/// Id of the type defined in 'UserIdType'
		/// </summary>
		public string UserId { get; set; }

		/// <summary>
		/// Password - optional if GrantToken is provided
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// GrantToken - Optional if Password is provided.
		/// </summary>
		public string GrantToken { get; set; }
	}
}
