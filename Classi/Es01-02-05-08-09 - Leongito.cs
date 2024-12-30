//1.Creare una classe Persona con proprietà per nome e età e una classe Lavoro con parametri il nome e la descrizione. 
//2.Dichiarare una classe con un costruttore parametrizzato. 
//5.Aggiungere diversi metodi public all 'interno della classe 'Persona' 
//8.Dentro a persona dichiarare un parametro di tipo Lavoro 
//9.Fare un programma che data una lista di Persone e una lista di Lavori venga assegnato a ogni persona un Lavoro casuale

class Persona
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Lavoro Job { get; set; }

    public Persona(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public void Greet()
    {
        Console.WriteLine("Hello, my name is " + this.Name);
    }

    public void HaveBirthday()
    {
        Age++;
        Console.WriteLine("Happy birthday! I am now " + this.Age + " years old.");
    }
}

class Lavoro
{
    public string JobName { get; set; }
    public string Description { get; set; }
}

public class Classi
{
    public static void Main(String[] args)
    {
        List<Persona> people = new List<Persona>
        {
            new Persona( "Marco", 30 ),
            new Persona("Luca", 25),
            new Persona("Alice", 35)
        };

        List<Lavoro> jobs = new List<Lavoro>
        {
            new Lavoro { JobName = "Policeman", Description = "Arrest criminals" },
            new Lavoro { JobName = "Doctor", Description = "Saves lives" },
            new Lavoro { JobName = "Teacher", Description = "Educates students" }
        };

        Random random = new Random();
        foreach (var person in people)
        {
            person.Job = jobs[random.Next(jobs.Count)];
            Console.WriteLine(person.Name + " is a " + person.Job.JobName);
        }
    }
}
