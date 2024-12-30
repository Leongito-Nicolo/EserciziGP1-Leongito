public class EnumsStructCast
{
    struct IntArrayHolder
    {
        public int[] Numbers;

        public IntArrayHolder(int[] numbers)
        {
            this.Numbers = numbers;
        }

        public override string ToString()
        {
            return string.Join(", ", this.Numbers);
        }
    }

    enum FileType 
    { 
        PDF, 
        DOCX, 
        TXT, 
        JPEG 
    }

    struct Vector
    {
        public double X;
        public double Y;
        public double Z;

        public Vector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double Product(Vector otherVector)
        {
            return this.X * otherVector.X + this.Y * otherVector.Y + this.Z * otherVector.Z;
        }
    }

    public static void Main(String[] args)
    {
        //22.Dichiarare una struct che contiene un array come proprietà.
        IntArrayHolder holder = new IntArrayHolder(new int[] { 1, 2, 3, 4, 5 });
        Console.WriteLine("Array contents: " + holder.ToString());

        //23. Scrivere un programma che converte un valore double in float usando il casting esplicito.
        double doubleValue = 123.4565464565234423423434235;
        float floatValue = (float)doubleValue;
        Console.WriteLine("Double: " + doubleValue + ", Float: " + floatValue);

        //24. Utilizzare un enum per rappresentare i tipi di file supportati da un'app. 
        FileType fileType = FileType.PDF;
        Console.WriteLine("File type: " + fileType);

        //25. Creare una struct per rappresentare un vettore e calcolare il prodotto scalare.
        Vector vector1 = new Vector(1, 2, 3);
        Vector vector2 = new Vector(4, 5, 6);
        Console.WriteLine("Product: " + vector1.Product(vector2));

    }
}