import { IAuthorizationResult } from "../../../Foundation/Security/IAuthorizationResult.js";
export declare class AuthorizationResult implements IAuthorizationResult {
    private _result;
    Result: boolean;
    private _permanentAccessToken;
    PermanentAccessToken: string;
    private _temporaryAccessToken;
    TemporaryAccessToken: string;
    private _unusedAccessTokenExpiresIn;
    UnusedAccessTokenExpiresIn: number;
    private _failureId;
    FailureId: string;
    private _failureReasons;
    FailureReasons: string;
}
