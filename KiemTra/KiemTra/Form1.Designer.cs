
namespace KiemTra
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridDanhBa = new System.Windows.Forms.DataGridView();
            this.gridNhom = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnThemNhom = new System.Windows.Forms.ToolStripButton();
            this.btnXoaNhom = new System.Windows.Forms.ToolStripButton();
            this.btnThemLienLac = new System.Windows.Forms.ToolStripButton();
            this.btnXoaLienLac = new System.Windows.Forms.ToolStripButton();
            this.labelTenGoi = new System.Windows.Forms.Label();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSoDienThoai = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tenNhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tenGoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhBaViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhBa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhom)).BeginInit();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhomViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhBaViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDanhBa
            // 
            this.gridDanhBa.AllowUserToAddRows = false;
            this.gridDanhBa.AllowUserToDeleteRows = false;
            this.gridDanhBa.AutoGenerateColumns = false;
            this.gridDanhBa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridDanhBa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDanhBa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenGoiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn});
            this.gridDanhBa.DataSource = this.danhBaViewModelBindingSource;
            this.gridDanhBa.Location = new System.Drawing.Point(531, 30);
            this.gridDanhBa.Name = "gridDanhBa";
            this.gridDanhBa.ReadOnly = true;
            this.gridDanhBa.RowHeadersWidth = 51;
            this.gridDanhBa.RowTemplate.Height = 24;
            this.gridDanhBa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDanhBa.Size = new System.Drawing.Size(797, 430);
            this.gridDanhBa.TabIndex = 1;
            this.gridDanhBa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDanhBa_CellContentClick);
            // 
            // gridNhom
            // 
            this.gridNhom.AllowUserToAddRows = false;
            this.gridNhom.AllowUserToDeleteRows = false;
            this.gridNhom.AutoGenerateColumns = false;
            this.gridNhom.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNhomDataGridViewTextBoxColumn});
            this.gridNhom.DataSource = this.nhomViewModelBindingSource;
            this.gridNhom.Location = new System.Drawing.Point(12, 30);
            this.gridNhom.Name = "gridNhom";
            this.gridNhom.ReadOnly = true;
            this.gridNhom.RowHeadersWidth = 51;
            this.gridNhom.RowTemplate.Height = 24;
            this.gridNhom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridNhom.Size = new System.Drawing.Size(502, 612);
            this.gridNhom.TabIndex = 2;
            this.gridNhom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNhom_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Địa chỉ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 625);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại: ";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemNhom,
            this.btnXoaNhom,
            this.btnThemLienLac,
            this.btnXoaLienLac});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1364, 27);
            this.toolStrip.TabIndex = 6;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhom.Image")));
            this.btnThemNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.Size = new System.Drawing.Size(112, 24);
            this.btnThemNhom.Text = "Thêm nhóm";
            this.btnThemNhom.Click += new System.EventHandler(this.btnThemNhom_Click);
            // 
            // btnXoaNhom
            // 
            this.btnXoaNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNhom.Image")));
            this.btnXoaNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaNhom.Name = "btnXoaNhom";
            this.btnXoaNhom.Size = new System.Drawing.Size(101, 24);
            this.btnXoaNhom.Text = "Xóa nhóm";
            this.btnXoaNhom.Click += new System.EventHandler(this.btnXoaNhom_Click);
            // 
            // btnThemLienLac
            // 
            this.btnThemLienLac.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLienLac.Image")));
            this.btnThemLienLac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemLienLac.Name = "btnThemLienLac";
            this.btnThemLienLac.Size = new System.Drawing.Size(121, 24);
            this.btnThemLienLac.Text = "Thêm liên lạc";
            this.btnThemLienLac.Click += new System.EventHandler(this.btnThemLienLac_Click);
            // 
            // btnXoaLienLac
            // 
            this.btnXoaLienLac.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaLienLac.Image")));
            this.btnXoaLienLac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaLienLac.Name = "btnXoaLienLac";
            this.btnXoaLienLac.Size = new System.Drawing.Size(110, 24);
            this.btnXoaLienLac.Text = "Xóa liên lạc";
            this.btnXoaLienLac.Click += new System.EventHandler(this.btnXoaLienLac_Click);
            // 
            // labelTenGoi
            // 
            this.labelTenGoi.AutoSize = true;
            this.labelTenGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenGoi.Location = new System.Drawing.Point(529, 472);
            this.labelTenGoi.Name = "labelTenGoi";
            this.labelTenGoi.Size = new System.Drawing.Size(0, 26);
            this.labelTenGoi.TabIndex = 7;
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Location = new System.Drawing.Point(638, 535);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(0, 17);
            this.labelDiaChi.TabIndex = 8;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(638, 580);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(0, 17);
            this.labelEmail.TabIndex = 8;
            // 
            // labelSoDienThoai
            // 
            this.labelSoDienThoai.AutoSize = true;
            this.labelSoDienThoai.Location = new System.Drawing.Point(638, 625);
            this.labelSoDienThoai.Name = "labelSoDienThoai";
            this.labelSoDienThoai.Size = new System.Drawing.Size(0, 17);
            this.labelSoDienThoai.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(608, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "___________________________________________________________________________";
            // 
            // tenNhomDataGridViewTextBoxColumn
            // 
            this.tenNhomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNhomDataGridViewTextBoxColumn.DataPropertyName = "TenNhom";
            this.tenNhomDataGridViewTextBoxColumn.HeaderText = "Tên nhóm";
            this.tenNhomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNhomDataGridViewTextBoxColumn.Name = "tenNhomDataGridViewTextBoxColumn";
            this.tenNhomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nhomViewModelBindingSource
            // 
            this.nhomViewModelBindingSource.DataSource = typeof(KiemTra.ViewModel.NhomViewModel);
            // 
            // tenGoiDataGridViewTextBoxColumn
            // 
            this.tenGoiDataGridViewTextBoxColumn.DataPropertyName = "TenGoi";
            this.tenGoiDataGridViewTextBoxColumn.HeaderText = "Tên gọi";
            this.tenGoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenGoiDataGridViewTextBoxColumn.Name = "tenGoiDataGridViewTextBoxColumn";
            this.tenGoiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenGoiDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.soDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            this.soDienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // danhBaViewModelBindingSource
            // 
            this.danhBaViewModelBindingSource.DataSource = typeof(KiemTra.ViewModel.DanhBaViewModel);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(1165, 8);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(163, 22);
            this.txtTimKiem.TabIndex = 10;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1051, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nhập từ cần tìm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 651);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelSoDienThoai);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelDiaChi);
            this.Controls.Add(this.labelTenGoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridNhom);
            this.Controls.Add(this.gridDanhBa);
            this.Controls.Add(this.toolStrip);
            this.Name = "Form1";
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ DANH BẠ - [Nguyễn Đức Hiếu]";
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhBa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhom)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhomViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhBaViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridDanhBa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource danhBaViewModelBindingSource;
        private System.Windows.Forms.DataGridView gridNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nhomViewModelBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnThemNhom;
        private System.Windows.Forms.ToolStripButton btnXoaNhom;
        private System.Windows.Forms.ToolStripButton btnThemLienLac;
        private System.Windows.Forms.ToolStripButton btnXoaLienLac;
        private System.Windows.Forms.Label labelTenGoi;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSoDienThoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label4;
    }
}

