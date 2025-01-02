//3. Creare una classe che implementa un metodo per calcolare un valore. 
class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

//4. Creare una classe che eredita da un'altra. 
class Vehicle
{
    public string Brand { get; set; }

    public Vehicle(string brand)
    {
        this.Brand = brand;
    }
}

class Car : Vehicle
{
    public int Wheels { get; set; }

    public Car(string brand, int wheels) : base(brand)
    {
        this.Wheels = wheels;
    }
}

//6. Creare una classe che contiene una lista come proprietà. 
class School
{
    public List<string> Students { get; set; } = new List<string>();
}

//7. Creare una classe con proprietà indicizzate. 
class IndexedCollection
{
    private List<string> items = new List<string>();

    public string this[int index]
    {
        get { return items[index]; }
        set { items[index] = value; }
    }

    public void Add(string item)
    {
        items.Add(item);
    }
}

public class Classi
{
    public static void Main(String[] args)
    {
        Calculator c = new Calculator();
        Console.WriteLine(c.Add(1, 2));

        ////////////

        Vehicle car = new Car("Fiat", 4);

        ////////////

        School school = new School();
        school.Students.Add("Marco");
        school.Students.Add("Luca");
        school.Students.Add("Sara");

        Console.WriteLine("Students in the school:");
        foreach (var student in school.Students)
        {
            Console.WriteLine(student);
        }

        ////////////

        IndexedCollection collection = new IndexedCollection();
        collection.Add("Item1");
        collection.Add("Item2");
        collection.Add("Item3");

        Console.WriteLine("Items in the collection:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(collection[i]);
        }

        collection[1] = "NewItem2"; // modify an element by its index
        Console.WriteLine("Modified item at index 1: " + collection[1]);
    }
}
