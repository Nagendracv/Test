System.register([], function (exports_1, context_1) {
    "use strict";
    var __moduleName = context_1 && context_1.id;
    var AuthenticationResult;
    return {
        setters: [],
        execute: function () {
            AuthenticationResult = /** @class */ (function () {
                function AuthenticationResult() {
                    /// <summary>
                    /// Whether Authenticated
                    /// </summary>
                    this._result = false;
                }
                Object.defineProperty(AuthenticationResult.prototype, "Result", {
                    get: function () {
                        return this._result;
                    },
                    set: function (value) {
                        this._result = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                Object.defineProperty(AuthenticationResult.prototype, "UserName", {
                    get: function () {
                        return this._userName;
                    },
                    set: function (value) {
                        this._userName = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                Object.defineProperty(AuthenticationResult.prototype, "UserId", {
                    get: function () {
                        return this._userId;
                    },
                    set: function (value) {
                        this._userId = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                Object.defineProperty(AuthenticationResult.prototype, "SuccessGrantToken", {
                    get: function () {
                        return this._successGrantToken;
                    },
                    set: function (value) {
                        this._successGrantToken = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                Object.defineProperty(AuthenticationResult.prototype, "UnusedGrantExpiresIn", {
                    get: function () {
                        return this._unusedGrantExpiresIn;
                    },
                    set: function (value) {
                        this._unusedGrantExpiresIn = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                Object.defineProperty(AuthenticationResult.prototype, "FailureId", {
                    get: function () {
                        return this._failureId;
                    },
                    set: function (value) {
                        this._failureId = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                Object.defineProperty(AuthenticationResult.prototype, "FailureReasons", {
                    get: function () {
                        return this._failureReasons;
                    },
                    set: function (value) {
                        this._failureReasons = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                return AuthenticationResult;
            }());
            exports_1("AuthenticationResult", AuthenticationResult);
        }
    };
});
//# sourceMappingURL=AuthenticationResult.js.map