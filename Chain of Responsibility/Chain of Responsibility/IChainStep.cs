using System;

namespace Chain_of_Responsibility
{
    public interface IChainStep
    {
        bool CheckStep();
        bool CheckInput(string Input);       
    }

    public abstract class ChainStep : IChainStep
    {
        public abstract string PassString { get; set; }

        public bool CheckStep()
        {
            Console.WriteLine("");
            Console.WriteLine($"***** {GetType().Name} Step *****");
            Console.WriteLine("");
        
            string inputString = Console.ReadLine();

            return CheckInput(inputString);
        }

        public bool CheckInput(string input)
        {
            return input == PassString;
        }
    }
}
