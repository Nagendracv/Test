
export interface IAuthorizationResult
{
	/// <summary>
	/// Whether Authenticated
	/// </summary>
    Result: boolean

    /// <summary>
    /// Encrypted accesstoken which is persisted for this resource against that user. Does not usually change over time.
    /// </summary>
    , PermanentAccessToken: string

    /// <summary>
    /// Encrypted accesstoken which is not persisted and usually changes over time especially with every access request.
    /// </summary>
    , TemporaryAccessToken: string

    /// <summary>
    /// If the Access token is not used for a long time, the time in seconds in which it will expire. 0 for never expires.
    /// </summary>
    , UnusedAccessTokenExpiresIn: number

    /// <summary>
    /// Means of specifying reason for faliure. An integer. 
    /// </summary>
    , FailureId: string

    /// <summary>
    /// Description of why an Authentication did not succeed. 
    /// </summary>
    , FailureReasons: string
}
