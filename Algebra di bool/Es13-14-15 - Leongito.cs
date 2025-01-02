public class AlgebraBool
{
    public static void Main(String[] args)
    {
        //13. Utilizzare un'istruzione if per verificare se una stringa è vuota o nulla.
        string str = "";

        if (string.IsNullOrEmpty(str))
            Console.WriteLine("the string is empty");
        else
            Console.WriteLine("The string is not empty");

        //14. Creare un programma che utilizza if-else per verificare se un anno è bisestile.
        Console.WriteLine("Insert a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if(year % 4 == 0)
        {
            if(year % 100 == 0)
            {
                if (year % 400 == 0)
                    Console.WriteLine(year + " is a leap year");
                else
                    Console.WriteLine(year + " is not a leap year");
            }
            else
            {
                Console.WriteLine(year + " is a leap year");
            }
        }
        else
        {
            Console.WriteLine(year + " is not a leap year");
        }

        //15. Scrivere un'espressione logica che verifica se una stringa contiene una sottostringa specifica.
        string mainString = "Hi, how are you?";
        string subString = "how are";

        if(mainString.Contains(subString))
            Console.WriteLine("The first line contains the second");
        else
            Console.WriteLine("The first line does not contain the second");

    }
}
