public class ArrayListe
{
    public static void Main(String[] args)
    {
        //19.Dichiarare una lista e modificarne gli elementi in base alla loro posizione.
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i] *= 2;
        }

        foreach (int number in numbers)
        {
            Console.WriteLine("Modified number: " + number);
        }

        //20.Creare un array di stringhe e concatenare tutti i valori in un'unica stringa.
        string[] words = { "Hello,", "World", "!" };
        string result = string.Join(" ", words);
        Console.WriteLine("Concatenated string: " + result);

        //21.Utilizzare una lista per memorizzare dati inseriti dall'utente.
        List<string> userInput = new List<string>();
        Console.WriteLine("Enter words (type 'stop' to finish):");
        string input;
        while ((input = Console.ReadLine()) != "stop")
        {
            userInput.Add(input);
        }

        foreach (string word in userInput)
        {
            Console.WriteLine("You entered: " + word);
        }

    }
}
