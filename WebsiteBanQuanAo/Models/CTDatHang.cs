//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebsiteBanQuanAo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTDatHang
    {
        public int MaCTDatHang { get; set; }
        public Nullable<int> MaSanPham { get; set; }
        public Nullable<int> MaTTTT { get; set; }
    
        public virtual tbSanPham tbSanPham { get; set; }
        public virtual ThongTinThanhToan ThongTinThanhToan { get; set; }
    }
}
