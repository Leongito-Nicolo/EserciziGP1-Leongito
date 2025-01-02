public class AlgebraBool
{
    public static void Main(String[] args)
    {
        //16. Utilizzare un if-else per verificare se un array contiene un elemento specifico.
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };

        if (array.Contains(6))
            Console.WriteLine("The number 6 is in the array");
        else
            Console.WriteLine("The number 6 is not in the array");

        if (array.Contains(12))
            Console.WriteLine("The number 12 is in the array");
        else
            Console.WriteLine("The number 12 is not in the array");

        //17. Creare una funzione che utilizza if-else per determinare se un numero è positivo, negativo o zero.
        int n = 3;

        isPositive(n);

        //18. Creare un programma che utilizza un switch per determinare il giorno della settimana.
        string day = "monday";

        switch (day)
        {
            case "monday":
                Console.WriteLine("Today is monday");
                break;
            case "tuesday":
                Console.WriteLine("Today is tuesday");
                break;
            case "wednesday":
                Console.WriteLine("Today is wednesday");
                break;
            case "thursday":
                Console.WriteLine("Today is thursday");
                break;
            case "friday":
                Console.WriteLine("Today is friday");
                break;
            case "saturday":
                Console.WriteLine("Today is saturday");
                break;
            case "sunday":
                Console.WriteLine("Today is sunday");
                break;

        }

    }

    public static void isPositive(int n)
    {
        if (n > 0)
            Console.WriteLine("The number is positive");
        else if (n < 0)
            Console.WriteLine("The number is negative");
        else if (n == 0)
            Console.WriteLine("The number is zero");
    }
}
