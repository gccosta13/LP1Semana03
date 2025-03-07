using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                if (arg.Length >= 8)
                {
                    Console.WriteLine("[EARLY STOP]");
                    return; // Termina o programa imediatamente
                }

                if (arg.Length > 3)
                {
                    Console.WriteLine(arg);
                }
            }
        }
    }
}

