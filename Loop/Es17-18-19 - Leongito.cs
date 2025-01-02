public class Loop
{
    public static void Main(String[] args)
    {
        //17.Utilizzare un ciclo do -while che verifica un valore booleano prima di continuare.
        bool keepRunning = true;
        do
        {
            Console.WriteLine("The loop is running...");
            keepRunning = false;
        } while (keepRunning);

        //18.Scrivere un ciclo for che calcola la somma dei numeri dispari.
        int sumOdd = 0;
        for (int i = 1; i <= 20; i++)
        {
            if(i % 2 != 0)
                sumOdd += i;
        }
        Console.WriteLine("Sum of odd numbers: " + sumOdd);

        //19.Creare un ciclo while che termina quando un valore raggiunge una soglia.
        int max = 0;
        while (max < 50)
        {
            Console.WriteLine("Max: " + max);
            max += 10;
        }

    }
}
