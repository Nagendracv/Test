System.register([], function (exports_1, context_1) {
    "use strict";
    var __moduleName = context_1 && context_1.id;
    var Authenticator;
    return {
        setters: [],
        execute: function () {
            Authenticator = /** @class */ (function () {
                function Authenticator() {
                }
                /// <summary>
                /// Implements Authenticate
                /// </summary>
                /// <param name="credentials">ICredentials to authenticate. UserId is used to validate internally</param>
                /// <returns>Results of the authentication with Token</returns>
                Authenticator.prototype.Authenticate = function (credentials) {
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
                };
                return Authenticator;
            }());
            exports_1("Authenticator", Authenticator);
        }
    };
});
//# sourceMappingURL=Authenticator.js.map