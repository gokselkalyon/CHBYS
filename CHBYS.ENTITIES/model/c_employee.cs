using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_employee
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string employee_name { get; set; }
        [DataMember]
        public string employee_lastname { get; set; }
        [DataMember]
        public string employee_TC { get; set; }
        [DataMember]
        public Nullable<decimal> salary { get; set; }
        [DataMember]
        public Nullable<int> performans { get; set; }
        [DataMember]
        public Nullable<int> employee_position { get; set; }
    }
}
