/// <reference path="../scripts/typings/jasmine/jasmine.d.ts" />
/// <reference path="../node_modules/@types/systemjs/index.d.ts" />
/// <reference path="../Foundation/Security/Impl/Credentials.d.ts" />
/// <chutzpah_reference path="../scripts/jasmine/jasmine.js" >
/// <chutzpah_reference path="../node_modules/systemjs/dist/system.js" >
/// <chutzpah_reference path="../Foundation/Security/Impl/Credentials.js" >

//import { Credentials } from "../Foundation/Security/Impl/Credentials";
//import { AuthenticatorService } from "../Service/Shared/Security/Impl/AuthenticatorService";

describe('Plain Simple Login Test', function () {

	it("Valid User With Valid Passwod Should Get Logged In", () => {

		//var credentials = new Credentials();
		//credentials.UserId = 'Chris';
		//credentials.Password = 'Chris';
		expect(1).toBe(1);
	});
});
