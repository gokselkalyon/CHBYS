//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CHBYS.ENTITIES
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_inventory
    {
        public int SIRA_NO { get; set; }
        public int BARKOD { get; set; }
        public Nullable<bool> DURUM { get; set; }
        public Nullable<int> YETKI_KODU { get; set; }
        public Nullable<int> ODEME_PLANI_KODU { get; set; }
        public Nullable<int> RAF_OMRU { get; set; }
        public Nullable<int> GARANTI_SURESI { get; set; }
        public string BIRIM { get; set; }
        public Nullable<double> MIKTAR { get; set; }
        public string ACIKLAMA { get; set; }
        public string CARI { get; set; }
        public string EKLEYEN_KULLANICI { get; set; }
        public Nullable<System.DateTime> EKLEME_TARIHI { get; set; }
    }
}
