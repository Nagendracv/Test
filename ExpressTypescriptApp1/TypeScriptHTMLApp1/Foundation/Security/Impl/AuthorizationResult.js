System.register([], function (exports_1, context_1) {
    "use strict";
    var __moduleName = context_1 && context_1.id;
    var AuthorizationResult;
    return {
        setters: [],
        execute: function () {
            AuthorizationResult = /** @class */ (function () {
                function AuthorizationResult() {
                }
                Object.defineProperty(AuthorizationResult.prototype, "Result", {
                    get: function () {
                        return this._result;
                    },
                    set: function (value) {
                        this._result = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                Object.defineProperty(AuthorizationResult.prototype, "PermanentAccessToken", {
                    get: function () {
                        return this._permanentAccessToken;
                    },
                    set: function (value) {
                        this._permanentAccessToken = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                Object.defineProperty(AuthorizationResult.prototype, "TemporaryAccessToken", {
                    get: function () {
                        return this._temporaryAccessToken;
                    },
                    set: function (value) {
                        this._temporaryAccessToken = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                Object.defineProperty(AuthorizationResult.prototype, "UnusedAccessTokenExpiresIn", {
                    get: function () {
                        return this._unusedAccessTokenExpiresIn;
                    },
                    set: function (value) {
                        this._unusedAccessTokenExpiresIn = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                Object.defineProperty(AuthorizationResult.prototype, "FailureId", {
                    get: function () {
                        return this._failureId;
                    },
                    set: function (value) {
                        this._failureId = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                Object.defineProperty(AuthorizationResult.prototype, "FailureReasons", {
                    get: function () {
                        return this._failureReasons;
                    },
                    set: function (value) {
                        this._failureReasons = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                return AuthorizationResult;
            }());
            exports_1("AuthorizationResult", AuthorizationResult);
        }
    };
});
//# sourceMappingURL=AuthorizationResult.js.map