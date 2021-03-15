using System;

namespace Lecture_10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Motorcycle moto = new Motorcycle();
                Console.WriteLine("Введите модель");
                moto.Model = Console.ReadLine();
                Console.WriteLine("Введите производителя");
                moto.Manufacturer = Console.ReadLine();
                Console.WriteLine("Введите пробег");
                moto.Mileage = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите объем");
                moto.Volume = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите мощность");
                moto.Power = int.Parse(Console.ReadLine());
            }
        }
        private static Motorcycle GetStartProgram()
        {
            Motorcycle[] motoArray = new Motorcycle[3];
            motoArray[0] = GetStartProgram();
            motoArray[1] = GetStartProgram();
            motoArray[2] = GetStartProgram();
            foreach (var item in motoArray)
            {
                Console.WriteLine("Производитель" + item.Manufacturer + "Модель" + item.Model + "Индендификатор" + item.Identifier + "Probeg = " + item.Mileage + "Год" + item.Year);
            }
        }
    }
}