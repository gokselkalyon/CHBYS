using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_cargo_company_name
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string company_name { get; set; }
        [DataMember]
        public string explanation { get; set; }
    }
}
