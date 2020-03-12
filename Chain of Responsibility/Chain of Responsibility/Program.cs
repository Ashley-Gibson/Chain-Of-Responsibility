using System;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroOutput();

            ChainStep Authentication = new Authentication();
            Authentication.CheckStep();
            ChainStep Authorisation = new Authorisation();
            Authorisation.CheckStep();
            ChainStep Validation = new Validation();
            Validation.CheckStep();

            ProgramPassed();
        }

        private static void IntroOutput()
        {
            Console.WriteLine("***** Chain of Responsibility *****");
        }

        private static void ProgramPassed()
        {
            Console.WriteLine("");
            Console.WriteLine("Well done you have completed the program.");
            Helper.EndProgramOutput();
        }
    }
}
