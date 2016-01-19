using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContracts
{
    [ContractClassFor(typeof(IUseful))]
    public abstract class UsefulContract : IUseful
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public void Initialize(string name, int id)
        {
            Contract.Requires(!string.IsNullOrEmpty(name));
            Contract.Requires(id > 0);
            Contract.Ensures(Name == name);
            Contract.Ensures(Id == id);
        }
    }
}
