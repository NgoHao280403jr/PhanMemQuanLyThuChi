using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    class TaiKhoan
    {
        
        private string TenTaiKhoan;
        private string MatKhau;
        private string VaiTro;
        

        public TaiKhoan( string tenTaiKhoan, string matKhau)
        {
            
            TenTaiKhoan = tenTaiKhoan;
            MatKhau = matKhau;          
        }

        public string TenTaiKhoan1 { get => TenTaiKhoan; set => TenTaiKhoan = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
        public string VaiTro1 { get => VaiTro; set => VaiTro = value; }
    }
}
