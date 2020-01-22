using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_User
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string user_name { get; set; }
        [DataMember]
        public Nullable<int> employee { get; set; }
        [DataMember]
        public Nullable<int> authority { get; set; }
        [DataMember]
        public string password { get; set; }
        [DataMember]
        public Nullable<int> company { get; set; }
        [DataMember]
        public Nullable<System.DateTime> date_of_registration { get; set; }
    }
}
