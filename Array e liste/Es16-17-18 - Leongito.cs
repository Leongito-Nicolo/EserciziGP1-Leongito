public class ArrayListe
{
    public static void Main(String[] args)
    {
        //16.Dichiarare un array di char per rappresentare una parola.
        char[] word = { 'H', 'e', 'l', 'l', 'o' };
        Console.Write(string.Join("", word));
        Console.WriteLine();

        //17.Creare una lista che accetta solo valori di tipo float.
        List<float> floats = new List<float> { 1.1f, 2.2f, 3.3f };
        foreach (float value in floats)
        {
            Console.WriteLine("Float value: " + value);
        }

        //18.Utilizzare un array per memorizzare i giorni della settimana.
        string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        foreach (string day in daysOfWeek)
        {
            Console.WriteLine("Day: " + day);
        }

    }
}
