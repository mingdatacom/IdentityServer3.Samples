namespace Sample
{
    public static class Constants
    {
        public const string BaseAddress = "http://localhost:8080/openid-connect-server-webapp";
        
        public const string AuthorizeEndpoint = BaseAddress + "/authorize";
        public const string LogoutEndpoint = BaseAddress + "/connect/endsession";
        public const string TokenEndpoint = BaseAddress + "/token";
        public const string UserInfoEndpoint = BaseAddress + "/userinfo";
        public const string IdentityTokenValidationEndpoint = BaseAddress + "/connect/identitytokenvalidation";
        public const string TokenRevocationEndpoint = BaseAddress + "/revoke";

        public const string AspNetWebApiSampleApi = "http://localhost:8080/openid-connect-server-webapp/";
        public const string AspNetWebApiSampleApiUsingPoP = "http://localhost:46613/";
    }
}