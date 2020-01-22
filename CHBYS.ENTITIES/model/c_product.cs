using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_product
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Nullable<int> product_type { get; set; }
        [DataMember]
        public Nullable<bool> status { get; set; }
        [DataMember]
        public Nullable<int> group_code { get; set; }
        [DataMember]
        public Nullable<int> brand { get; set; }
    }
}
