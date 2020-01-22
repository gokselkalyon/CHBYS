using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_payment_method
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Method { get; set; }
        [DataMember]
        public string explanation { get; set; }
    }
}
