public class Triangle
{
    public double tBase;
    public double tHeight;

    public Triangle(double tBase, double tHeight)
    {
        this.tBase = tBase;
        this.tHeight = tHeight;
    }
}

public class Funzioni
{
    public static void Main(String[] args)
    {
        // 10. Scrivere una funzione che accetta e restituisce oggetti di una classe custom.
        Triangle triangle = new Triangle(4, 3);
        Console.WriteLine("Area of the first triangle: " + GetTriangleArea(triangle));

        Triangle doubleTriangle = DoubleSizedTriangle(triangle);
        Console.WriteLine("Area of the second triangle: " + GetTriangleArea(doubleTriangle));
    }

    public static double GetTriangleArea(Triangle t)
    {
        return (t.tBase * t.tHeight) / 2;
    }

    public static Triangle DoubleSizedTriangle(Triangle t)
    {
        t.tBase *= 2;
        t.tHeight *= 2;

        return t;
    }
}
