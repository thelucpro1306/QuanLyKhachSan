
namespace QuanLyKhachSan.PresentationTier
{
    partial class FormLichLamViec
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLichLam = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCaLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxNhanVien = new System.Windows.Forms.ComboBox();
            this.dtpNgayLam = new System.Windows.Forms.DateTimePicker();
            this.cbxCaLam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỊCH LÀM VIỆC";
            // 
            // dgvLichLam
            // 
            this.dgvLichLam.AllowUserToAddRows = false;
            this.dgvLichLam.AllowUserToDeleteRows = false;
            this.dgvLichLam.AllowUserToOrderColumns = true;
            this.dgvLichLam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichLam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colTenNhanVien,
            this.colCaLam,
            this.colNgayLam,
            this.colID});
            this.dgvLichLam.Location = new System.Drawing.Point(34, 259);
            this.dgvLichLam.Name = "dgvLichLam";
            this.dgvLichLam.RowHeadersWidth = 51;
            this.dgvLichLam.RowTemplate.Height = 24;
            this.dgvLichLam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichLam.Size = new System.Drawing.Size(928, 516);
            this.dgvLichLam.TabIndex = 1;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.HeaderText = "Tên nhân viên";
            this.colTenNhanVien.MinimumWidth = 6;
            this.colTenNhanVien.Name = "colTenNhanVien";
            // 
            // colCaLam
            // 
            this.colCaLam.HeaderText = "Ca Làm";
            this.colCaLam.MinimumWidth = 6;
            this.colCaLam.Name = "colCaLam";
            // 
            // colNgayLam
            // 
            this.colNgayLam.HeaderText = "Ngày Làm";
            this.colNgayLam.MinimumWidth = 6;
            this.colNgayLam.Name = "colNgayLam";
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            // 
            // cbxNhanVien
            // 
            this.cbxNhanVien.FormattingEnabled = true;
            this.cbxNhanVien.Location = new System.Drawing.Point(335, 206);
            this.cbxNhanVien.Name = "cbxNhanVien";
            this.cbxNhanVien.Size = new System.Drawing.Size(223, 24);
            this.cbxNhanVien.TabIndex = 2;
            // 
            // dtpNgayLam
            // 
            this.dtpNgayLam.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLam.Location = new System.Drawing.Point(34, 204);
            this.dtpNgayLam.Name = "dtpNgayLam";
            this.dtpNgayLam.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayLam.TabIndex = 3;
            // 
            // cbxCaLam
            // 
            this.cbxCaLam.FormattingEnabled = true;
            this.cbxCaLam.Location = new System.Drawing.Point(640, 204);
            this.cbxCaLam.Name = "cbxCaLam";
            this.cbxCaLam.Size = new System.Drawing.Size(223, 24);
            this.cbxCaLam.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày làm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(634, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ca làm";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1037, 259);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(182, 49);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1037, 335);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(182, 49);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1037, 411);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(182, 49);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1037, 551);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(182, 49);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.xanh1;
            this.ClientSize = new System.Drawing.Size(1279, 802);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgayLam);
            this.Controls.Add(this.cbxCaLam);
            this.Controls.Add(this.cbxNhanVien);
            this.Controls.Add(this.dgvLichLam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLichLamViec";
            this.Text = "FormLichLamViec";
            this.Load += new System.EventHandler(this.FormLichLamViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLichLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.ComboBox cbxNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgayLam;
        private System.Windows.Forms.ComboBox cbxCaLam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
    }
}