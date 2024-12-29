public class AlgebraBool
{
    public static void Main(String[] args)
    {
        //19. Utilizzare un'istruzione if per verificare se un numero è divisibile per 3 e 5.
        int n = 15;

        if (n % 3 == 0 && n % 5 == 0)
            Console.WriteLine(n + " is divisible by 3 and 5");
        else
            Console.WriteLine(n + " is not divisible by 3 and 5");


        //20. Scrivere un'istruzione if per verificare se un valore booleano è true.
        bool value = false;

        if(value)
            Console.WriteLine("The value is true");
        else
            Console.WriteLine("The value is false");

        //21. Utilizzare un switch per valutare una variabile stringa.
        string s = "ab";

        switch (s)
        {
            case "ab":
                Console.WriteLine("ab");
                break;
            case "ba":
                Console.WriteLine("ba");
                break;
            case "cd":
                Console.WriteLine("cd");
                break;
            case "dc":
                Console.WriteLine("dc");
                break;
        }

    }
}
