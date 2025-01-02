public class EnumsStructCast
{
    struct Point2D
    {
        public double X;
        public double Y;

        public Point2D(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double DistanceTo(Point2D otherPoint)
        {
            return Math.Sqrt(Math.Pow(otherPoint.X - this.X, 2) + Math.Pow(otherPoint.Y - this.Y, 2));
        }
    }

    struct Rectangle
    {
        public double Width;
        public double Height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Area()
        {
            return this.Width * this.Height;
        }
    }

    enum VehicleType
    {
        Car,
        Truck,
        Motorcycle,
        Bicycle
    }

    public static void Main(String[] args)
    {
        //4.Dichiarare una struct per rappresentare un punto 2D e calcolare la distanza tra due punti.
        Point2D point1 = new Point2D(0, 0);
        Point2D point2 = new Point2D(3, 4);
        Console.WriteLine("Distance: " + point1.DistanceTo(point2));

        //5. Creare una struct per rappresentare un rettangolo e calcolarne l'area. 
        Rectangle rectangle = new Rectangle(5, 10);
        Console.WriteLine("Area: " + rectangle.Area());

        //6. Utilizzare un enum per rappresentare i tipi di un veicolo in un programma.
        VehicleType vehicle = VehicleType.Car;
        Console.WriteLine("Selected vehicle type: " + vehicle);

    }
}