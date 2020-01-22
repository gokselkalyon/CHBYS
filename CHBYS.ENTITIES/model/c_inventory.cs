using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_inventory
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Nullable<int> product_name_1 { get; set; }
        [DataMember]
        public Nullable<bool> status { get; set; }
        [DataMember]
        public Nullable<int> authorization_code { get; set; }
        [DataMember]
        public Nullable<int> payment_plan { get; set; }
        [DataMember]
        public Nullable<int> shelf_life { get; set; }
        [DataMember]
        public Nullable<int> warranty_period { get; set; }
        [DataMember]
        public Nullable<int> main_unit { get; set; }
        [DataMember]
        public Nullable<double> quantity { get; set; }
        [DataMember]
        public string note { get; set; }
        [DataMember]
        public Nullable<int> suppliers { get; set; }
        [DataMember]
        public Nullable<int> Ekleyen_Kullanici { get; set; }
    }
}
