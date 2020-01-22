using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_supplier
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Nullable<int> suppliers_type { get; set; }
        [DataMember]
        public string suppliers_Code { get; set; }
        [DataMember]
        public string appellation { get; set; }
        [DataMember]
        public Nullable<bool> statu { get; set; }
        [DataMember]
        public string explanation { get; set; }
        [DataMember]
        public Nullable<int> Tax_Administration { get; set; }
        [DataMember]
        public string Tax_Administration_number { get; set; }
        [DataMember]
        public string E_mail { get; set; }
        [DataMember]
        public Nullable<int> E_invoice_type { get; set; }
        [DataMember]
        public string adress { get; set; }
        [DataMember]
        public string post_code { get; set; }
        [DataMember]
        public Nullable<int> city { get; set; }
        [DataMember]
        public Nullable<int> county { get; set; }
        [DataMember]
        public Nullable<int> country { get; set; }
        [DataMember]
        public string mobilephone { get; set; }
        [DataMember]
        public string telephone { get; set; }
        [DataMember]
        public string telephone_2 { get; set; }
        [DataMember]
        public string fax { get; set; }
        [DataMember]
        public Nullable<int> sector { get; set; }
        [DataMember]
        public Nullable<int> payment_plan { get; set; }
        [DataMember]
        public Nullable<int> Ekleyen_Kullanici { get; set; }
    }
}
