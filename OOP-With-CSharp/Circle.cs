using System;
using OOP_With_CSharp.InterFace;
using OOP_With_CSharp.Properties;

namespace OOP_With_CSharp
{
    public class Circle : Shape, IFeature
    {
        private double _Radius { get; set; }

        public Circle() : this("", 0.0)
        {
            
        }
        
        public Circle(string name, double radius) : base(name)
        {
            _Radius = radius;
        }

        public override double GetArea()
        {
            return 2003;
        }

        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}