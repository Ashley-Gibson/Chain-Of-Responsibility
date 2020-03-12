namespace Chain_of_Responsibility
{
    public static class Authorisation
    {
        private readonly static string AuthorisationPassString = "true";

        public static bool AuthoriseInput(string authorisationString)
        {
            return authorisationString == AuthorisationPassString ? true : false;
        }
    }
}
