using System;

class Program
{
    static void Main(string[] args)
    {
        Square theSquare = new Square ("blue", 5);
        Rectangle theRectangle = new Rectangle ("red" , 10, 5);
        Circle theCircle = new Circle ("orange", 6.9);

        List<Shape> theShapes = new List<Shape>();
        theShapes.Add(theSquare);
        theShapes.Add(theRectangle);
        theShapes.Add(theCircle);

        foreach (var shape in theShapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}