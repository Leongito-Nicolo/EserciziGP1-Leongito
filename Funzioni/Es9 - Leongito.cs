public class Funzioni
{
    public static void Main(String[] args)
    {
        // 9. Dichiarare una funzione che restituisce una lista di numeri.
        List<int> intList = GetList();

        Console.Write("List: ");
        foreach (var item in intList)
        {
            Console.Write(item + " ");
        }
    }

    public static List<int> GetList()
    {
        List<int> list = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            list.Add(i);
        }

        return list;
    }
}
