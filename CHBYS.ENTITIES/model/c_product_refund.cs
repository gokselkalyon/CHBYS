using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_product_refund
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string reason_for_return { get; set; }
        [DataMember]
        public Nullable<int> return_quantity { get; set; }
        [DataMember]
        public Nullable<int> vehicle { get; set; }
        [DataMember]
        public Nullable<int> returned_product { get; set; }
        [DataMember]
        public Nullable<System.DateTime> returned_date { get; set; }
    }
}
