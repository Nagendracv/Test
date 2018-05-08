import { IAuthenticationResult } from "../../../Foundation/Security/IAuthenticationResult";
import { ICredentials } from "../../../Foundation/Security/ICredentials";
import { IAuthenticator } from "../../../Foundation/Security/IAuthenticator";
export declare class Authenticator implements IAuthenticator {
    Authenticate(credentials: ICredentials): IAuthenticationResult;
}
