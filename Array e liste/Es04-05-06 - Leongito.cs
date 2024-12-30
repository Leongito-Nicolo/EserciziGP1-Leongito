public class ArrayListe
{
    class CustomObject
    {
        public string Name;
        public int Value;

        public CustomObject(string name, int value)
        {
            this.Name = name;
            this.Value = value;
        }
    }

    public static void Main(String[] args)
    {
        //4.Utilizzare un array per calcolare la media dei valori.
        int[] numbers = { 10, 20, 30, 40, 50 };
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        double average = sum / numbers.Length;
        Console.WriteLine("Average: " + average);

        //5.Dichiarare una lista di oggetti personalizzati. (classi, enum, struct, ecc)
        List<CustomObject> objects = new List<CustomObject>
        {
            new CustomObject("Object1", 100),
            new CustomObject("Object2", 200)
        };

        foreach (CustomObject obj in objects)
        {
            Console.WriteLine("Name: " + obj.Name + ", Value: " + obj.Value);
        }

        //6. Creare un array di booleani per rappresentare lo stato di vari interruttori.
        bool[] switches = { true, false, true, false, true };
        foreach (bool state in switches)
        {
            Console.WriteLine("Switch state: " + state);
        }

    }
}
