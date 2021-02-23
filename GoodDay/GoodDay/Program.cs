using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan timeOfDay = DateTime.Now.TimeOfDay;
            Console.WriteLine(timeOfDay);
            int interval = timeOfDay.Hours;
            if (interval >= 9 & interval <= 12)
            {
                Console.WriteLine("Good morning,guys");
            }
            else if (interval > 12 & interval <= 15)
            {
                Console.WriteLine("Good day,guys");
            }
            else if (interval > 15 & interval <= 22)
            {
                Console.WriteLine("Good evening,guys");
            }

            else if (interval > 22 | interval < 9)
            {
                Console.WriteLine("Good night,guys");
            }
            Console.ReadKey();
        }
    }
}