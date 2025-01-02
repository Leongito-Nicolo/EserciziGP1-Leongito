public class EnumsStructCast
{
    enum ErrorType 
    { 
        NotFound, 
        Unauthorized, 
        InternalError, 
        BadRequest 
    }

    struct Point3D
    {
        public double X;
        public double Y;
        public double Z;

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double DistanceTo(Point3D otherPoint)
        {
            return Math.Sqrt(Math.Pow(otherPoint.X - this.X, 2) + Math.Pow(otherPoint.Y - this.Y, 2) + Math.Pow(otherPoint.Z - this.Z, 2));
        }
    }

    enum PermissionType 
    { 
        Read, 
        Write, 
        Execute, 
        Admin 
    }

    public static void Main(String[] args)
    {
        //16.Dichiarare un enum per rappresentare i tipi di errore di un'app. 
        ErrorType error = ErrorType.InternalError;
        Console.WriteLine("Error type: " + error);

        //17. Creare una struct per rappresentare una posizione 3D e calcolarne la distanza.
        Point3D point1 = new Point3D(0, 0, 0);
        Point3D point2 = new Point3D(3, 4, 5);
        Console.WriteLine("Distance: " + point1.DistanceTo(point2));

        //18. Utilizzare un enum per definire i tipi di permesso di un'app. 
        PermissionType permission = PermissionType.Admin;
        Console.WriteLine("Permission type: " + permission);

    }
}