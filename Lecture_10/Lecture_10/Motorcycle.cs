using System;

namespace Lecture_10
{
    internal class Motorcycle : Engine
    {
        private int identifier { get; set; }
        private string model { get; set; }
        private string manufacturer { get; set; }
        private int year { get; set; }
        private float mileage { get; set; }

        public int Identifier
        {
            get
            {
                return identifier;
            }
            private set
            {
                Guid identifier = Guid.NewGuid();
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (value != null) model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                if (value != null) manufacturer = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                DateTime time = new DateTime();
                year = value == time.Year ? value : time.Year;
            }
        }
        public float Mileage
        {
            get
            {
                return mileage;
            }
            set
            {
                mileage = value;
            }
        }
    }
}