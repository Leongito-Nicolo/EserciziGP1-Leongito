public class Variabili
{
    public static void Main(String[] args)
    {
        // 1. Dichiarare una variabile di tipo int e assegnarle un valore, quindi modificarlo.
        int number = 3;
        Console.WriteLine("The number is: " + number);
        Console.WriteLine("Change the number: ");
        number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The number now is: " + number + "\n\n");

        // 2. Creare una variabile di tipo string, assegnarle un valore e concatenarla con un'altra stringa.
        string first = "Hello,";
        string second = "World!";
        Console.WriteLine(first + " and " + second + " strings joined: " + string.Join(" ", first, second) + "\n\n");

        // 3. Dichiarare una variabile di tipo bool e cambiarne il valore.
        bool condition = false;
        Console.WriteLine("The condition is: " + condition);
        Console.WriteLine("Change the condition: ");
        condition = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("The condition now is: " + condition + "\n\n");

        // 4. Utilizzare una variabile di tipo double per rappresentare un numero con decimali.
        double doubleDecimalNumber = 3.5675435;

        // 5. Dichiarare una variabile char e assegnarle un carattere.
        char character = 'a';

        // 6. Usare una variabile di tipo decimal per rappresentare una quantità monetaria.
        decimal euro = 4.50m;

        // 7. Dichiarare una variabile float e assegnarle un valore, verificandone la precisione rispetto a double.
        float floatDecimalNumber = 1.22f;
        Console.WriteLine("Number in float type: " + floatDecimalNumber + "\nNumber in double type: " + (double)floatDecimalNumber + "\n\n");

        // 8. Dichiarare una variabile long per rappresentare un numero molto grande.
        long bigNumber = 9223372036854775807;
        Console.WriteLine(bigNumber + " cannot be converted to int: " + (int)bigNumber + "\n\n");

        // 9. Creare una variabile short e verificare il suo range di valori.
        short smallNumber = 13354;
        Console.WriteLine("Minimum value of short: " + short.MinValue);
        Console.WriteLine("Maximum value of short: " + short.MaxValue + "\n\n");

        // 10. Usare una variabile byte per rappresentare un numero tra 0 e 255.
        byte value = 255;
        value++;
        Console.WriteLine("Being a byte type (max 255), 255 + 1 = 0 --> " + value + "\n\n");

        // 11. Dichiarare una variabile const e provare a modificarne il valore.
        const char constantCharacter = 'c';
        constantCharacter = 'b';

        // 12. Dichiarare più variabili in una sola riga e assegnare loro valori diversi.
        int a = 12, b = 13;

        // 13. Dichiarare una variabile di tipo var e verificare come il compilatore determina il tipo.
        var variable = 10;
        Console.WriteLine("Type of variable: " + variable.GetType() + "\n\n");

        // 14. Dichiarare e usare variabili con valori predefiniti.
        int n1 = 2, n2 = 3;
        Console.WriteLine("The sum of " + n1 + " and " + n2 + " is: " + (n1 + n2) + "\n\n");

        // 15. Cambiare il tipo di una variabile usando il casting esplicito.
        float intToFloat = (float)n1;

        // 16. Dichiarare una variabile costante di tipo string.
        const string contantString = "Hello everyone";

        // 17. Utilizzare una variabile per rappresentare una data usando il tipo DateTime.
        DateTime dateTime = new DateTime(2024, 12, 21, 16, 46, 31);
        Console.WriteLine("The date is: " + dateTime.ToString() + "\n\n");

        // 18. Dichiarare una variabile e utilizzarla in un'espressione matematica.
        int num = 4;
        int pow = 2;
        Console.WriteLine("The number " + num + " to the power of " + pow + " is: " + Math.Pow(num, pow));
    }
}
