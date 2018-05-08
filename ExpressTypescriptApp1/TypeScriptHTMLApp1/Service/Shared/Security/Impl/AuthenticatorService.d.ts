import { ICredentials } from "../../../../Foundation/Security/ICredentials.js";
import { IAuthenticationResult } from "../../../../Foundation/Security/IAuthenticationResult.js";
import { IAuthenticatorService } from "../../../../Service/Shared/Security/IAuthenticatorService";
export declare class AuthenticatorService implements IAuthenticatorService {
    Authenticate(credentials: ICredentials, callback: (result: IAuthenticationResult) => void): void;
}
