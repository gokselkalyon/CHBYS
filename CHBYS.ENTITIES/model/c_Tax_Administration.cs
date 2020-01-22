using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_Tax_Administration
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Tax_Administration_name { get; set; }
        [DataMember]
        public Nullable<int> city { get; set; }
        [DataMember]
        public string Tax_Administration_code { get; set; }
    }
}
