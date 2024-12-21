public class Funzioni
{
    public static void Main(String[] args)
    {
        // 7. Dichiarare una funzione che restituisce un valore di tipo bool basato su una condizione.
        Console.WriteLine("Even or odd? Insert a number to check: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        if (isEven(n1))
            Console.WriteLine("The number is even");
        else
            Console.WriteLine("The number is odd");
    }

    public static bool isEven(int num1)
    {
        if (num1 % 2 == 0) 
            return true;
        else 
            return false;
    }
}
