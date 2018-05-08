
export interface IWebAuthenticator
{
	/// <summary>
	/// Method to Authenticate the provided credentials. The method is likely to change signature depending on implementation. Remove this comment once frozen.
	/// </summary>
	/// <param name="credentials">HttpRequest object from which credentials can be extracted</param>
	/// <param name="context">HttpContext object from having accesss to cache etc</param>
	/// <param name="oAnyOther">future param</param>
	/// <returns>If Successfully authenticated into the system</returns>
    //Authenticate(credentials: HttpRequest, context: HttpContext, AnyOther: object) : Boolean
}
