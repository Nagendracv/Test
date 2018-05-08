import { ICredentials } from "../../../Foundation/Security/ICredentials.js";
export interface IAuthenticatorService {
    Authenticate(credentials: ICredentials, callback: any): any;
}
