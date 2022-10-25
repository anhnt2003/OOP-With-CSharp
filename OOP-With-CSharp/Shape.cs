namespace OOP_With_CSharp.Properties
{
    public abstract class Shape
    {
        private string _Name { get; set; }

        public Shape() : this("")
        {
            
        }

        public Shape(string name)
        {
            _Name = name;
        }

        public abstract double GetArea();

        public string GetName()
        {
            return _Name;
        }
        
    }
}