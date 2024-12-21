public class Funzioni
{
    public static void Main(String[] args)
    {
        // 3. Scrivere una funzione che accetta un parametro string e restituisce la lunghezza della stringa.
        Console.WriteLine("Insert the string to calculate length: ");
        string a = Console.ReadLine();
        Console.WriteLine("The length of the string is: " + StringLength(a));
    }

    public static int StringLength(string stringToCalculate)
    {
        return stringToCalculate.Length;
    }
}
