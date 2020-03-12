using System;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroOutput();

            ChainStep Authentication = new Authentication();
            if (!Authentication.CheckStep())
            {
                StepFailed(Authentication);
                return;
            }

            ChainStep Authorisation = new Authorisation();
            if (!Authorisation.CheckStep())
            { 
                StepFailed(Authorisation);
                return;
            }

            ChainStep Validation = new Validation();
            if (!Validation.CheckStep())
            {
                StepFailed(Validation);
                return;
            }

            ProgramPassed();
        }

        private static void IntroOutput()
        {
            Console.WriteLine("***** Chain of Responsibility *****");
        }

        private static void StepFailed(IChainStep ChainStep)
        {
            Console.WriteLine("");
            Console.WriteLine($"Error: {ChainStep.GetType().Name} failed.");
            Helper.EndProgramOutput();
        }

        private static void ProgramPassed()
        {
            Console.WriteLine("");
            Console.WriteLine("Well done you have completed the program.");
            Helper.EndProgramOutput();
        }
    }
}
