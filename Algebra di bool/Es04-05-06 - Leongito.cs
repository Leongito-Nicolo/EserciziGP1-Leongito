public class AlgebraBool
{
    public static void Main(String[] args)
    {
        //4. Utilizzare un'espressione logica con || per verificare se un numero è compreso in un intervallo.
        Console.WriteLine("Insert a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < -100 || n > 100)
            Console.WriteLine("The number is not in the range {-100, 100}");
        else
            Console.WriteLine("The number is in the range {-100, 100}");

        //5. Scrivere un if-else che utilizza l'operatore ! per invertire una condizione.
        //6. Dichiarare una variabile booleana e usarla in un'istruzione if.

        bool isRainingToday = false;

        if (!isRainingToday)
            Console.WriteLine("Today it's not raining");
        else
            Console.WriteLine("Today is raining");


    }
}
