using System;

namespace lecture_13
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueItem item1 = new UniqueItem();

            Console.WriteLine(item1._id);

            UniqueItem item2 = new UniqueItem();

            Console.WriteLine(item2._id);

            UniqueItem.Id = 1000;

            UniqueItem item3 = new UniqueItem();

            Console.WriteLine(item3._id);

            UniqueItem item4 = new UniqueItem();

            Console.WriteLine(item4._id);

        }
    }
}