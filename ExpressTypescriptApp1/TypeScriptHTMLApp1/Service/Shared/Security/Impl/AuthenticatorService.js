System.register([], function (exports_1, context_1) {
    "use strict";
    var __moduleName = context_1 && context_1.id;
    var AuthenticatorService;
    return {
        setters: [],
        execute: function () {
            /// <summary>
            /// proxy for the login service
            /// </summary>
            AuthenticatorService = /** @class */ (function () {
                function AuthenticatorService() {
                }
                /// <summary>
                /// attempt a login
                /// </summary>
                AuthenticatorService.prototype.Authenticate = function (credentials, callback) {
                    var xhr = new XMLHttpRequest();
                    xhr.open('POST', 'http://localhost:24859/api/AuthenticatorService/Authenticate');
                    xhr.setRequestHeader('Content-Type', 'application/json');
                    xhr.onload = function () {
                        if (xhr.status === 200) {
                            var userInfo = JSON.parse(xhr.responseText);
                            callback(userInfo);
                        }
                    };
                    xhr.send(JSON.stringify(credentials).replace(/"_/g, '"'));
                };
                return AuthenticatorService;
            }());
            exports_1("AuthenticatorService", AuthenticatorService);
        }
    };
});
//# sourceMappingURL=AuthenticatorService.js.map