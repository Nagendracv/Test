System.register([], function (exports_1, context_1) {
    "use strict";
    var __moduleName = context_1 && context_1.id;
    var Credentials;
    return {
        setters: [],
        execute: function () {
            Credentials = /** @class */ (function () {
                function Credentials() {
                }
                Object.defineProperty(Credentials.prototype, "CompanyOrContext", {
                    get: function () {
                        return this._companyOrContext;
                    },
                    set: function (value) {
                        this._companyOrContext = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                Object.defineProperty(Credentials.prototype, "UserIdType", {
                    get: function () {
                        return this._UserIdType;
                    },
                    set: function (value) {
                        this._UserIdType = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                Object.defineProperty(Credentials.prototype, "UserId", {
                    get: function () {
                        return this._UserId;
                    },
                    set: function (value) {
                        this._UserId = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                Object.defineProperty(Credentials.prototype, "Password", {
                    get: function () {
                        return this._Password;
                    },
                    set: function (value) {
                        this._Password = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                Object.defineProperty(Credentials.prototype, "GrantToken", {
                    get: function () {
                        return this._GrantToken;
                    },
                    set: function (value) {
                        this._GrantToken = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                return Credentials;
            }());
            exports_1("Credentials", Credentials);
        }
    };
});
//# sourceMappingURL=Credentials.js.map