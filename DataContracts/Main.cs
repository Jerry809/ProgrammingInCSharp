using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContracts
{
    public class Main
    { 
        private string _name;

        public string Name
        {
            get { return _name; }
            set 
            {
                Contract.Requires(!value.Equals("hi"), "can't not equal hi");
                _name = value; 
            }
        }

        public void Run() 
        {
            Name = "hi";

        }
    }
}
