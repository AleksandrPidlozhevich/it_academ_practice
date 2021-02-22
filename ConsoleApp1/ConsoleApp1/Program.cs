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
            object[] array2 = new object[3] { 32, 'A', "Hello" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(array2[i]);
            }

            int intBuffer = Convert.ToInt32(array2[0]);
            intBuffer += 10;
            array2[0] = intBuffer;
            string stringBuffer = Convert.ToString(array2[2]);
            stringBuffer += " guys!";
            array2[2] = stringBuffer;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(array2[i]);
            }
        }
    }
}
