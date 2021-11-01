
namespace QuanLyKhachSan.PresentationTier
{
    partial class FormBaoCao
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new QuanLyKhachSan.CustomButton.CustomButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(681, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "THỐNG KÊ";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThoat.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThoat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThoat.BorderRadius = 25;
            this.btnThoat.BorderSize = 0;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(109, 64);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(152, 74);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.reportViewer1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 158);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.94453F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1578, 898);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1572, 892);
            this.reportViewer1.TabIndex = 2;
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.xanh;
            this.ClientSize = new System.Drawing.Size(1620, 1055);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(300, 0);
            this.Name = "FormBaoCao";
            this.Text = "FormBaoCao";
            this.Load += new System.EventHandler(this.FormBaoCao_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private CustomButton.CustomButton btnThoat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}