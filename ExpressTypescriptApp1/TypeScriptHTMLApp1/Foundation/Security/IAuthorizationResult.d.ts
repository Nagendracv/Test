export interface IAuthorizationResult {
    Result: boolean;
    PermanentAccessToken: string;
    TemporaryAccessToken: string;
    UnusedAccessTokenExpiresIn: number;
    FailureId: string;
    FailureReasons: string;
}
