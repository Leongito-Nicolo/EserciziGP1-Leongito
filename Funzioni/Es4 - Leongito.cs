public class Funzioni
{
    public static void Main(String[] args)
    {
        // 4. Dichiarare una funzione con un parametro opzionale.
        Console.WriteLine("3 to the second power: " + Pow(3));
        Console.WriteLine("4 to the third power: " + Pow(4, 3));
    }

    public static int Pow(int num, int pow = 2)
    {
        return (int)Math.Pow(num, pow);
    }
}
