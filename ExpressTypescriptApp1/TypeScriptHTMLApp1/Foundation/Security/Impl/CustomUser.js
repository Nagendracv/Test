System.register([], function (exports_1, context_1) {
    "use strict";
    var __moduleName = context_1 && context_1.id;
    var CustomUser;
    return {
        setters: [],
        execute: function () {
            CustomUser = /** @class */ (function () {
                function CustomUser() {
                }
                Object.defineProperty(CustomUser.prototype, "Id", {
                    get: function () {
                        return this._id;
                    },
                    set: function (value) {
                        this._id = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                Object.defineProperty(CustomUser.prototype, "Name", {
                    get: function () {
                        return this._name;
                    },
                    set: function (value) {
                        this._name = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                Object.defineProperty(CustomUser.prototype, "Password", {
                    get: function () {
                        return this._password;
                    },
                    set: function (value) {
                        this._password = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                Object.defineProperty(CustomUser.prototype, "PasswordHash", {
                    get: function () {
                        return this._passwordHash;
                    },
                    set: function (value) {
                        this._passwordHash = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                Object.defineProperty(CustomUser.prototype, "GrantToken", {
                    get: function () {
                        return this._grantToken;
                    },
                    set: function (value) {
                        this._grantToken = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                Object.defineProperty(CustomUser.prototype, "CompanyOrContext", {
                    get: function () {
                        return this._companyOrContext;
                    },
                    set: function (value) {
                        this._companyOrContext = value;
                    },
                    enumerable: true,
                    configurable: true
                });
                return CustomUser;
            }());
            exports_1("CustomUser", CustomUser);
        }
    };
});
//# sourceMappingURL=CustomUser.js.map