using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_product_type
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Explanation { get; set; }
        [DataMember]
        public Nullable<System.DateTime> date_of_registration { get; set; }
        [DataMember]
        public Nullable<int> Ekleyen_Kullanici { get; set; }
    }
}
