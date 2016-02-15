using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [DataContract]
    public partial class Product
    {
        [DataMember(IsRequired=true, Name="ProductId")]
        public int ProductId { get; set; }
        
        public string ProductName { get; set; }
        [DataMember]
        public Nullable<decimal> Price { get; set; }
        [DataMember]
        public Nullable<bool> Active { get; set; }
        [DataMember]
        public Nullable<decimal> Stock { get; set; }
    }
}
