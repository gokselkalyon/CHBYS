using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_sold_product
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string document_no { get; set; }
        [DataMember]
        public Nullable<int> sold_product1 { get; set; }
        [DataMember]
        public Nullable<System.DateTime> date { get; set; }
        [DataMember]
        public Nullable<int> currency { get; set; }
        [DataMember]
        public Nullable<int> vehicle { get; set; }
        [DataMember]
        public Nullable<int> payment_plan { get; set; }
        [DataMember]
        public Nullable<decimal> cost { get; set; }
        [DataMember]
        public Nullable<decimal> total { get; set; }
    }
}
