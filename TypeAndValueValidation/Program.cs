using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeAndValueValidation
{
    class Program
    {
        private static string _name;

        public static string Name
        {
            get { return _name; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("不得為null");
                }

                if (value == Name)
                {
                    throw new ArgumentException("重複的值");
                }

                _name = value; 
            }
        }

        static void Main(string[] args)
        {
            Name = null;
        }
    }
}
