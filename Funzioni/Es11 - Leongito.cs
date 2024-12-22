public class Funzioni
{
    public static void Main(String[] args)
    {
        // 11. Scrivere una funzione che modifica una lista passata come parametro.
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };

        Console.Write("List: ");
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }

        DoubleEveryNumber(list);

        Console.Write("\n\nNew list: ");
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
    }

    public static List<int> DoubleEveryNumber(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i] *= 2;
        }

        return list;
    }
}
