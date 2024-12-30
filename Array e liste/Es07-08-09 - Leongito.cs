public class ArrayListe
{
    public static void Main(String[] args)
    {
        //7.Dichiarare una lista di numeri e ordinarla.
        List<int> numbers = new List<int> { 5, 2, 8, 1, 3 };
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine("Number: " + number);
        }

        //8.Utilizzare un array per contare la frequenza di un valore.
        int[] num = { 1, 2, 2, 3, 3, 3, 4 };
        int valueToCount = 3;
        int count = num.Count(n => n == valueToCount);
        Console.WriteLine("Frequency of " + valueToCount + ": " + count);

        //9.Creare una lista di stringhe e rimuovere elementi specifici.
        List<string> names = new List<string> { "Luca", "Sara", "Federico", "Alice" };
        names.Remove("Luca");
        foreach (string name in names)
        {
            Console.WriteLine("Name: " + name);
        }

    }
}
