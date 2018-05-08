import { IAuthenticationResult } from "../../../Foundation/Security/IAuthenticationResult";

export class AuthenticationResult implements IAuthenticationResult
{
    /// <summary>
    /// Whether Authenticated
    /// </summary>
    private _result: boolean = false;
    get Result(): boolean 
    {
        return this._result;
    }
    set Result(value: boolean) 
    {
        this._result = value;
    }

	/// <summary>
	/// UserName
	/// </summary>
    private _userName: string;
    get UserName(): string 
    {
        return this._userName;
    }
    set UserName(value: string) 
    {
        this._userName = value;
    }

	/// <summary>
	/// UserId
	/// </summary>
    private _userId: string;
    get UserId(): string
    {
        return this._userId;
    }
    set UserId(value: string) 
    {
        this._userId = value;
    }

	/// <summary>
	/// Holds a grant token (Usually encrypted).
	/// </summary>
    private _successGrantToken: string;
    get SuccessGrantToken(): string 
    {
        return this._successGrantToken;
    }
    set SuccessGrantToken(value: string) 
    {
        this._successGrantToken = value;
    }

	/// <summary>
	/// if the grant is not used for a long time, the time in seconds in which it will expire. 0 for never expires.
	/// </summary>
    private _unusedGrantExpiresIn: number;
    get UnusedGrantExpiresIn(): number 
    {
        return this._unusedGrantExpiresIn;
    }
    set UnusedGrantExpiresIn(value: number) 
    {
        this._unusedGrantExpiresIn = value;
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
