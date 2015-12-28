using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToGetTypedata
{
    public class Animal
    {
        public Animal()
        {
            this.NumberOfLegs = 4;
        }

        public Animal(int number)
        {
            this.NumberOfLegs = number;
        }

        public int NumberOfLegs { get; set; }

        public string SayWoo() 
        {
            return "Woo";
        }
    }
}
