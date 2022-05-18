using ExampleAbstractClass.Entities.Enums;

namespace ExampleAbstractClass.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(EColor color) : base(color)
        {

        }

        public Rectangle(double width, double height, EColor color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}