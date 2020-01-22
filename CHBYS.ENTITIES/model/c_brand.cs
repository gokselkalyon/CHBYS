using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_brand
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Nullable<int> Code { get; set; }
        [DataMember]
        public string brand_name { get; set; }
    }
}
