using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollections
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }

        public Car()
        {
            Make = "";
            Model = "";
            VIN = "";
        }
        public Car(string Make, string Model, string VIN)
        {
            this.Model = Model;
            this.Make = this.Make;
            this.VIN = VIN;
        }
    }
}
