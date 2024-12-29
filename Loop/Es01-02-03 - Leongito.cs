public class Loop
{
    public static void Main(String[] args)
    {
        //1.Scrivere un ciclo for che stampa numeri da 1 a 10.
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        //2.Creare un ciclo while che continua finché un valore è minore di 100.
        int value = 1;
        while (value < 100)
        {
            value *= 2;
        }
        Console.WriteLine(value);

        //3.Utilizzare un ciclo do -while per chiedere all'utente di inserire un valore valido.
        int userInput;
        do
        {
            Console.WriteLine("Enter a value between 1 and 10: ");
            userInput = Convert.ToInt32(Console.ReadLine());
        } while (userInput < 1 || userInput > 10);
    }
}
