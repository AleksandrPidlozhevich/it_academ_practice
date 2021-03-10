using Lecture_10;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_12
{
    class Engine : Motorcycle
    {
        public int PowerMotorcycle(int side)
        {
            Random rnd = new Random();
            int power = rnd.Next(50, 30);
            return power;
        }
        public double VolumeMotorcycle(int radius)
        {
            Random rnd = new Random();
            int volume = rnd.Next(125, 3200);
            return volume;
        }
    }
}