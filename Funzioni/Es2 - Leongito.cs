public class Funzioni
{
    public static void Main(String[] args)
    {
        // 2. Creare una funzione void che stampa un messaggio a console.
        Console.WriteLine("Insert the message to print: ");
        string message = Console.ReadLine();
        PrintMessage(message);
    }

    public static void PrintMessage(string message)
    {
        Console.WriteLine("The message is: " + message);
    }
}
