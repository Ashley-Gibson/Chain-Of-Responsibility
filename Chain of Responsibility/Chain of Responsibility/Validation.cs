namespace Chain_of_Responsibility
{
    public static class Validation
    {
        private readonly static string ValidationPassString = "true";

        public static bool ValidateInput(string validationString)
        {
            return validationString == ValidationPassString ? true : false;
        }
    }
}
