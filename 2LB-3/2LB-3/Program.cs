using System;

namespace _2LB_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String:");
            string InputString1 = Console.ReadLine();
            string[] Words = InputString1.Split(' ');
            for (int i = Words.Length - 1; i >= 0; i--)
            {
                Console.Write(Words[i] + " ");
            }
        }
    }
}
