using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContracts
{
    [ContractClassFor(typeof(IMath))]
    public abstract class MathContracts : IMath
    {
        public int SquareMath(int value)
        {
            // 確保傳入數字大於0
            Contract.Requires(value > 0);
            
            // 確保輸出結果為輸入的平方
            Contract.Ensures(Contract.Result<int>() == value * value);

            throw new NotImplementedException();
        }
    }
}
