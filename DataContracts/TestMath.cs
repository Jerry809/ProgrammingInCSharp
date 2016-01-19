using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContracts
{
    public class TestMath : IMath
    {
        public int SquareMath(int value)
        {
            return value * 2;
        }
    }
}
