
namespace QuanLyKhachSan.PresentationTier
{
    partial class FormNhanVien
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTTNhanVien = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.picAnhNhanVien = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(346, 118);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(346, 27);
            this.txtTimKiem.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm nhân viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTTNhanVien);
            this.panel1.Location = new System.Drawing.Point(121, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 440);
            this.panel1.TabIndex = 4;
            // 
            // dgvTTNhanVien
            // 
            this.dgvTTNhanVien.AllowUserToAddRows = false;
            this.dgvTTNhanVien.AllowUserToDeleteRows = false;
            this.dgvTTNhanVien.AllowUserToOrderColumns = true;
            this.dgvTTNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTTNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colID,
            this.colTenNhanVien});
            this.dgvTTNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTTNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvTTNhanVien.MultiSelect = false;
            this.dgvTTNhanVien.Name = "dgvTTNhanVien";
            this.dgvTTNhanVien.RowHeadersWidth = 51;
            this.dgvTTNhanVien.RowTemplate.Height = 24;
            this.dgvTTNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTTNhanVien.Size = new System.Drawing.Size(1111, 440);
            this.dgvTTNhanVien.TabIndex = 0;
            this.dgvTTNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTNhanVien_CellClick);
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            // 
            // colID
            // 
            this.colID.HeaderText = "Nhân viên ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.HeaderText = "Tên nhân viên";
            this.colTenNhanVien.MinimumWidth = 6;
            this.colTenNhanVien.Name = "colTenNhanVien";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(121, 292);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 63);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(325, 292);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 63);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(525, 292);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 63);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(718, 292);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 63);
            this.button5.TabIndex = 1;
            this.button5.Text = "Hủy";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1082, 292);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 63);
            this.button6.TabIndex = 1;
            this.button6.Text = "Thoát";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // picAnhNhanVien
            // 
            this.picAnhNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picAnhNhanVien.Location = new System.Drawing.Point(896, 76);
            this.picAnhNhanVien.Name = "picAnhNhanVien";
            this.picAnhNhanVien.Size = new System.Drawing.Size(368, 210);
            this.picAnhNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhNhanVien.TabIndex = 2;
            this.picAnhNhanVien.TabStop = false;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 844);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picAnhNhanVien);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTimKiem);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picAnhNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTTNhanVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhanVien;
    }
}