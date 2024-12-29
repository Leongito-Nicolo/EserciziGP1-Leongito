public class Loop
{
    public static void Main(String[] args)
    {
        //4.Scrivere un ciclo for che calcola la somma di un array.
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine("Sum: " + sum);

        //5.Utilizzare un ciclo foreach per iterare attraverso una lista di stringhe.
        List<string> names = new List<string> { "Luca", "Sara", "Silvia" };
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        //6.Creare un ciclo for che calcola il fattoriale di un numero.
        int number = 5;
        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("Factorial: " + factorial);
    }
}
