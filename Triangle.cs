
using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle obj = new Triangle();
            Console.WriteLine("Enter the x: ");
            obj.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y: ");
            obj.Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the z: ");
            obj.Z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x is : " + obj.X);
            Console.WriteLine("y is : " + obj.Y);
            Console.WriteLine("z is : " + obj.Z);
            obj.TestTriangle();

        }
    }

    public class Triangle
    {
        private int x;
        private int y;
        private int z;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        public void TestTriangle()
        {
            if (x == y && x == z)
            {
                Console.WriteLine("The triangle is equilateral");
            }
            else if (x == y || x == z || y == z)
            {
                Console.WriteLine("The triangle is isosceles");
            }
            else
            {
                Console.WriteLine("The triangle is scalene");
            }
        }
    }
}