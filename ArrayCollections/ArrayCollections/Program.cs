using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>() {
                new Car() { Make="Toyota", Model="Mark x" , VIN="KDA" },
                new Car() { Make = "Toyota", Model = "V8", VIN = "KCD" },
                new Car() { Make = "Volkswagon", Model = "Polo", VIN = "KBE" },
                new Car() { Make = "Mercedes", Model = "c200", VIN = "KCK" },
                new Car() { Make = "Toyota", Model = "Harrier", VIN = "KCA" },
                new Car() { Make = "Toyota", Model = "Avensis", VIN = "KBZ" }
            };

            var myList = carList.OrderByDescending(p => p.VIN).First();

            /*
            foreach(var car in myList)
            {
                Console.WriteLine("{0}\t{1}\t{2}", 
                    car.VIN, car.Make, car.Model);

            }
            */
            Console.WriteLine(myList.Make);

            Console.ReadKey();
        }
    }
}
