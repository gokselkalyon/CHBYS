using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_e_waybill
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string substation { get; set; }
        [DataMember]
        public Nullable<int> repository_id { get; set; }
        [DataMember]
        public string receipt_no { get; set; }
        [DataMember]
        public string documnet_no { get; set; }
        [DataMember]
        public string waybill_no { get; set; }
        [DataMember]
        public Nullable<System.DateTime> Date { get; set; }
        [DataMember]
        public string currency { get; set; }
        [DataMember]
        public Nullable<int> suppliers { get; set; }
        [DataMember]
        public string delivery_address { get; set; }
        [DataMember]
        public Nullable<int> payment_plan { get; set; }
        [DataMember]
        public string explanation { get; set; }
        [DataMember]
        public string barcode { get; set; }
        [DataMember]
        public Nullable<int> vehicle { get; set; }
        [DataMember]
        public Nullable<int> cargo_company { get; set; }
        [DataMember]
        public Nullable<System.DateTime> cargo_shipping_date { get; set; }
        [DataMember]
        public Nullable<decimal> subtotal { get; set; }
        [DataMember]
        public Nullable<decimal> cost { get; set; }
        [DataMember]
        public Nullable<decimal> discount { get; set; }
        [DataMember]
        public Nullable<decimal> total { get; set; }
        [DataMember]
        public Nullable<decimal> KDV { get; set; }
        [DataMember]
        public Nullable<decimal> Grand_total { get; set; }
    }
}
