using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Capture
    {
        public static int getInt()
        {
            int input; 
            Console.Write("Enter integer value: ");
            bool correctInp = false;

            do
            {
                correctInp = Int32.TryParse(Console.ReadLine(), out input);
                if (!correctInp)
                    Console.WriteLine("That's not an integer, enter a valid value");                
            } while (!correctInp);

            return input;
        }
    }
}
