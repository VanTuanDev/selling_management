using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Reponsitories;

namespace BLL
{
    public class DanhMucManager
    {
        private DanhMucReponsitory Process;

        public DanhMucManager()
        {
            Process = new DanhMucReponsitory();
        }
        public DataTable HienThiDanhSachDanhMuc()
        {
            return Process.HienThiDanhSachDanhMuc();
        }
        public void ThemDanhMuc(string maDanhMuc, string tenDanhMuc)
        {
            Process.ThemDanhMuc(maDanhMuc, tenDanhMuc);
        }
        public void CapNhatDanhMuc(string maDanhMuc, string tenDanhMuc)
        {
            if (string.IsNullOrEmpty(maDanhMuc) || string.IsNullOrEmpty(tenDanhMuc))
            {
                throw new Exception("Vui lòng nhập đầy đủ thông tin.");
            }

            try
            {
                Process.CapNhatDanhMuc(maDanhMuc, tenDanhMuc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool XoaDanhMuc(string maDanhMuc)
        {
            if (string.IsNullOrEmpty(maDanhMuc) == true)
            {
                return false;
            }
            return Process.XoaDanhMuc(maDanhMuc);
        }
    }
}
