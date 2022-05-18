using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public DateTime ReleaseDate { get; set; }

        public void SpeedUp(int km)
        {
            Console.WriteLine($"The Speed up is {km}");
        }

        public static void Brake()
        {

        }


    }
}
