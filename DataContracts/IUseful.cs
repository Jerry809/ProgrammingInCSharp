using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContracts
{
    [ContractClass(typeof(UsefulContract))]
    public interface IUseful
    {
        string Name { get; set; }
        int Id { get; set; }
        void Initialize(string name, int id);
    }
}
