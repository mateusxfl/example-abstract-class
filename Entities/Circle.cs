using ExampleAbstractClass.Entities.Enums;

namespace ExampleAbstractClass.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(EColor color) : base(color)
        {

        }

        public Circle(double radius, EColor color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}