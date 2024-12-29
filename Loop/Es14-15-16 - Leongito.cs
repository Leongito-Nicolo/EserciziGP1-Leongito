public class Loop
{
    public static void Main(String[] args)
    {
        //14.Utilizzare un ciclo while che termina con un'istruzione continue.
        int number = 0;
        while (number < 10)
        {
            number++;
            if (number % 2 == 0) 
                continue;
            Console.WriteLine(number);
        }

        //15.Scrivere un ciclo for che utilizza una variabile dichiarata all'esterno del ciclo.
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 != 0) 
                sum += i;
        }
        Console.WriteLine(sum);

        //16.Creare un ciclo foreach che stampa gli indici e i valori di un array.
        string[] items = { "apple", "banana", "cherry" };
        foreach (string item in items)
        {
            Console.WriteLine(item.Length);
        }

    }
}
