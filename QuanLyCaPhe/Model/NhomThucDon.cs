//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyCaPhe.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhomThucDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhomThucDon()
        {
            this.ThucDons = new HashSet<ThucDon>();
        }
    
        public string MaNhomThucDon { get; set; }
        public string TenNhomThucDon { get; set; }
        public string GhiChu { get; set; }
        public string MaLoaiThucDon { get; set; }
        public Nullable<bool> DaXoa { get; set; }
    
        public virtual LoaiThucDon LoaiThucDon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThucDon> ThucDons { get; set; }
    }
}
