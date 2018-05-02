using System;
using System.Collections.Generic;
using System.Text;

namespace AuthLibrary.Foundation.Security
{
	/// <summary>
	/// Credentials used for authentication
	/// </summary>
	public interface ICredentials
	{
		/// <summary>
		/// Company or Organization Name. Mandatory for Pethealth. Optional in OAuth
		/// </summary>
		string CompanyOrContext { get; set; }

		/// <summary>
		/// Defaults to UserName if null. Otherwise it could be of various types as supported by the implementation. Maube Guid, maybe FaceBookId, Or whtever we identify as an ID.
		/// </summary>
		string UserIdType { get; set; }

		/// <summary>
		/// Id of the type defined in 'UserIdType'
		/// </summary>
		string UserId { get; set; }

		/// <summary>
		/// Password - optional if GrantToken is provided
		/// </summary>
		string Password { get; set; }

		/// <summary>
		/// GrantToken - Optional if Password is provided.
		/// </summary>
		string GrantToken { get; set; }
	}
}
