using OOP_With_CSharp.Properties;

namespace OOP_With_CSharp
{
    public class RightTriangle : Shape
    {
        private double _Length { get; set; }
        private double _Height { get; set; }

        public RightTriangle() : this(1, 2, "RightTriangle")
        {
            
        }

        public RightTriangle(double length, double height, string name) : base(name)
        {
            _Height = height;
            _Length = length;    
        }

        public override double GetArea()
        {
            throw new System.NotImplementedException();
        }
    }
}