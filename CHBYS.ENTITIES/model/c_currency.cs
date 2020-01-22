using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_currency
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string unit { get; set; }
    }
}
