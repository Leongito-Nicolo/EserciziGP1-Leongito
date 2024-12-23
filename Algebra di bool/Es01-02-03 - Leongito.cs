using System.Runtime.ConstrainedExecution;

public class AlgebraBool
{
    public static void Main(String[] args)
    {
        //1. Utilizzare un if-else per verificare se un numero è pari o dispari.
        Console.WriteLine("Insert a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n % 2 == 0)
            Console.WriteLine("The number " + n + " is even");
        else
            Console.WriteLine("The number " + n + " is odd");

        //2. Scrivere un programma che utilizza una serie di if-else per categorizzare un'età.
        //3. Creare un'espressione logica che combina più condizioni con &&.

        Console.WriteLine("Insert your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 0 && age <= 14)
            Console.WriteLine("You are a kid!");
        else if (age > 14 && age <= 25)
            Console.WriteLine("You are a teen!");
        else if (age > 25 && age <= 60)
            Console.WriteLine("You are an adult!");
        else if (age > 60 && age <= 122)
            Console.WriteLine("You are old!");
        else
            Console.WriteLine("That is not an existent age!");
    }
}
