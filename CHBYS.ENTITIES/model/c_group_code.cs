using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_group_code
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string explanation { get; set; }
        [DataMember]
        public Nullable<int> code { get; set; }
        [DataMember]
        public Nullable<int> group_type { get; set; }
        [DataMember]
        public Nullable<bool> statu { get; set; }
    }
}
