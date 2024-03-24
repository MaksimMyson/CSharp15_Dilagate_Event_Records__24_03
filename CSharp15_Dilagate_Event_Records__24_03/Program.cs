namespace CSharp15_Dilagate_Event_Records__24_03
{
    public class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double DistanceTo(Point3D other)
        {
            double deltaX = X - other.X;
            double deltaY = Y - other.Y;
            double deltaZ = Z - other.Z;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point3D[] points = {
            new Point3D(1, 2, 3),
            new Point3D(4, 5, 6),
            new Point3D(-2, 0, 8)
        };

            double maxDistance = double.MinValue;
            Point3D pointA = null;
            Point3D pointB = null;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = points[i].DistanceTo(points[j]);
                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                        pointA = points[i];
                        pointB = points[j];
                    }
                }
            }

            Console.WriteLine($"The maximum distance between points is {maxDistance}.");
            Console.WriteLine($"Points with maximum distance: ");
            Console.WriteLine($"Point A: ({pointA.X}, {pointA.Y}, {pointA.Z})");
            Console.WriteLine($"Point B: ({pointB.X}, {pointB.Y}, {pointB.Z})");
        }
    }
}
