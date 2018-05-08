export interface IAuthenticationResult
{
	/// <summary>
	/// Whether Authenticated
	/// </summary>
	Result : boolean

    /// <summary>
    /// UserName
    /// </summary>
    , UserName: string

    /// <summary>
    /// UserId
    /// </summary>
    , UserId: string

    /// <summary>
    /// Holds a grant token (Usually encrypted).
    /// </summary>
    , SuccessGrantToken: string

    /// <summary>
    /// if the grant is not used for a long time, the time in seconds in which it will expire. 0 for never expires.
    /// </summary>
    , UnusedGrantExpiresIn: number

    /// <summary>
    /// Means of specifying reason for faliure. An integer. 
    /// </summary>
    , FailureId: string

    /// <summary>
    /// Description of why an Authentication did not succeed. 
    /// </summary>
    , FailureReasons: string
}
