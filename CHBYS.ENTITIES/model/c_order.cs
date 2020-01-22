using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_order
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string order_name { get; set; }
        [DataMember]
        public string slip_no { get; set; }
        [DataMember]
        public string statu { get; set; }
        [DataMember]
        public string document_no { get; set; }
        [DataMember]
        public Nullable<System.DateTime> date { get; set; }
        [DataMember]
        public Nullable<int> currency { get; set; }
        [DataMember]
        public Nullable<int> supliers { get; set; }
        [DataMember]
        public Nullable<int> payment_plan { get; set; }
        [DataMember]
        public Nullable<int> vehicle { get; set; }
        [DataMember]
        public Nullable<decimal> cost { get; set; }
        [DataMember]
        public Nullable<decimal> total { get; set; }
        [DataMember]
        public string ordered_goods { get; set; }
        [DataMember]
        public string explanation { get; set; }
    }
}
