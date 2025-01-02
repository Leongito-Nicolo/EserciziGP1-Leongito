public class ArrayListe
{
    public static void Main(String[] args)
    {
        //22.Dichiarare un array di numeri casuali.
        Random random = new Random();
        int[] randomNumbers = new int[5];
        for (int i = 0; i < randomNumbers.Length; i++)
        {
            randomNumbers[i] = random.Next(1, 101);
        }

        foreach (int number in randomNumbers)
        {
            Console.WriteLine("Random number: " + number);
        }

        //23.Creare una lista che accetta solo valori superiori a 10.
        List<int> numbers = new List<int> { 5, 15, 20, 3, 12 };
        List<int> filteredNumbers = numbers.Where(n => n > 10).ToList();

        foreach (int number in filteredNumbers)
        {
            Console.WriteLine("Filtered number: " + number);
        }

        //24.Utilizzare un array per rappresentare una tabella di moltiplicazione.
        int[] molt = new int[11];
        for (int i = 0; i < molt.Length; i++)
        {
            molt[i] = i * 3;
        }

        foreach (int num in molt)
        {
            Console.WriteLine(num);
        }

        //25.Dichiarare una lista e convertirla in array.
        List<string> names = new List<string> { "Marco", "Sara", "Marta" };
        string[] namesArray = names.ToArray();

        foreach (string name in namesArray)
        {
            Console.WriteLine("Name: " + name);
        }

    }
}
