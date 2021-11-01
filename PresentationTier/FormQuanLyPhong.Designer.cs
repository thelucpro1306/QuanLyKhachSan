
namespace QuanLyKhachSan.PresentationTier
{
    partial class FormQuanLyPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvQuanLyPhong = new System.Windows.Forms.DataGridView();
            this.colPhongID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCapNhatVatTu = new QuanLyKhachSan.CustomButton.CustomButton();
            this.btnThoat = new QuanLyKhachSan.CustomButton.CustomButton();
            this.btnCapNhatDichVu = new QuanLyKhachSan.CustomButton.CustomButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 91);
            this.label1.TabIndex = 5;
            this.label1.Text = "QUẢN LÝ PHÒNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvQuanLyPhong);
            this.panel1.Location = new System.Drawing.Point(582, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 652);
            this.panel1.TabIndex = 6;
            // 
            // dgvQuanLyPhong
            // 
            this.dgvQuanLyPhong.AllowUserToAddRows = false;
            this.dgvQuanLyPhong.AllowUserToDeleteRows = false;
            this.dgvQuanLyPhong.AllowUserToOrderColumns = true;
            this.dgvQuanLyPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyPhong.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvQuanLyPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuanLyPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuanLyPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPhongID,
            this.colTenLoaiPhong,
            this.colGiaPhong});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuanLyPhong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuanLyPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuanLyPhong.Location = new System.Drawing.Point(0, 0);
            this.dgvQuanLyPhong.Name = "dgvQuanLyPhong";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuanLyPhong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQuanLyPhong.RowHeadersWidth = 51;
            this.dgvQuanLyPhong.RowTemplate.Height = 24;
            this.dgvQuanLyPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuanLyPhong.Size = new System.Drawing.Size(908, 652);
            this.dgvQuanLyPhong.TabIndex = 3;
            // 
            // colPhongID
            // 
            this.colPhongID.HeaderText = "Phòng ID";
            this.colPhongID.MinimumWidth = 6;
            this.colPhongID.Name = "colPhongID";
            // 
            // colTenLoaiPhong
            // 
            this.colTenLoaiPhong.HeaderText = "Tên Loại Phòng";
            this.colTenLoaiPhong.MinimumWidth = 6;
            this.colTenLoaiPhong.Name = "colTenLoaiPhong";
            // 
            // colGiaPhong
            // 
            this.colGiaPhong.HeaderText = "Giá phòng";
            this.colGiaPhong.MinimumWidth = 6;
            this.colGiaPhong.Name = "colGiaPhong";
            // 
            // btnCapNhatVatTu
            // 
            this.btnCapNhatVatTu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCapNhatVatTu.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnCapNhatVatTu.BorderColor = System.Drawing.Color.White;
            this.btnCapNhatVatTu.BorderRadius = 21;
            this.btnCapNhatVatTu.BorderSize = 2;
            this.btnCapNhatVatTu.FlatAppearance.BorderSize = 0;
            this.btnCapNhatVatTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatVatTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatVatTu.ForeColor = System.Drawing.Color.Aqua;
            this.btnCapNhatVatTu.Location = new System.Drawing.Point(98, 330);
            this.btnCapNhatVatTu.Name = "btnCapNhatVatTu";
            this.btnCapNhatVatTu.Size = new System.Drawing.Size(262, 82);
            this.btnCapNhatVatTu.TabIndex = 2;
            this.btnCapNhatVatTu.Text = "CẬP NHẬT VẬT TƯ";
            this.btnCapNhatVatTu.TextColor = System.Drawing.Color.Aqua;
            this.btnCapNhatVatTu.UseVisualStyleBackColor = false;
            this.btnCapNhatVatTu.Click += new System.EventHandler(this.btnCapNhatVatTu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnThoat.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnThoat.BorderColor = System.Drawing.Color.White;
            this.btnThoat.BorderRadius = 21;
            this.btnThoat.BorderSize = 2;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Aqua;
            this.btnThoat.Location = new System.Drawing.Point(98, 741);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(262, 82);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "QUAY LẠI";
            this.btnThoat.TextColor = System.Drawing.Color.Aqua;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapNhatDichVu
            // 
            this.btnCapNhatDichVu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCapNhatDichVu.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnCapNhatDichVu.BorderColor = System.Drawing.Color.White;
            this.btnCapNhatDichVu.BorderRadius = 21;
            this.btnCapNhatDichVu.BorderSize = 2;
            this.btnCapNhatDichVu.FlatAppearance.BorderSize = 0;
            this.btnCapNhatDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatDichVu.ForeColor = System.Drawing.Color.Aqua;
            this.btnCapNhatDichVu.Location = new System.Drawing.Point(98, 474);
            this.btnCapNhatDichVu.Name = "btnCapNhatDichVu";
            this.btnCapNhatDichVu.Size = new System.Drawing.Size(262, 82);
            this.btnCapNhatDichVu.TabIndex = 4;
            this.btnCapNhatDichVu.Text = "CẬP NHẬT DỊCH VỤ";
            this.btnCapNhatDichVu.TextColor = System.Drawing.Color.Aqua;
            this.btnCapNhatDichVu.UseVisualStyleBackColor = false;
            this.btnCapNhatDichVu.Click += new System.EventHandler(this.btnCapNhatDichVu_Click);
            // 
            // FormQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1620, 971);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCapNhatVatTu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhatDichVu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(300, 0);
            this.Name = "FormQuanLyPhong";
            this.Text = "Q";
            this.Load += new System.EventHandler(this.FormQuanLyPhong_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomButton.CustomButton btnCapNhatVatTu;
        private CustomButton.CustomButton btnThoat;
        private CustomButton.CustomButton btnCapNhatDichVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvQuanLyPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhongID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaPhong;
    }
}