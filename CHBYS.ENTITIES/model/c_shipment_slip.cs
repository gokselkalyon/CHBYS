using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_shipment_slip
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public string voucher_no { get; set; }
        [DataMember]
        public Nullable<System.DateTime> date { get; set; }
        [DataMember]
        public Nullable<int> payment_plan { get; set; }
        [DataMember]
        public Nullable<int> cargo_company { get; set; }
        [DataMember]
        public string delivery { get; set; }
        [DataMember]
        public string explanation { get; set; }
        [DataMember]
        public string pakaging { get; set; }
        [DataMember]
        public Nullable<int> buyer_company { get; set; }
        [DataMember]
        public Nullable<int> sending_company { get; set; }
        [DataMember]
        public Nullable<bool> statu { get; set; }
        [DataMember]
        public Nullable<System.DateTime> cargo_delivery_date { get; set; }
        [DataMember]
        public string cargo_invoice_no { get; set; }
        [DataMember]
        public Nullable<decimal> total { get; set; }
    }
}
