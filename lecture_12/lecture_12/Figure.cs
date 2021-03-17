using System;

namespace lecture_12
{
    public class foursquare : Square
    {
        public string name;
        public int len;
        public foursquare()
        {
            name = "foursquare";
            len = 10;
        }

        public int Square()
        {
            return len * len;
        }
    }

    public class circle : Square
    {
        public string name;
        public int r;

        public circle()
        {
            name = "circle";
            Random rnd = new Random();
            r = rnd.Next(2, 10);
        }

        public double Square()
        {
            return (double)(Math.PI * r * r);
        }

        int Square.Square()
        {
            throw new NotImplementedException();
        }
    }

    public class triangle : Square
    {
        public string name;
        public int a;
        public int b;
        public int c;
        public int p;

        public triangle()
        {
            name = "triangle";
        }
        public double Square()
        {
            Random rnd = new Random();
            int a = rnd.Next(2, 10);
            int b = rnd.Next(2, 10);
            int c = rnd.Next(2, 10);
            double pol = (a + b + c) / 2;
            return (double)(Math.PI * pol);
        }
        int Square.Square()
        {
            throw new NotImplementedException();
        }
    }
}