
namespace QuanLyKhachSan.PresentationTier
{
    partial class FormChiTietPhong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuLuu = new System.Windows.Forms.ToolStripButton();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThanhTienDV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxTenDichVu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.cbxSoPhong = new System.Windows.Forms.ComboBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.cbxNhanVien = new System.Windows.Forms.ComboBox();
            this.cbxLoaiPhong = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtQuocTich = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtSoNguoi = new System.Windows.Forms.TextBox();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.txtSoDem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(9, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 48);
            this.panel1.TabIndex = 9;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLuu});
            this.toolStrip1.Location = new System.Drawing.Point(60, 12);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(74, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuLuu
            // 
            this.menuLuu.Image = global::QuanLyKhachSan.Properties.Resources.floppy_disk;
            this.menuLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuLuu.Name = "menuLuu";
            this.menuLuu.Size = new System.Drawing.Size(61, 24);
            this.menuLuu.Text = "LƯU";
            this.menuLuu.Click += new System.EventHandler(this.menuLuu_Click_1);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(718, 11);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTongTien.Size = new System.Drawing.Size(126, 28);
            this.txtTongTien.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(636, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tổng tiền";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.xanh1;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtThanhTienDV);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.cbxTenDichVu);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtSoLuong);
            this.panel4.Location = new System.Drawing.Point(9, 418);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(939, 109);
            this.panel4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loại dịch vụ";
            // 
            // txtThanhTienDV
            // 
            this.txtThanhTienDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTienDV.Location = new System.Drawing.Point(785, 51);
            this.txtThanhTienDV.Name = "txtThanhTienDV";
            this.txtThanhTienDV.ReadOnly = true;
            this.txtThanhTienDV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtThanhTienDV.Size = new System.Drawing.Size(142, 30);
            this.txtThanhTienDV.TabIndex = 1;
            this.txtThanhTienDV.TextChanged += new System.EventHandler(this.txtThanhTienDV_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(636, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Thành tiền dịch vụ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxTenDichVu
            // 
            this.cbxTenDichVu.FormattingEnabled = true;
            this.cbxTenDichVu.Location = new System.Drawing.Point(370, 58);
            this.cbxTenDichVu.Name = "cbxTenDichVu";
            this.cbxTenDichVu.Size = new System.Drawing.Size(228, 24);
            this.cbxTenDichVu.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "DỊCH VỤ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(136, 61);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(77, 24);
            this.txtSoLuong.TabIndex = 1;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colTenDichVu,
            this.colGia,
            this.colSoLuong,
            this.colThanhTien,
            this.id});
            this.dgvDichVu.Location = new System.Drawing.Point(46, 606);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(890, 340);
            this.dgvDichVu.TabIndex = 12;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            // 
            // colTenDichVu
            // 
            this.colTenDichVu.HeaderText = "Tên dịch vụ";
            this.colTenDichVu.MinimumWidth = 6;
            this.colTenDichVu.Name = "colTenDichVu";
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Giá";
            this.colGia.MinimumWidth = 6;
            this.colGia.Name = "colGia";
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(577, 545);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(15, 15, 30, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 43);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(216, 545);
            this.btnThem.Margin = new System.Windows.Forms.Padding(15, 15, 30, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 43);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.xanh1;
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.cbxSoPhong);
            this.panel3.Controls.Add(this.txtThanhTien);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.dtpNgayTra);
            this.panel3.Controls.Add(this.cbxNhanVien);
            this.panel3.Controls.Add(this.cbxLoaiPhong);
            this.panel3.Controls.Add(this.dtpNgayNhan);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtQuocTich);
            this.panel3.Controls.Add(this.txtCCCD);
            this.panel3.Controls.Add(this.txtSoNguoi);
            this.panel3.Controls.Add(this.txtGiaPhong);
            this.panel3.Controls.Add(this.txtSoDem);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtTenKH);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Location = new System.Drawing.Point(9, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 473);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(84, 314);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 18);
            this.label19.TabIndex = 0;
            this.label19.Text = "Nhan vien";
            // 
            // cbxSoPhong
            // 
            this.cbxSoPhong.FormattingEnabled = true;
            this.cbxSoPhong.Location = new System.Drawing.Point(189, 222);
            this.cbxSoPhong.Name = "cbxSoPhong";
            this.cbxSoPhong.Size = new System.Drawing.Size(62, 24);
            this.cbxSoPhong.TabIndex = 10;
            this.cbxSoPhong.SelectedIndexChanged += new System.EventHandler(this.cbxSoPhong_SelectedIndexChanged);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(662, 314);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtThanhTien.Size = new System.Drawing.Size(228, 28);
            this.txtThanhTien.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(565, 314);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 18);
            this.label18.TabIndex = 8;
            this.label18.Text = "Tiền phòng";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(662, 128);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(228, 22);
            this.dtpNgayTra.TabIndex = 9;
            // 
            // cbxNhanVien
            // 
            this.cbxNhanVien.FormattingEnabled = true;
            this.cbxNhanVien.Location = new System.Drawing.Point(189, 308);
            this.cbxNhanVien.Name = "cbxNhanVien";
            this.cbxNhanVien.Size = new System.Drawing.Size(248, 24);
            this.cbxNhanVien.TabIndex = 10;
            // 
            // cbxLoaiPhong
            // 
            this.cbxLoaiPhong.FormattingEnabled = true;
            this.cbxLoaiPhong.Location = new System.Drawing.Point(189, 268);
            this.cbxLoaiPhong.Name = "cbxLoaiPhong";
            this.cbxLoaiPhong.Size = new System.Drawing.Size(152, 24);
            this.cbxLoaiPhong.TabIndex = 10;
            this.cbxLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbxLoaiPhong_SelectedIndexChanged);
            // 
            // dtpNgayNhan
            // 
            this.dtpNgayNhan.CustomFormat = "";
            this.dtpNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhan.Location = new System.Drawing.Point(662, 78);
            this.dtpNgayNhan.Name = "dtpNgayNhan";
            this.dtpNgayNhan.Size = new System.Drawing.Size(228, 22);
            this.dtpNgayNhan.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(293, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(372, 36);
            this.label17.TabIndex = 8;
            this.label17.Text = "CHI TIẾT PHIẾU PHÒNG";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(89, 274);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "Loại phòng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(98, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Quốc tịch";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Số CMND/CCCD";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số phòng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(57, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tên khách hàng";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(534, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "Ngày trả phòng ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(523, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 18);
            this.label13.TabIndex = 2;
            this.label13.Text = "Ngày nhận phòng";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuocTich
            // 
            this.txtQuocTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuocTich.Location = new System.Drawing.Point(189, 177);
            this.txtQuocTich.Name = "txtQuocTich";
            this.txtQuocTich.Size = new System.Drawing.Size(248, 24);
            this.txtQuocTich.TabIndex = 1;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(189, 125);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(248, 24);
            this.txtCCCD.TabIndex = 1;
            // 
            // txtSoNguoi
            // 
            this.txtSoNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNguoi.Location = new System.Drawing.Point(662, 268);
            this.txtSoNguoi.Name = "txtSoNguoi";
            this.txtSoNguoi.Size = new System.Drawing.Size(228, 24);
            this.txtSoNguoi.TabIndex = 1;
            this.txtSoNguoi.TextChanged += new System.EventHandler(this.txtSoNguoi_TextChanged);
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaPhong.Location = new System.Drawing.Point(662, 222);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(228, 24);
            this.txtGiaPhong.TabIndex = 1;
            this.txtGiaPhong.TextChanged += new System.EventHandler(this.txtGiaPhong_TextChanged);
            // 
            // txtSoDem
            // 
            this.txtSoDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDem.Location = new System.Drawing.Point(662, 177);
            this.txtSoDem.Name = "txtSoDem";
            this.txtSoDem.Size = new System.Drawing.Size(228, 24);
            this.txtSoDem.TabIndex = 1;
            this.txtSoDem.TextChanged += new System.EventHandler(this.txtSoDem_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(579, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số người";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(189, 76);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(248, 24);
            this.txtTenKH.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(570, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giá phòng";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(525, 177);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 18);
            this.label16.TabIndex = 0;
            this.label16.Text = "Số đêm (dự kiến)";
            // 
            // FormChiTietPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.xanh1;
            this.ClientSize = new System.Drawing.Size(957, 1040);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "FormChiTietPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChiTietPhong";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChiTietPhong_FormClosed);
            this.Load += new System.EventHandler(this.FormChiTietPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtQuocTich;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtSoDem;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTenDichVu;
        private System.Windows.Forms.ComboBox cbxSoPhong;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayNhan;
        private System.Windows.Forms.TextBox txtSoNguoi;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripButton menuLuu;
        private System.Windows.Forms.TextBox txtThanhTienDV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbxNhanVien;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbxLoaiPhong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}