namespace GOSLibraries.GOS_Financial_Identity
{
    public class GeneralApiRoutes
    {
        public const string Root = "api";

        public const string Version = "v1";

        public const string Base = Root + "/" + Version;

        public static class Identity
        {
            public const string LOGIN = Base + "/identity/login";
            public const string REGISTER = Base + "/identity/register";
            public const string REFRESHTOKEN = Base + "/identity/refresh";
            public const string CHANGE_PASSWORD = Base + "/identity/changePassword";
            public const string CONFIRM_EMAIL = Base + "/identity/confirmEmail";
            public const string FETCH_USERDETAILS = Base + "/identity/profile";
            public const string CONFIRM_CODE = Base + "/identity/confirmCode";
            public const string GET_PERMIT_DEATAILS = "/identity/permitDetails";
        }
    }
}
