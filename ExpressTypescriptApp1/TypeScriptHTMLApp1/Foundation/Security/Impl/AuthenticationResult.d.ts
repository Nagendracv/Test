import { IAuthenticationResult } from "../../../Foundation/Security/IAuthenticationResult";
export declare class AuthenticationResult implements IAuthenticationResult {
    private _result;
    Result: boolean;
    private _userName;
    UserName: string;
    private _userId;
    UserId: string;
    private _successGrantToken;
    SuccessGrantToken: string;
    private _unusedGrantExpiresIn;
    UnusedGrantExpiresIn: number;
    private _failureId;
    FailureId: string;
    private _failureReasons;
    FailureReasons: string;
}
