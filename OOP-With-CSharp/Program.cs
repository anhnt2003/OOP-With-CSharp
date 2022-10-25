using System;
using OOP_With_CSharp.Properties;

namespace OOP_With_CSharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(("HelloWorld"));

            Circle circle = new Circle("Circle", 0);
            Console.WriteLine(circle.GetName() +"GetArea: " + circle.GetArea());
            circle.Write("Pingpong");
            
            RightTriangle rightTriangle = new RightTriangle(1,1,"RightTriangle");
            Console.WriteLine(rightTriangle.GetName() + "GetArea: " + rightTriangle.GetArea());
        }
    }
}