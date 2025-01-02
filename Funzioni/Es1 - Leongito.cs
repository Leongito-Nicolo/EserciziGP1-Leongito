public class Funzioni
{
    public static void Main(String[] args)
    {
        // 1. Dichiarare una funzione che restituisce un valore di tipo int e accetta due parametri.
        int a, b;
        Console.WriteLine("Insert first number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insert second number: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The sum of a and b is: " + Somma(a, b));
    }

    public static int Somma(int n1, int n2)
    {
        return n1 + n2;
    }
}
