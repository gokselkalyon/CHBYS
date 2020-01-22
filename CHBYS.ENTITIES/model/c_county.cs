using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_county
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Nullable<int> plate_code { get; set; }
        [DataMember]
        public string county_name { get; set; }
    }
}
