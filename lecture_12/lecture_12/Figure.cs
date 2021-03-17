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
        const int pi = 3;
        public int r;

        public circle()
        {
            name = "circle";
            Random rnd = new Random();
            r = rnd.Next(1, 10);
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
        public int len;
        public int hight;

        public triangle()
        {
            name = "triangle";
            Random rnd = new Random();
            int len = rnd.Next(1, 10);
            int hight = rnd.Next(1, 10);
        }


        public double Square()
        {
            return (double)(len * hight * 0.5);
        }

        int Square.Square()
        {
            throw new NotImplementedException();
        }
    }
}