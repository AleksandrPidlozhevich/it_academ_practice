using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи слово с большим количеством букв а :");
            string word = Console.ReadLine();
            char[] letter = "Aa".ToCharArray();
            int count = 0;
            foreach (char letterA in word)
            {
                if (letter.Contains(letterA))
                {
                    count++;
                }
            }
            Console.WriteLine("в твоём слове {0}", count + " " + "буквы a");
            Console.ReadKey();
        }
    }
}