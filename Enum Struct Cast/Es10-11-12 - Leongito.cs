public class EnumsStructCast
{
    struct ColorRGB
    {
        public byte Red;
        public byte Green;
        public byte Blue;

        public ColorRGB(byte red, byte green, byte blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }

        public override string ToString()
        {
            return "RGB(" + this.Red + "," + this.Green + "," + this.Blue + ")";
        }
    }

    enum DrinkSize 
    { 
        Small, 
        Medium, 
        Large 
    }

    struct StaticPoint
    {
        public readonly double X { get; }
        public readonly double Y { get; }

        public StaticPoint(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    public static void Main(String[] args)
    {
        //10.Creare una struct per rappresentare un colore in formato RGB.
        ColorRGB color = new ColorRGB(255, 0, 0);
        Console.WriteLine(color);

        //11. Utilizzare un enum in una funzione per selezionare un'opzione. 
        PrintDrinkSize(DrinkSize.Medium);

        //12. Dichiarare una struct con proprietà readonly. 
        StaticPoint point = new StaticPoint(3, 4);
        Console.WriteLine("Point: " + point.X + ", " + point.Y);

    }

    static void PrintDrinkSize(DrinkSize size)
    {
        Console.WriteLine("Selected drink size: " + size);
    }
}