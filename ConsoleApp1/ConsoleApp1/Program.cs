using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void EmptyArray()
        {
            var arr = new string[] { };
            Console.WriteLine(arr);
        }
        static void OneDimensionalArray()
        {
            object[] arr2 = new object[3] { 32, 'A', "Hello" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            int intBuffer = Convert.ToInt32(arr2[0]);
            intBuffer += 10;
            arr2[0] = intBuffer;
            string stringBuffer = Convert.ToString(arr2[2]);
            stringBuffer += " guys!";
            arr2[2] = stringBuffer;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
        static void Max13Array()
        {
            Random rand = new Random();
            int arr3buffer = 0;
            int[] arr3 = new int[13];
            for (int i = 0; i < arr3.Length - 1; i++)
            {
                arr3[i] = rand.Next(0, 50);
            }
            for (int i = 0; i < arr3.Length - 1; i++)
            {
                if (arr3[i] > arr3buffer)
                {
                    arr3buffer = arr3[i];
                }
            }
            for (int i = 0; i < arr3.Length - 1; i++)
            {
                Console.WriteLine(arr3[i]);
            }
            Console.WriteLine($"Макс. знач: {arr3buffer}");
        }
        static void boxingunboxing()
        {
            short keyShort = 426;
            Int16 netShort = -426;
            Console.WriteLine($"Тип{keyShort.GetType()}");
            Console.WriteLine($"Тип {netShort.GetType()}");
            Console.WriteLine();
        }
    }
}
