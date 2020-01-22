using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_employee_position
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string position { get; set; }
    }
}
