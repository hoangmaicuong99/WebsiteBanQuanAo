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
    
    public partial class tbSanPham
    {
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string AnhMatTruoc { get; set; }
        public string AnhMatSau { get; set; }
        public string KichThuocSanPham { get; set; }
        public Nullable<int> LuotXem { get; set; }
        public Nullable<decimal> GiaSanPham { get; set; }
        public Nullable<bool> Sale { get; set; }
        public Nullable<int> GioiTinh { get; set; }
        public string MoTaSanPham { get; set; }
        public Nullable<int> MaDanhMuc { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<decimal> GiaKhuyenMai { get; set; }
        public string SanPhamMoiorCu { get; set; }
        public Nullable<int> LuongMua { get; set; }
        public Nullable<bool> LoaiSanPham { get; set; }
    
        public virtual tbDanhMuc tbDanhMuc { get; set; }
    }
}
