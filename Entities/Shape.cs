using ExampleAbstractClass.Entities.Enums;

namespace ExampleAbstractClass.Entities
{
    abstract class Shape
    {
        public EColor Color { get; set; }

        public Shape(EColor color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}