using System;

class Program
{
    static void Main(string[] args)
    {   
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("blue", 5);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("red", 5, 3);
        shapes.Add(r1);

        Circle c1 = new Circle("green", 6);
        shapes.Add(c1);

        foreach (Shape shape in shapes){
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }   
    }
}