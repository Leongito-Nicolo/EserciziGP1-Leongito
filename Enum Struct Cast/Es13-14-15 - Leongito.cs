public class EnumsStructCast
{
    enum Months 
    { 
        January, 
        February, 
        March, 
        April, 
        May, 
        June, 
        July, 
        August, 
        September, 
        October, 
        November, 
        December 
    }

    struct Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    public static void Main(String[] args)
    {
        //13.Creare un enum per rappresentare i mesi dell'anno. 
        foreach (Months month in Enum.GetValues(typeof(Months)))
        {
            Console.WriteLine(month);
        }

        //14. Dichiarare una struct per rappresentare una persona con nome e età.
        Person person = new Person("John", 30);
        Console.WriteLine("Name: " + person.Name + ", Age: " + person.Age);

        //15. Scrivere un programma che utilizza il casting esplicito tra tipi numerici.
        double value = 10.5;
        int intValue = (int)value;
        Console.WriteLine("Double: " + value + "\nInt: " + intValue);

    }
}