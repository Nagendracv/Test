
export interface ICredentials
{
	/// <summary>
	/// Company or Organization Name. Mandatory for Pethealth. Optional in OAuth
	/// </summary>
    CompanyOrContext: string

    /// <summary>
    /// Defaults to UserName if null. Otherwise it could be of various types as supported by the implementation. Maube Guid, maybe FaceBookId, Or whtever we identify as an ID.
    /// </summary>
    , UserIdType: string

    /// <summary>
    /// Id of the type defined in 'UserIdType'
    /// </summary>
    , UserId: string

    /// <summary>
    /// Password - optional if GrantToken is provided
    /// </summary>
    , Password: string

    /// <summary>
    /// GrantToken - Optional if Password is provided.
    /// </summary>
    , GrantToken: string
}
