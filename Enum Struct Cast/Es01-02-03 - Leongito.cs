public class EnumsStructCast
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum TaskPriority
    {
        Low,
        Medium,
        High,
        Critical
    }

    enum Options
    {
        Option1,
        Option2,
        Option3
    }

    public static void Main(String[] args)
    {
        //1.Creare un enum per rappresentare i giorni della settimana e iterare sui valori.
        foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
        {
            Console.WriteLine(day);
        }

        //2. Dichiarare un enum per rappresentare i livelli di priorità di un task.
        TaskPriority priority = TaskPriority.High;
        Console.WriteLine("Task priority: " + priority);

        //3. Usare un enum per selezionare un'opzione in uno switch-case. 
        Options selectedOption = Options.Option2;
        switch (selectedOption)
        {
            case Options.Option1:
                Console.WriteLine("You selected Option 1");
                break;
            case Options.Option2:
                Console.WriteLine("You selected Option 2");
                break;
            case Options.Option3:
                Console.WriteLine("You selected Option 3");
                break;
        }

    }
}