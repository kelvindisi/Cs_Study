using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAge
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dob = new DateTime();
            TimeSpan time = new TimeSpan();

            Console.WriteLine("ENTER DOB MM/DD/YYYY");
            dob = Convert.ToDateTime(Console.ReadLine());

            time = DateTime.Now.Subtract(dob);

            Console.WriteLine("You are {0} days old", time.TotalDays);
            Console.ReadKey();
        }
    }
}
