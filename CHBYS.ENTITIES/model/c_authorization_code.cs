using System;
using System.Runtime.Serialization;

namespace CHBYS.ENTITIES.model
{
    [DataContract]
    public class c_authorization_code
    {
        [DataMember]
        public int SIRA_NO { get; set; }
        [DataMember]
        public Nullable<int> YETKI_TIPI { get; set; }
        [DataMember]
        public Nullable<int> YETKI_KODU { get; set; }
        [DataMember]
        public string ACIKLAMA { get; set; }
    }
}