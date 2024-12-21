public class Funzioni
{
    public static void Main(String[] args)
    {
        // 5. Scrivere una funzione che accetta un array come parametro.
        int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("The sum of every number in the array is: " + SumOfElements(num));
    }

    public static int SumOfElements(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }
}
