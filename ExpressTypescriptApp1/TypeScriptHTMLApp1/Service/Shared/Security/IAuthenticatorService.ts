import { ICredentials } from "../../../Foundation/Security/ICredentials.js";

/// <summary>
/// proxy for the login service
/// </summary>
export interface IAuthenticatorService 
{
    /// <summary>
    /// attempt a login
    /// </summary>
    Authenticate(credentials: ICredentials, callback);
}

