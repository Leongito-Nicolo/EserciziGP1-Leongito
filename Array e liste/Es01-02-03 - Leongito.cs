public class ArrayListe
{
    public static void Main(String[] args)
    {
        //1.Creare un array di int con 5 elementi e stamparne i valori.
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int number in numbers)
        {
            Console.WriteLine("Number: " + number);
        }

        //2.Dichiarare una lista di stringhe e aggiungere elementi dinamicamente.
        List<string> names = new List<string>();
        names.Add("Marco");
        names.Add("Lucia");
        names.Add("Angelo");
        foreach (string name in names)
        {
            Console.WriteLine("Name: " + name);
        }

        //3.Creare un array bidimensionale e popolarlo con valori. ([,])
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write(matrix[rows, cols] + " ");
            }
            Console.WriteLine();
        }

    }
}
