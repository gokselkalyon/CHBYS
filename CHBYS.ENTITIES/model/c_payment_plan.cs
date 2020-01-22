using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_payment_plan
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Nullable<int> code { get; set; }
        [DataMember]
        public string explanation { get; set; }
        [DataMember]
        public Nullable<int> discount { get; set; }
        [DataMember]
        public Nullable<bool> statu { get; set; }
        [DataMember]
        public Nullable<int> Ekleyen_Kullanici { get; set; }
    }
}
