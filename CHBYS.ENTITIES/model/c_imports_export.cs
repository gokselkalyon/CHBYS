using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_imports_export
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public string code { get; set; }
        [DataMember]
        public Nullable<int> suppliers { get; set; }
        [DataMember]
        public Nullable<int> city { get; set; }
        [DataMember]
        public Nullable<int> county { get; set; }
        [DataMember]
        public Nullable<int> country { get; set; }
        [DataMember]
        public Nullable<int> payment_method { get; set; }
        [DataMember]
        public string document_no { get; set; }
        [DataMember]
        public string currency { get; set; }
        [DataMember]
        public Nullable<int> transport_type { get; set; }
        [DataMember]
        public string cargo_no { get; set; }
        [DataMember]
        public Nullable<int> intermediary_bank { get; set; }
    }
}
