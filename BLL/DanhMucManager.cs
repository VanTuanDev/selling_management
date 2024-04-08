using System.Data;
using DAL.Entity;
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
        public void ThemDanhMuc(DanhMucEntity danhMuc)
        {
            Process.ThemDanhMuc(danhMuc);
        }
        public void CapNhatDanhMuc(DanhMucEntity danhMuc)
        {
            Process.CapNhatDanhMuc(danhMuc);
        }
        public bool XoaDanhMuc(DanhMucEntity danhMuc)
        {
            return Process.XoaDanhMuc(danhMuc);
        }
    }
}
