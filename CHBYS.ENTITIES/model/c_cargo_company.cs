using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_cargo_company
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string code { get; set; }
        [DataMember]
        public Nullable<bool> statu { get; set; }
        [DataMember]
        public Nullable<bool> buyer_payment { get; set; }
        [DataMember]
        public Nullable<int> payment_plan { get; set; }
        [DataMember]
        public Nullable<int> suppliers { get; set; }
        [DataMember]
        public Nullable<int> cargo_company1 { get; set; }
    }
}
