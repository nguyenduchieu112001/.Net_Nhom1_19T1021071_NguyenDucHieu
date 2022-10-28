using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KiemTra.ViewModel;
using KiemTra.Services;
using KiemTra.Model;
using System.Text.RegularExpressions;

namespace KiemTra
{
    public partial class frmLienLac : Form
    {
        NhomViewModel nhom;
        public frmLienLac(NhomViewModel n = null)
        {
            InitializeComponent();
            this.nhom = n;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (nhom != null)
            {
                var danhba = new DanhBa
                {
                    IDNhom = nhom.ID,
                    TenGoi = txtTenGoi.Text,
                    Email = txtEmail.Text,
                    SoDienThoai = txtSDT.Text,
                    DiaChi = txtDiaChi.Text
                };
                if (DanhBaService.AddDanhBa(danhba) == KetQua.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Tên gọi trùng", "Thông báo");
                    txtTenGoi.Focus();
                }
            }
        }


    }
}
