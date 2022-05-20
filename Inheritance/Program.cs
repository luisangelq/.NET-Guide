using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D point3D = new Point3D();

            point3D.SetX(60);
            point3D.SetZ(100);

            Console.WriteLine(point3D.GetX());
            Console.WriteLine(point3D.GetZ());
        }
    }
}
