public class Loop
{
    public static void Main(String[] args)
    {
        //23.Utilizzare un ciclo while per cercare un valore specifico in un array.
        int[] numbers = { 5, 10, 15, 20, 25 };
        int searchValue = 15;
        int index = 0;
        bool found = false;
        while (index < numbers.Length)
        {
            if (numbers[index] == searchValue)
            {
                found = true;
                break;
            }
            index++;
        }
        Console.WriteLine("Value found: " + found);

        //24.Scrivere un ciclo for che calcola la media di un array.
        int[] values = { 2, 4, 6, 8, 10 };
        int sum = 0;
        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }
        double average = (double)sum / values.Length;
        Console.WriteLine("Average: " + average);

        //25.Creare un ciclo foreach che copia valori da un array a un altro.
        int[] sourceArray = { 1, 2, 3, 4, 5 };
        int[] targetArray = new int[sourceArray.Length];
        foreach (int value in sourceArray)
        {
            targetArray[Array.IndexOf(sourceArray, value)] = value;
        }

    }
}
