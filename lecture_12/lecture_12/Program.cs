using System;

namespace lecture_12
{
    class Program
    {
        static void Main(string[] args)
        {
            foursquare foursquare = new foursquare();
            circle circle = new circle();
            triangle triangle = new triangle();

            object[] arr = { foursquare, circle, triangle };

            Console.WriteLine("This is " + foursquare.name + ".CLR type is " + foursquare.GetType() + ". Square is " + foursquare.Square());
            Console.WriteLine("This is " + circle.name + ".CLR type is " + circle.GetType() + ". Square is " + circle.Square());
            Console.WriteLine("This is " + triangle.name + ".CLR type is " + triangle.GetType() + ". Square is " + triangle.Square());


        }
    }
}