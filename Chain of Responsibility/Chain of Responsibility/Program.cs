using System;

namespace Chain_of_Responsibility
{
    class Program
    {
        static bool authenticated = false;
        static bool authorised = false;
        static bool validated = false;

        static void Main(string[] args)
        {
            IntroOutput();           
            
            authenticated = AuthenticationStep();

            if (authenticated)
                authorised = AuthorisationStep();
            else
            {
                StepFailed("User not Authenticated");
                return;
            }

            if(authorised)
                validated = ValidationStep();
            else
            { 
                StepFailed("User not Authorised");
                return;
            }

            if (validated)
                ProgramPassed();
            else
            { 
                StepFailed("User not Validated");
                return;
            }
        }

        private static void IntroOutput()
        {
            Console.WriteLine("***** Chain of Responsibility *****");
        }

        private static bool AuthenticationStep()
        {
            Console.WriteLine("");
            Console.WriteLine("***** Link 1 - Authentication *****");
            Console.WriteLine("");

            string authenticationString = Console.ReadLine();
            return Authentication.AuthenticateInput(authenticationString);
        }

        private static bool AuthorisationStep()
        {
            Console.WriteLine("");
            Console.WriteLine("***** Link 2 - Authorisation *****");
            Console.WriteLine("");

            string authorisationString = Console.ReadLine();
            return Authorisation.AuthoriseInput(authorisationString);
        }

        private static bool ValidationStep()
        {
            Console.WriteLine("");
            Console.WriteLine("***** Link 3 - Validation *****");
            Console.WriteLine("");

            string validationString = Console.ReadLine();
            return Validation.ValidateInput(validationString);
        }

        private static void EndProgramOutput()
        {
            Console.WriteLine("");
            Console.Write("Press any key to end...");
            Console.ReadKey();
        }

        private static void StepFailed(string ErrorMessage)
        {
            Console.WriteLine("");
            Console.WriteLine("Error: " + ErrorMessage);
            EndProgramOutput();
        }

        private static void ProgramPassed()
        {
            Console.WriteLine("");
            Console.WriteLine("Well done you have completed the program.");
            EndProgramOutput();
        }
    }
}
