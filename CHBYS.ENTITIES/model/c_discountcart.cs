using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_discountcart
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string type_name { get; set; }
        [DataMember]
        public string code { get; set; }
        [DataMember]
        public Nullable<bool> statu { get; set; }
        [DataMember]
        public string figure { get; set; }
        [DataMember]
        public Nullable<int> currency { get; set; }
        [DataMember]
        public Nullable<int> value { get; set; }
        [DataMember]
        public Nullable<int> Formula { get; set; }
        [DataMember]
        public Nullable<int> Ekleyen_Kullanici { get; set; }
    }
}
