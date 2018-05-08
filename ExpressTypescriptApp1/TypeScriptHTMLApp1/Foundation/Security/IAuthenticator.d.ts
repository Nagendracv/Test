import { IAuthenticationResult } from "../../Foundation/Security/IAuthenticationResult.js";
import { ICredentials } from "../../Foundation/Security/ICredentials.js";
export interface IAuthenticator {
    Authenticate(credentials: ICredentials): IAuthenticationResult;
}
