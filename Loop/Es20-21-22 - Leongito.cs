public class Loop
{
    public static void Main(String[] args)
    {
        //20.Utilizzare un ciclo foreach per calcolare la lunghezza totale di tutte le stringhe in una lista.
        List<string> words = new List<string> { "apple", "banana", "cherry" };
        int totalLength = 0;
        foreach (string word in words)
        {
            totalLength += word.Length;
        }
        Console.WriteLine("Total length of words: " + totalLength);

        //21.Scrivere un ciclo do -while che stampa un menu fino a quando l'utente sceglie di uscire.
        int choice;
        do
        {
            Console.WriteLine("1. Option 1");
            Console.WriteLine("2. Option 2");
            Console.WriteLine("3. Exit");
            choice = Convert.ToInt32(Console.ReadLine());
        } while (choice != 3);

        //22.Creare un ciclo for che utilizza una condizione complessa.
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("Number: " + i);
            }
        }

    }
}
