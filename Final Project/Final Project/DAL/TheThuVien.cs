//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TheThuVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TheThuVien()
        {
            this.MuonTras = new HashSet<MuonTra>();
        }
    
        public int SoThe { get; set; }
        public string MaDocGia { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayHetHan { get; set; }
        public string GhiChu { get; set; }
    
        public virtual DocGia DocGia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MuonTra> MuonTras { get; set; }
    }
}
