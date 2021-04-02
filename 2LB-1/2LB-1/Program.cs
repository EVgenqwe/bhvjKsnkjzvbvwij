using System;

namespace _2LB_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vvedite:");
            string InputString2 = Console.ReadLine();
            for (int i = 0; i < InputString2.Length; i++)
            {
                char SearchSymbol = InputString2[i];
                if ((SearchSymbol >= 'А') && (SearchSymbol <= 'Я'))
                {
                    Console.WriteLine("Русская заглавная  буква:" + InputString2[i]);
                }
            }
        }
    }
}
