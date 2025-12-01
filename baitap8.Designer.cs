namespace BT9
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblBCTTD = new System.Windows.Forms.Label();
            this.lblHoTenKH = new System.Windows.Forms.Label();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.lblDinhMuc = new System.Windows.Forms.Label();
            this.lblSoCu = new System.Windows.Forms.Label();
            this.lblSoMoi = new System.Windows.Forms.Label();
            this.lblTieuThu = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDinhMuc = new System.Windows.Forms.TextBox();
            this.txtSoCu = new System.Windows.Forms.TextBox();
            this.txtSoMoi = new System.Windows.Forms.TextBox();
            this.txtTieuThu = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.cboKhuVuc = new System.Windows.Forms.ComboBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnNhapMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.clnHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnKhuVuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDinhMuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTieuThu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnHoTen,
            this.clnKhuVuc,
            this.clnDinhMuc,
            this.clnTieuThu,
            this.clnThanhTien});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(431, 47);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(504, 340);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lblBCTTD
            // 
            this.lblBCTTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBCTTD.Location = new System.Drawing.Point(63, 9);
            this.lblBCTTD.Name = "lblBCTTD";
            this.lblBCTTD.Size = new System.Drawing.Size(346, 42);
            this.lblBCTTD.TabIndex = 1;
            this.lblBCTTD.Text = "BÁO CÁO TIÊU THỤ ĐIỆN";
            this.lblBCTTD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoTenKH
            // 
            this.lblHoTenKH.AutoSize = true;
            this.lblHoTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoTenKH.Location = new System.Drawing.Point(17, 85);
            this.lblHoTenKH.Name = "lblHoTenKH";
            this.lblHoTenKH.Size = new System.Drawing.Size(88, 17);
            this.lblHoTenKH.TabIndex = 2;
            this.lblHoTenKH.Text = "HỌ TÊN KH:";
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKhuVuc.Location = new System.Drawing.Point(17, 122);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(73, 17);
            this.lblKhuVuc.TabIndex = 3;
            this.lblKhuVuc.Text = "KHU VỰC:";
            // 
            // lblDinhMuc
            // 
            this.lblDinhMuc.AutoSize = true;
            this.lblDinhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDinhMuc.Location = new System.Drawing.Point(17, 159);
            this.lblDinhMuc.Name = "lblDinhMuc";
            this.lblDinhMuc.Size = new System.Drawing.Size(79, 17);
            this.lblDinhMuc.TabIndex = 4;
            this.lblDinhMuc.Text = "ĐỊNH MỨC:";
            // 
            // lblSoCu
            // 
            this.lblSoCu.AutoSize = true;
            this.lblSoCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoCu.Location = new System.Drawing.Point(17, 199);
            this.lblSoCu.Name = "lblSoCu";
            this.lblSoCu.Size = new System.Drawing.Size(55, 17);
            this.lblSoCu.TabIndex = 5;
            this.lblSoCu.Text = "SỐ CŨ:";
            // 
            // lblSoMoi
            // 
            this.lblSoMoi.AutoSize = true;
            this.lblSoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoMoi.Location = new System.Drawing.Point(17, 241);
            this.lblSoMoi.Name = "lblSoMoi";
            this.lblSoMoi.Size = new System.Drawing.Size(61, 17);
            this.lblSoMoi.TabIndex = 6;
            this.lblSoMoi.Text = "SỐ MỚI:";
            // 
            // lblTieuThu
            // 
            this.lblTieuThu.AutoSize = true;
            this.lblTieuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuThu.Location = new System.Drawing.Point(17, 285);
            this.lblTieuThu.Name = "lblTieuThu";
            this.lblTieuThu.Size = new System.Drawing.Size(76, 17);
            this.lblTieuThu.TabIndex = 7;
            this.lblTieuThu.Text = "TIÊU THỤ:";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThanhTien.Location = new System.Drawing.Point(17, 324);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(95, 17);
            this.lblThanhTien.TabIndex = 8;
            this.lblThanhTien.Text = "THÀNH TIỀN:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(452, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "TỔNG TIỀN";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(124, 82);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(206, 22);
            this.txtHoTen.TabIndex = 10;
            // 
            // txtDinhMuc
            // 
            this.txtDinhMuc.Location = new System.Drawing.Point(124, 159);
            this.txtDinhMuc.Name = "txtDinhMuc";
            this.txtDinhMuc.ReadOnly = true;
            this.txtDinhMuc.Size = new System.Drawing.Size(206, 22);
            this.txtDinhMuc.TabIndex = 11;
            // 
            // txtSoCu
            // 
            this.txtSoCu.Location = new System.Drawing.Point(124, 196);
            this.txtSoCu.Name = "txtSoCu";
            this.txtSoCu.Size = new System.Drawing.Size(206, 22);
            this.txtSoCu.TabIndex = 12;
            // 
            // txtSoMoi
            // 
            this.txtSoMoi.Location = new System.Drawing.Point(124, 238);
            this.txtSoMoi.Name = "txtSoMoi";
            this.txtSoMoi.Size = new System.Drawing.Size(206, 22);
            this.txtSoMoi.TabIndex = 13;
            // 
            // txtTieuThu
            // 
            this.txtTieuThu.Location = new System.Drawing.Point(124, 282);
            this.txtTieuThu.Name = "txtTieuThu";
            this.txtTieuThu.ReadOnly = true;
            this.txtTieuThu.Size = new System.Drawing.Size(206, 22);
            this.txtTieuThu.TabIndex = 14;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(124, 321);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(206, 22);
            this.txtThanhTien.TabIndex = 15;
            // 
            // cboKhuVuc
            // 
            this.cboKhuVuc.FormattingEnabled = true;
            this.cboKhuVuc.Items.AddRange(new object[] {
            "Khu vực 1",
            "Khu vực 2",
            "Khu vực 3"});
            this.cboKhuVuc.Location = new System.Drawing.Point(124, 119);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.Size = new System.Drawing.Size(206, 24);
            this.cboKhuVuc.TabIndex = 16;
            this.cboKhuVuc.SelectedIndexChanged += new System.EventHandler(this.cboKhuVuc_SelectedIndexChanged);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTinhTien.Location = new System.Drawing.Point(20, 385);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(100, 34);
            this.btnTinhTien.TabIndex = 17;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnNhapMoi
            // 
            this.btnNhapMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhapMoi.Location = new System.Drawing.Point(166, 385);
            this.btnNhapMoi.Name = "btnNhapMoi";
            this.btnNhapMoi.Size = new System.Drawing.Size(100, 34);
            this.btnNhapMoi.TabIndex = 18;
            this.btnNhapMoi.Text = "Nhập mới";
            this.btnNhapMoi.UseVisualStyleBackColor = true;
            this.btnNhapMoi.Click += new System.EventHandler(this.btnNhapMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(309, 385);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 34);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(548, 400);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(206, 22);
            this.txtTongTien.TabIndex = 20;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(804, 397);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 34);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // clnHoTen
            // 
            this.clnHoTen.Text = "Họ tên";
            this.clnHoTen.Width = 120;
            // 
            // clnKhuVuc
            // 
            this.clnKhuVuc.Text = "Khu vực";
            this.clnKhuVuc.Width = 70;
            // 
            // clnDinhMuc
            // 
            this.clnDinhMuc.Text = "ĐỊnh mức";
            this.clnDinhMuc.Width = 70;
            // 
            // clnTieuThu
            // 
            this.clnTieuThu.Text = "Tiêu thụ";
            this.clnTieuThu.Width = 70;
            // 
            // clnThanhTien
            // 
            this.clnThanhTien.Text = "Thành tiền";
            this.clnThanhTien.Width = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 453);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNhapMoi);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.cboKhuVuc);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtTieuThu);
            this.Controls.Add(this.txtSoMoi);
            this.Controls.Add(this.txtSoCu);
            this.Controls.Add(this.txtDinhMuc);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.lblTieuThu);
            this.Controls.Add(this.lblSoMoi);
            this.Controls.Add(this.lblSoCu);
            this.Controls.Add(this.lblDinhMuc);
            this.Controls.Add(this.lblKhuVuc);
            this.Controls.Add(this.lblHoTenKH);
            this.Controls.Add(this.lblBCTTD);
            this.Controls.Add(this.listView1);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính tiền điện";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblBCTTD;
        private System.Windows.Forms.Label lblHoTenKH;
        private System.Windows.Forms.Label lblKhuVuc;
        private System.Windows.Forms.Label lblDinhMuc;
        private System.Windows.Forms.Label lblSoCu;
        private System.Windows.Forms.Label lblSoMoi;
        private System.Windows.Forms.Label lblTieuThu;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDinhMuc;
        private System.Windows.Forms.TextBox txtSoCu;
        private System.Windows.Forms.TextBox txtSoMoi;
        private System.Windows.Forms.TextBox txtTieuThu;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnNhapMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ColumnHeader clnHoTen;
        private System.Windows.Forms.ColumnHeader clnKhuVuc;
        private System.Windows.Forms.ColumnHeader clnDinhMuc;
        private System.Windows.Forms.ColumnHeader clnTieuThu;
        private System.Windows.Forms.ColumnHeader clnThanhTien;
    }
}

