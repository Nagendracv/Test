export interface IAuthenticationResult {
    Result: boolean;
    UserName: string;
    UserId: string;
    SuccessGrantToken: string;
    UnusedGrantExpiresIn: number;
    FailureId: string;
    FailureReasons: string;
}
