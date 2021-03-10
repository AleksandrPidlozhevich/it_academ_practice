using System;

namespace Lecture_10
{
    internal class Engine
    {
        int power;
        int volume;
        public int Power
        {
            get
            {
                return power;
            }
            set
            {
                Random rnd = new Random();
                value = rnd.Next(50, 300);
                power = value;
            }
        }
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                Random rnd = new Random();
                value = rnd.Next(125, 3200);
                volume = value;
            }
        }
    }
}