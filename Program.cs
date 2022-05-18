using ExampleAbstractClass.Entities;
using ExampleAbstractClass.Entities.Enums;

Console.Clear();

List<Shape> listOfShapes = new List<Shape>();

Console.Write("Enter the number of shapes: ");
int numberOfShapes = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberOfShapes; i++)
{
    Console.Clear();

    Console.WriteLine($"Shape #{i} data:\n");

    char shapeType = ' ';

    while (shapeType != 'r' && shapeType != 'c')
    {
        Console.Write("Rectangle or Circle (r/c)?");
        shapeType = char.Parse(Console.ReadLine());
    }

    string color = "";

    while (color.ToLower() != "black" && color.ToLower() != "blue" && color.ToLower() != "red")
    {
        Console.Write("Color (Black/Blue/Red): ");
        color = Console.ReadLine();
    }

    if (shapeType == 'r')
    {
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine());

        listOfShapes.Add(new Rectangle(width, height, Enum.Parse<EColor>(color)));
    }
    else
    {
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine());

        listOfShapes.Add(new Circle(radius, Enum.Parse<EColor>(color)));
    }
}

Console.Clear();

Console.WriteLine("SHAPE AREAS:\n");

foreach (Shape shape in listOfShapes)
{
    Console.WriteLine(shape.Area());
}
