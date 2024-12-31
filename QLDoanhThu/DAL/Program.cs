using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            //--------------CONSTRUCTOR-----------------------
            //public TAIKHOAN()
            //{
            //}

            //public TAIKHOAN(string tenTaiKhoan, string matKhau)
            //{
            //    this.TaiKhoan1 = tenTaiKhoan;
            //    this.MatKhau = matKhau;
            //}

            //public TAIKHOAN(string tenTaiKhoan, string matKhau, string loaiTaiKhoan)
            //{
            //    this.TaiKhoan1 = tenTaiKhoan;
            //    this.MatKhau = matKhau;
            //    this.LoaiTK = loaiTaiKhoan;
            //}

            //------------------TenHienThi----------------------
            //public string tenHienThi;
            //public string TenHienThi
            //{
            //    get
            //    {
            //        if (LoaiTK.Equals("admin")) { TenHienThi = "Quản Lý"; }
            //        else { TenHienThi = "Nhân Viên"; }
            //        return tenHienThi;
            //    }
            //    set => tenHienThi = value;
            //}
        }
    }
}
