
using System;
namespace Project1
{
    class Triangle
    {
        int height, width, length;
        public Triangle()
        { }
        public Triangle(int height, int width, int length)
        {
            this.length = length;
            this.height = height;
            this.width = width;
            Console.WriteLine(height);
            Console.WriteLine(width);
            Console.WriteLine(length);




        }
        public double area()
        {


            double a = .5 * length * width * height;
            return a;


        }




    }
    class Main1
    {
        public static void Main(string[] args)
        {
            Triangle T1 = new Triangle(1, 2, 3);
            Console.WriteLine("Area: {0}", T1.area());
            Console.ReadKey();




        }

    }




}
