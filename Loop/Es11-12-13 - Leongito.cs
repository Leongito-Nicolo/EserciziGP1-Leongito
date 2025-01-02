public class Loop
{
    public static void Main(String[] args)
    {
        //11.Utilizzare un ciclo foreach per modificare i valori in una lista.
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i] *= 2;
        }
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        //12.Scrivere un ciclo do -while che calcola il totale di un array.
        int[] array = { 1, 2, 3, 4, 5 };
        int index = 0;
        int total = 0;
        do
        {
            total += array[index];
            index++;
        } while (index < array.Length);
        Console.WriteLine("Total: " + total);

        //13.Creare un ciclo for che utilizza un'istruzione break.
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                Console.WriteLine("Breaking at: " + i);
                break;
            }
            Console.WriteLine(i);
        }

    }
}
