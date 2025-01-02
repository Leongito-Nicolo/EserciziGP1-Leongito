public class AlgebraBool
{
    public static void Main(String[] args)
    {
        //10. Utilizzare un operatore ternario per assegnare un valore a una variabile.
        Console.WriteLine("Insert a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        string result = (n % 2 == 0) ? "even" : "odd";
        Console.WriteLine("The number is " + result);

        //11. Scrivere una serie di if-else per verificare più condizioni.
        int age = 21;
        bool hasPassedTheory = true, hasPassedPractice = false;

        if  (age >= 18)
            Console.WriteLine("\n\nThis person has the sufficient age\n");
        else
            Console.WriteLine("This person has not the sufficient age\n");

        if (hasPassedTheory)
            Console.WriteLine("This person has passed the theorical exam\n");
        else
            Console.WriteLine("This person has not passed the theorical exam\n");

        if (hasPassedPractice)
            Console.WriteLine("This person has passed the practical exam\n");
        else
            Console.WriteLine("This person has not passed the practical exam\n");

        if(age >= 18 && hasPassedTheory && hasPassedPractice)
            Console.WriteLine("License confirmed!\n\n");
        else
            Console.WriteLine("License not confirmed!\n\n");

        //12. Creare un programma che utilizza un if-else per determinare il maggiore tra due numeri.
        Console.WriteLine("Insert the first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insert the second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a > b)
            Console.WriteLine(a + " is greater than " + b);
        else if (a < b)
            Console.WriteLine(b + " is greater than " + a);
        else
            Console.WriteLine(a + " and " + b + " are equal");

    }
}
