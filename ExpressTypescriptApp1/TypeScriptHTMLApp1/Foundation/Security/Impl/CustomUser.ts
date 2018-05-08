
export class CustomUser
{
    /// <summary>
    /// User Id
    /// </summary>
    private _id: string;
    get Id(): string
    {
        return this._id;
    }
    set Id(value: string)
    {
        this._id = value;
    }

	/// <summary>
	/// User Name
	/// </summary>
    private _name: string;
    get Name(): string
    {
        return this._name;
    }
    set Name(value: string)
    {
        this._name = value;
    }

	/// <summary>
	/// Password
	/// </summary>
    private _password: string;
    get Password(): string
    {
        return this._password;
    }
    set Password(value: string)
    {
        this._password = value;
    }

	/// <summary>
	/// PasswordHash
	/// </summary>
    private _passwordHash: string;
    get PasswordHash(): string
    {
        return this._passwordHash;
    }
    set PasswordHash(value: string)
    {
        this._passwordHash = value;
    }

	/// <summary>
	/// GrantToken
	/// </summary>
    private _grantToken: string;
    get GrantToken(): string
    {
        return this._grantToken;
    }
    set GrantToken(value: string)
    {
        this._grantToken = value;
    }

	/// <summary>
	/// CompanyOrContext
	/// </summary>
    private _companyOrContext: string;
    get CompanyOrContext(): string
    {
        return this._companyOrContext;
    }
    set CompanyOrContext(value: string)
    {
        this._companyOrContext = value;
    }
}
