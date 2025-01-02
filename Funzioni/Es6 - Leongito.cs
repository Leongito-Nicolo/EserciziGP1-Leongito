public class Funzioni
{
    public static void Main(String[] args)
    {
        // 6. Scrivere una funzione che calcola il fattoriale di un numero.
        Console.WriteLine("Insert a number to calculate the factiorial: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The factorial is: " + CalculateFactorial(a));
    }

    public static int CalculateFactorial(int num)
    {
        if(num == 0) 
            return 1;
        else
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }

            return fact;
        }
    }
}
