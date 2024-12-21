public class Funzioni
{
    public static void Main(String[] args)
    {
        // 8. Creare una funzione che utilizza un'eccezione per gestire input non validi. (try - catch)
        int n;
        do
        {
            Console.WriteLine("Insert a number between 5 and 100: ");
            n = Convert.ToInt32(Console.ReadLine());
        } while (!isValid(n));
    }

    public static bool isValid(int num1)
    {
        try
        {
            if (num1 < 5 || num1 > 100)
                throw new Exception();
            return true;
        }catch (Exception)
        {
            Console.WriteLine("The number is invalid!");
            return false;
        }
    }
}
