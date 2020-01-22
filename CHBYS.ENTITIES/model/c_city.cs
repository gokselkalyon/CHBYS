using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_city
    {
        [DataMember]
        public int plate_code { get; set; }
        [DataMember]
        public string city_name { get; set; }
    }
}
