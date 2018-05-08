import { ICredentials } from "../../../../Foundation/Security/ICredentials.js";
import { IAuthenticationResult } from "../../../../Foundation/Security/IAuthenticationResult.js";
import { IAuthenticatorService } from "../../../../Service/Shared/Security/IAuthenticatorService";

/// <summary>
/// proxy for the login service
/// </summary>
export class AuthenticatorService implements IAuthenticatorService
{
    /// <summary>
    /// attempt a login
    /// </summary>
    Authenticate(credentials: ICredentials, callback: (result: IAuthenticationResult) => void)
    {            
        var xhr = new XMLHttpRequest();
		xhr.open('POST', 'http://localhost:24859/api/AuthenticatorService/Authenticate');
        xhr.setRequestHeader('Content-Type', 'application/json');
        xhr.onload = function ()
        {
            if (xhr.status === 200)
            {
                var userInfo = JSON.parse(xhr.responseText);
                callback(userInfo);
            }
		};
		xhr.send(JSON.stringify(credentials).replace(/"_/g, '"'));
    }
}
