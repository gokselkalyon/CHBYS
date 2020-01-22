using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_sector
    {
        [DataMember]
        public int Kodu { get; set; }
        [DataMember]
        public string sector_name { get; set; }
        [DataMember]
        public string explanation { get; set; }
    }
}
