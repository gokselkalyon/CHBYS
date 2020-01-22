using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_barcode
    {
        [DataMember]
        public int barcode1 { get; set; }
        [DataMember]
        public Nullable<int> product { get; set; }
        [DataMember]
        public string comment { get; set; }
        [DataMember]
        public Nullable<int> Ekleyen_Kullanici { get; set; }
        [DataMember]
        public Nullable<decimal> fiyati { get; set; }
    }
}
