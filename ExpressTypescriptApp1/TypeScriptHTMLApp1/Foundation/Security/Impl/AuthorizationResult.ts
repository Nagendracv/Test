import { IAuthorizationResult } from "../../../Foundation/Security/IAuthorizationResult.js";

export class AuthorizationResult implements IAuthorizationResult
{
    /// <summary>
    /// Whether Authenticated
    /// </summary>
    private _result: boolean;
    get Result(): boolean
    {
        return this._result;
    }
    set Result(value: boolean)
    {
        this._result = value;
    }

	/// <summary>
	/// Encrypted accesstoken which is persisted for this resource against that user. Does not usually change over time.
	/// </summary>
    private _permanentAccessToken: string;
    get PermanentAccessToken(): string
    {
        return this._permanentAccessToken;
    }
    set PermanentAccessToken(value: string)
    {
        this._permanentAccessToken = value;
    }

	/// <summary>
	/// Encrypted accesstoken which is not persisted and usually changes over time especially with every access request.
	/// </summary>
    private _temporaryAccessToken: string;
    get TemporaryAccessToken(): string
    {
        return this._temporaryAccessToken;
    }
    set TemporaryAccessToken(value: string)
    {
        this._temporaryAccessToken = value;
    }

	/// <summary>
	/// If the Access token is not used for a long time, the time in seconds in which it will expire. 0 for never expires.
	/// </summary>
    private _unusedAccessTokenExpiresIn: number;
    get UnusedAccessTokenExpiresIn(): number
    {
        return this._unusedAccessTokenExpiresIn;
    }
    set UnusedAccessTokenExpiresIn(value: number)
    {
        this._unusedAccessTokenExpiresIn = value;
    }

	/// <summary>
	/// Means of specifying reason for faliure. An integer. 
	/// </summary>
    private _failureId: string;
    get FailureId(): string
    {
        return this._failureId;
    }
    set FailureId(value: string)
    {
        this._failureId = value;
    }

	/// <summary>
	/// Description of why an Authentication did not succeed. 
	/// </summary>
    private _failureReasons: string;
    get FailureReasons(): string
    {
        return this._failureReasons;
    }
    set FailureReasons(value: string)
    {
        this._failureReasons = value;
    }
}
