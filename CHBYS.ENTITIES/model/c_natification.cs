using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_natification
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string explanation { get; set; }
        [DataMember]
        public Nullable<System.DateTime> zaman { get; set; }
        [DataMember]
        public Nullable<int> ekleyenkullanici { get; set; }
    }
}
