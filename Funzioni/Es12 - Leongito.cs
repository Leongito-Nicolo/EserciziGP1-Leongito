public class Funzioni
{
    public static void Main(String[] args)
    {
        // 12. Creare una funzione che utilizza un'espressione condizionale per determinare il valore restituito. (if else)
        Console.WriteLine("Insert a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (IsDivisibleBySeven(num))
            Console.WriteLine("The number " + num + " is divisible by 7");
        else
            Console.WriteLine("The number " + num + " is not divisible by 7");
    }

    public static bool IsDivisibleBySeven(int n)
    {
        if (n % 7 == 0)
            return true;
        else
            return false;
    }
}
