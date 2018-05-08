
	class Credentials {

		/// <summary>
		/// Company or Organization Name. Mandatory for Pethealth. Optional in OAuth
		/// </summary>
		private _companyOrContext: string;
		get CompanyOrContext(): string {
			return this._companyOrContext;
		}
		set CompanyOrContext(value: string) {
			this._companyOrContext = value;
		}

		/// <summary>
		/// Defaults to UserName if null. Otherwise it could be of various types as supported by the implementation. Maube Guid, maybe FaceBookId, Or whtever we identify as an ID.
		/// </summary>
		private _UserIdType: string;
		get UserIdType(): string {
			return this._UserIdType;
		}
		set UserIdType(value: string) {
			this._UserIdType = value;
		}

		/// <summary>
		/// Id of the type defined in 'UserIdType'
		/// </summary>
		private _UserId: string;
		get UserId(): string {
			return this._UserId;
		}
		set UserId(value: string) {
			this._UserId = value;
		}

		/// <summary>
		/// Password - optional if GrantToken is provided
		/// </summary>
		private _Password: string;
		get Password(): string {
			return this._Password;
		}
		set Password(value: string) {
			this._Password = value;
		}

		/// <summary>
		/// GrantToken - Optiona_GrantTokenl if Password is provided.
		/// </summary>
		private _GrantToken: string;
		get GrantToken(): string {
			return this._GrantToken;
		}
		set GrantToken(value: string) {
			this._GrantToken = value;
		}
	}
