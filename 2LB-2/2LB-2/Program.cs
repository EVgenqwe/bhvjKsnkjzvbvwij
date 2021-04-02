using System;
namespace _2_1
{
     class Program
    {
        static void Main(string[] args)
    {
        DateTime date = DateTime.Now;
        string str1 = Convert.ToString(date), str2 = Convert.ToString(date.ToString("F"));
        int[] symbols = new int[10];
        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] >= 48 && str1[i] <= 57) symbols[str1[i] - 48]++;
        }
        Console.WriteLine("Текущее время (первый формат):\n" + str1);
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Количество символов " + '\'' + i + "\' = " + symbols[i]);
        }
        for (int i = 0; i < 10; i++)
        {
            symbols[i] = 0;
        }
        for (int i = 0; i < str2.Length; i++)
        {
            if (str2[i] >= 48 && str2[i] <= 57) symbols[str2[i] - 48]++;
        }
        Console.WriteLine("\n\n\nТекущее время (второй формат):\n" + str2);
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Количество символов " + '\'' + i + "\' = " + symbols[i]);
        }
    }
}
}