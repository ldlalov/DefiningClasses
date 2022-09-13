using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Cargo
    {
        public Cargo(double weight, string type)
        {
            Weight = weight;
            Type = type;
        }

        public string Type { get; set; }
        public double Weight { get; set; }
    }
}
