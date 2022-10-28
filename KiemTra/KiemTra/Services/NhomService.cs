using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KiemTra.Model;
using KiemTra.ViewModel;

namespace KiemTra.Services
{
    public class NhomService
    {
        public static List<NhomViewModel> GetList()
        {
            var db = new AppDBContext();
            var rs = db.Nhoms.Select(e => new NhomViewModel
            {
                ID = e.ID,
                TenNhom = e.TenNhom
            }).ToList();
            return rs;
        }

        public static List<NhomViewModel> GetByNhom(int id)
        {
            var list = GetList();
            var rs = list.Where(e => e.ID == id).ToList();
            return rs;
        }

        public static KetQua AddNhom(Nhom n)
        {
            var db = new AppDBContext();
            var rs = db.Nhoms.Where(e => e.ID == n.ID).Count();
            db.Nhoms.Add(n);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }

        public static KetQua RemoveNhom(NhomViewModel n)
        {
            var db = new AppDBContext();
            var rs = db.Nhoms.Where(e => e.ID == n.ID).FirstOrDefault();
            db.Nhoms.Remove(rs);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
    }
}
