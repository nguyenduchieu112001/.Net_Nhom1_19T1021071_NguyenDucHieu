using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KiemTra.Model;
using KiemTra.ViewModel;

namespace KiemTra.Services
{
    public class DanhBaService
    {
        public static List<DanhBaViewModel> GetList()
        {
            var db = new AppDBContext();
            var rs = db.DanhBas.Select(e => new DanhBaViewModel
            {
                ID = e.ID,
                TenGoi = e.TenGoi,
                Email = e.Email,
                SoDienThoai = e.SoDienThoai,
                IDNhom = e.IDNhom,
                DiaChi = e.DiaChi
            }).ToList();
            return rs;
        }

        public static List<DanhBaViewModel> GetList(int idNhom)
        {
            var db = new AppDBContext();
            var rs = db.DanhBas.Where(e => e.IDNhom == idNhom).Select(e => new DanhBaViewModel
            {
                ID = e.ID,
                TenGoi = e.TenGoi,
                Email = e.Email,
                SoDienThoai = e.SoDienThoai,
                IDNhom = e.IDNhom,
                DiaChi = e.DiaChi
            }).ToList();
            return rs;
        }

        public static KetQua AddDanhBa(DanhBa d)
        {
            var db = new AppDBContext();
            var count = db.DanhBas.Where(e => e.TenGoi == d.TenGoi).Count();
            db.DanhBas.Add(d);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }

        public static KetQua RemoveDanhBa(DanhBaViewModel d)
        {
            var db = new AppDBContext();
            var rs = db.DanhBas.Where(e => e.ID == d.ID).FirstOrDefault();
            db.DanhBas.Remove(rs);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }

        public static List<DanhBaViewModel> FindDanhBa(string giaTriTimKiem, NhomViewModel n)
        {
            var db = new AppDBContext();
            var rs = db.DanhBas.Where(e=>e.IDNhom==n.ID). 
                                Where(e =>e.TenGoi.Contains(giaTriTimKiem)
                                        || e.DiaChi.Contains(giaTriTimKiem)
                                        || e.Email.Contains(giaTriTimKiem)
                                        || e.SoDienThoai.Contains(giaTriTimKiem))
                                .Select(e => new DanhBaViewModel
                                {
                                    ID = e.ID,
                                    TenGoi = e.TenGoi,
                                    Email = e.Email,
                                    SoDienThoai = e.SoDienThoai,
                                    IDNhom = e.IDNhom,
                                    DiaChi = e.DiaChi
                                }).ToList();
            return rs;
        }
    }
}
