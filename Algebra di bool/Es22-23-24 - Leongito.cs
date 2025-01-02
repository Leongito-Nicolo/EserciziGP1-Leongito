public class AlgebraBool
{
    public static void Main(String[] args)
    {
        //22. Creare un programma che utilizza un if per verificare se un array è vuoto.
        int[] array = new int[0];

        if (array.Length == 0)
            Console.WriteLine("Array is empty");
        else
            Console.WriteLine("Array is not empty");


        //23. Utilizzare un if per verificare se un valore è un numero primo.
        int num = 139;
        if (num <= 1)
        {
            Console.WriteLine(num + " is not a prime number");
        }
        else
        {
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine(num + " is a prime number");
            }
            else
            {
                Console.WriteLine(num + " is not a prime number");
            }
        }

        //24. Scrivere un programma che utilizza un'istruzione if-else per verificare se una parola è palindroma.
        string s = "abba";
        string s1 = s.ToLower();

        if(s1.SequenceEqual(s1.Reverse()))
            Console.WriteLine(s + " is palindrome");
        else
            Console.WriteLine(s + " is not palindrome");


    }
}
