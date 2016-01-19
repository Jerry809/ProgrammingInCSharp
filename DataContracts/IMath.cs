using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContracts
{
    [ContractClass(typeof(MathContracts))]
    public interface IMath
    {
        int SquareMath(int value);        
    }
}
