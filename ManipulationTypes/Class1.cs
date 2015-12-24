using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulationTypes
{
    public class Animal
    {
        public int Life { get; set; }
    }
    public class Dog : Animal
    {
        public string Name { get; set; }
    }
    public class Poodle : Dog
    {
        public string Groomer { get; set; }
    }
}
