using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_company
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Nullable<int> company_type { get; set; }
        [DataMember]
        public string company_name { get; set; }
        [DataMember]
        public Nullable<int> city { get; set; }
        [DataMember]
        public Nullable<int> Tax_Administration { get; set; }
        [DataMember]
        public Nullable<int> county { get; set; }
        [DataMember]
        public Nullable<int> country { get; set; }
        [DataMember]
        public string Tax_number { get; set; }
    }
}
