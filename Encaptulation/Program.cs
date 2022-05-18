using System;

namespace Encaptulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EncaptulatedPoint point = new EncaptulatedPoint();

            try
            {
                point.SetX(80);
                point.SetY(60);

                Console.WriteLine(point.GetX());
                Console.WriteLine(point.GetY());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }

        }
    }
}
