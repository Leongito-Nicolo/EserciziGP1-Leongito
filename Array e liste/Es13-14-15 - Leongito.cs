public class CustomItem
{
    public string Description;

    public CustomItem(string description)
    {
        this.Description = description;
    }
}

public class ArrayListe
{
    public static void Main(String[] args)
    {
        //13.Dichiarare una lista e cercare un elemento al suo interno.
        List<string> names = new List<string> { "Marta", "Luca", "Sofia" };
        string searchName = "Sofia";
        bool found = names.Contains(searchName);
        Console.WriteLine("Found " + searchName + ": " + found);

        //14.Creare un array di oggetti e iterare sui valori.
        CustomItem[] items = new CustomItem[]
        {
            new CustomItem("Item1"),
            new CustomItem("Item2"),
            new CustomItem("Item3")
        };

        foreach (CustomItem item in items)
        {
            Console.WriteLine("Item description: " + item.Description);
        }

        //15.Utilizzare una lista per memorizzare i punteggi di un gioco.
        List<int> scores = new List<int> { 100, 200, 150, 300 };
        foreach (int score in scores)
        {
            Console.WriteLine("Score: " + score);
        }

    }
}
