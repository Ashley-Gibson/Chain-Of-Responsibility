using System;

namespace Chain_of_Responsibility
{
    public interface IChainStep
    {
        void CheckStep();
        bool CheckInput(string Input);       
    }

    public abstract class ChainStep : IChainStep
    {
        public abstract string PassString { get; set; }

        public void CheckStep()
        {
            Console.WriteLine("");
            Console.WriteLine($"***** {GetType().Name} Step *****");
            Console.WriteLine("");
        
            string inputString = Console.ReadLine();

            if (!CheckInput(inputString))
                StepFailed();
        }

        public bool CheckInput(string input)
        {
            return input == PassString;
        }

        private void StepFailed()
        {
            Console.WriteLine("");
            Console.WriteLine($"Error: {GetType().Name} failed.");
            Helper.EndProgramOutput();
        }
    }
}
