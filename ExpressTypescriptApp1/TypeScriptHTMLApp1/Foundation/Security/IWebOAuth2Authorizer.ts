
export interface IWebOAuth2Authorizer
{
	/// <summary>
	/// Method to Authorize the provided grant token. The method is likely to change signature depending on implementation. Remove this comment once frozen.
	/// </summary>
	/// <param name="credentials">HttpRequest object from which credentials can be extracted</param>
	/// <param name="context">HttpContext object from having accesss to cache etc</param>
	/// <param name="oAnyOther">future param</param>
	/// <returns>If Successfully authorised for the action</returns>
	//bool AuthorizeResource(HttpRequest credentials, HttpContext context, object oAnyOther);
}
