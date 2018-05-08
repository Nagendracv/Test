import { IAuthenticationResult } from "../../Foundation/Security/IAuthenticationResult.js";
import { ICredentials } from "../../Foundation/Security/ICredentials.js";

export interface IAuthenticator
{
    /// <summary>
    /// Method to Authenticate the provided credentials.
    /// </summary>
    /// <param name="credentials">Credentials with informaation of credential type</param>
    /// <returns>Provides the GrantToken which can later be used to get access token for specific resources. Each resourse requires a different access token</returns>
    Authenticate(credentials: ICredentials): IAuthenticationResult;
}
