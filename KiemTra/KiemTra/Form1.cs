using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KiemTra.Services;
using KiemTra.ViewModel;

namespace KiemTra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapDsNhom();
            NapDsDanhBa();
        }
        public NhomViewModel selectedNhom
        {
            get
            {
                return nhomViewModelBindingSource.Current as NhomViewModel;
            }
        }

        public DanhBaViewModel selectedDanhBa
        {
            get
            {
                return danhBaViewModelBindingSource.Current as DanhBaViewModel;
            }
        }

        void NapDsNhom()
        {
            var ls = NhomService.GetList();
            nhomViewModelBindingSource.DataSource = ls;
            gridNhom.DataSource = nhomViewModelBindingSource;
        }

        void NapDsDanhBa()
        {
            if (selectedNhom != null)
            {
                var ls = DanhBaService.GetList(selectedNhom.ID);
                danhBaViewModelBindingSource.DataSource = ls;
                gridDanhBa.DataSource = danhBaViewModelBindingSource;
            }
        }

        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            var f = new frmNhom();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapDsNhom();
            }
        }

        private void btnXoaNhom_Click(object sender, EventArgs e)
        {
            if (selectedNhom != null)
            {
                var rs = MessageBox.Show("Bạn có chắc là muốn xóa!", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    NhomService.RemoveNhom(selectedNhom);
                    NapDsNhom();
                }
            }
        }

        private void btnThemLienLac_Click(object sender, EventArgs e)
        {
            var f = new frmLienLac(selectedNhom);
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapDsDanhBa();
            }
        }

        private void btnXoaLienLac_Click(object sender, EventArgs e)
        {
            if (selectedDanhBa != null)
            {
                var rs = MessageBox.Show("Bạn có chắc chắn xoá?", "Chú ý", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    DanhBaService.RemoveDanhBa(selectedDanhBa);
                    NapDsDanhBa();
                }
            }
        }

        private void gridNhom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapDsDanhBa();
        }

        private void gridDanhBa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelTenGoi.Text = selectedDanhBa.TenGoi;
            labelEmail.Text = selectedDanhBa.Email;
            labelDiaChi.Text = selectedDanhBa.DiaChi;
            labelSoDienThoai.Text = selectedDanhBa.SoDienThoai;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (selectedNhom != null)
            {
                var ls = DanhBaService.FindDanhBa(txtTimKiem.Text,selectedNhom);
                danhBaViewModelBindingSource.DataSource = ls;
                gridDanhBa.DataSource = danhBaViewModelBindingSource;

            }
        }
    }
}
