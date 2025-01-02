public class Loop
{
    public static void Main(String[] args)
    {
        //7.Scrivere un ciclo while che verifica se un numero è primo.
        int primeCandidate = 29;
        bool isPrime = true;
        int k = 2;
        while (k <= Math.Sqrt(primeCandidate))
        {
            if (primeCandidate % k == 0)
            {
                isPrime = false;
                break;
            }
            k++;
        }
        Console.WriteLine(primeCandidate + " is prime: " + isPrime);

        //8.Utilizzare un ciclo do -while per stampare i numeri pari fino a un massimo.
        int evenNumber = 2;
        do
        {
            Console.WriteLine(evenNumber);
            evenNumber += 2;
        } while (evenNumber <= 20);

        //9.Scrivere un ciclo for che stampa i numeri in ordine inverso.
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        //10. Creare un ciclo while che calcola il prodotto dei numeri fino a un valore specifico.
        int product = 1;
        int counter = 1;
        while (counter <= 5)
        {
            product *= counter;
            counter++;
        }
        Console.WriteLine("Product: " + product);
    }
}
