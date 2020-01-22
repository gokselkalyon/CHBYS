using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_main_unit
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Unit_name { get; set; }
        [DataMember]
        public string comment { get; set; }
    }
}
