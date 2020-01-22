using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_country
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string country_plate_sign { get; set; }
        [DataMember]
        public string country_name { get; set; }
        [DataMember]
        public string Country_name_EN { get; set; }
        [DataMember]
        public string E_declaration { get; set; }
    }
}
