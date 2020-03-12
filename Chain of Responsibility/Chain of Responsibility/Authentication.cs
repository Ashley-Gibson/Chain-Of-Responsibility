namespace Chain_of_Responsibility
{
    public static class Authentication
    {
        private readonly static string AuthenticationPassString = "true";

        public static bool AuthenticateInput(string authenticationString)
        {                    
            return authenticationString == AuthenticationPassString ? true : false;
        }
    }
}
