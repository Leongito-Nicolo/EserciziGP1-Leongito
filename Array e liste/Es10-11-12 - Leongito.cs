public class ArrayListe
{
    public static void Main(String[] args)
    {
        //10.Dichiarare un array e inizializzarlo con valori predefiniti.
        int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
        foreach (int number in numbers)
        {
            Console.WriteLine("Number: " + number);
        }

        //11.Creare una lista che accetta solo valori univoci.
        HashSet<int> uniqueNumbers = new HashSet<int> { 1, 2, 3, 3, 4 };
        foreach (int number in uniqueNumbers)
        {
            Console.WriteLine("Unique number: " + number);
        }

        //12.Utilizzare un array per rappresentare una matrice di 3x3.
        int[,] matrix = new int[3, 3] {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

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
