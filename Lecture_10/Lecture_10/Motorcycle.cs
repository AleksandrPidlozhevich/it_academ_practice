using System;

namespace Lecture_10
{
    class Motorcycle
    {
        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public int Year { get; set; }

        public int Identifier { get; set; }
        public int Ident()
        {
            var guid = Guid.NewGuid().ToString();
        }

        public string ToString()
        {
            return $" {Manufacturer} {Model} {Year} ";
        }
    }
}