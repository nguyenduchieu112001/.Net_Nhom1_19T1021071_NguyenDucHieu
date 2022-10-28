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
using KiemTra.Model;
using KiemTra.Services;

namespace KiemTra
{
    public partial class frmNhom : Form
    {
        NhomViewModel n;
        public frmNhom(NhomViewModel n = null)
        {
            InitializeComponent();
            this.n = n;
            if (n != null)
            {
                txtNhom.Text = n.TenNhom;
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if(n == null)
            {
                var nhom = new Nhom { TenNhom = txtNhom.Text };
                if(NhomService.AddNhom(nhom) == KetQua.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Nhóm đã tồn tại", "Thông báo");
                    txtNhom.Focus();
                }
            }
        }
    }
}
