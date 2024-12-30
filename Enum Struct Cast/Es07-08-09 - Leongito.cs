public class EnumsStructCast
{
    struct Circle
    {
        public double Radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Circumference()
        {
            return 2 * Math.PI * this.Radius;
        }
    }

    enum Status
    {
        Pending = 1,
        Approved = 2,
        Rejected = 3
    }

    enum Colors 
    { 
        Red = 1, 
        Yellow = 2, 
        Blue = 3 
    }

    public static void Main(String[] args)
    {
        //7.Dichiarare una struct con un costruttore e un metodo.
        Circle circle = new Circle(5);
        Console.WriteLine("Circumference: " + circle.Circumference());

        //8. Scrivere un programma che converte un valore int in un enum usando il casting.
        int statusValue = 2;
        Status status = (Status)statusValue;
        Console.WriteLine("Status: " + status);

        //9. Dichiarare un enum con valori personalizzati e verificarne l'uso. 
        Colors code = Colors.Red;
        Console.WriteLine("Color code: " + (int)code);

    }
}