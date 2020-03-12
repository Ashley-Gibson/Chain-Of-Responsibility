using System;

namespace Chain_of_Responsibility
{
    public static class Helper
    {
        public static void EndProgramOutput()
        {
            Console.WriteLine("");
            Console.Write("Press any key to end...");
            Console.ReadKey();
            return;
        }
    }
}
