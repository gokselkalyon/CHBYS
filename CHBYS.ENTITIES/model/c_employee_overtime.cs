﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_employee_overtime
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public Nullable<int> employee { get; set; }
        [DataMember]
        public Nullable<System.DateTime> business_start { get; set; }
        [DataMember]
        public Nullable<System.DateTime> business_finish { get; set; }
    }
}
