import { IAuthenticationResult } from "../../../Foundation/Security/IAuthenticationResult";
import { ICredentials } from "../../../Foundation/Security/ICredentials";
import { IAuthenticator } from "../../../Foundation/Security/IAuthenticator";

export class Authenticator implements IAuthenticator
{
    /// <summary>
    /// Implements Authenticate
    /// </summary>
    /// <param name="credentials">ICredentials to authenticate. UserId is used to validate internally</param>
    /// <returns>Results of the authentication with Token</returns>
    Authenticate(credentials: ICredentials) : IAuthenticationResult
    {
        /*
        IAuthenticationResult authResults = new AuthenticationResult { Result = false, FailureId = "404" };
        CustomUser user = ValidateCredentials(credentials.UserId, credentials.Password);
        if (user != null)
        {
            authResults.Result = true;
            authResults.SuccessGrantToken = BCrypt.Net.BCrypt.HashPassword(user.Id + "|" + DateTime.Now.Ticks);
            authResults.UserId = user.Id;
            authResults.UserName = user.Name;
            user.GrantToken = authResults.SuccessGrantToken;

            // TODO:Set some expiry mechanism on GrantToken property in user object
            // Ideally it must expire if the Grant Token object is not accessed for a certain seconds/
            return authResults;
        }
        */
        return null;
    }
}
