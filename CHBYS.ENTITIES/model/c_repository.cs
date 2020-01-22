using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_repository
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string repository_name { get; set; }
        [DataMember]
        public Nullable<int> city { get; set; }
        [DataMember]
        public Nullable<int> county { get; set; }
        [DataMember]
        public Nullable<int> country { get; set; }
    }
}
