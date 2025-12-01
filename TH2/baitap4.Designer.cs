namespace BT5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.masv = new System.Windows.Forms.TextBox();
            this.hoten = new System.Windows.Forms.TextBox();
            this.quequan = new System.Windows.Forms.TextBox();
            this.nhap = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.tim = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnMaSV,
            this.clnTenSV,
            this.clnQueQuan});
            this.dataGridView1.Location = new System.Drawing.Point(24, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(590, 317);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // clnMaSV
            // 
            this.clnMaSV.HeaderText = "Mã SV";
            this.clnMaSV.MinimumWidth = 6;
            this.clnMaSV.Name = "clnMaSV";
            this.clnMaSV.Width = 125;
            // 
            // clnTenSV
            // 
            this.clnTenSV.HeaderText = "Tên SV";
            this.clnTenSV.MinimumWidth = 6;
            this.clnTenSV.Name = "clnTenSV";
            this.clnTenSV.Width = 125;
            // 
            // clnQueQuan
            // 
            this.clnQueQuan.HeaderText = "Quê quán";
            this.clnQueQuan.MinimumWidth = 6;
            this.clnQueQuan.Name = "clnQueQuan";
            this.clnQueQuan.Width = 125;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(21, 30);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(47, 16);
            this.lblMaSV.TabIndex = 1;
            this.lblMaSV.Text = "Mã SV";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(209, 30);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(46, 16);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Location = new System.Drawing.Point(421, 30);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(65, 16);
            this.lblQueQuan.TabIndex = 3;
            this.lblQueQuan.Text = "Quê quán";
            // 
            // masv
            // 
            this.masv.Location = new System.Drawing.Point(24, 62);
            this.masv.Name = "masv";
            this.masv.Size = new System.Drawing.Size(133, 22);
            this.masv.TabIndex = 4;
            // 
            // hoten
            // 
            this.hoten.Location = new System.Drawing.Point(212, 61);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(172, 22);
            this.hoten.TabIndex = 5;
            // 
            // quequan
            // 
            this.quequan.AcceptsReturn = true;
            this.quequan.Location = new System.Drawing.Point(424, 61);
            this.quequan.Name = "quequan";
            this.quequan.Size = new System.Drawing.Size(190, 22);
            this.quequan.TabIndex = 6;
            // 
            // nhap
            // 
            this.nhap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nhap.Location = new System.Drawing.Point(659, 30);
            this.nhap.Name = "nhap";
            this.nhap.Size = new System.Drawing.Size(116, 54);
            this.nhap.TabIndex = 7;
            this.nhap.Text = "Nhập";
            this.nhap.UseVisualStyleBackColor = false;
            this.nhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sua.Location = new System.Drawing.Point(659, 93);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(116, 61);
            this.sua.TabIndex = 8;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.Color.Chocolate;
            this.xoa.Location = new System.Drawing.Point(659, 160);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(116, 59);
            this.xoa.TabIndex = 9;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tim
            // 
            this.tim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tim.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tim.Location = new System.Drawing.Point(659, 225);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(116, 67);
            this.tim.TabIndex = 10;
            this.tim.Text = "Tìm";
            this.tim.UseVisualStyleBackColor = false;
            this.tim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // end
            // 
            this.end.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.end.Location = new System.Drawing.Point(659, 298);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(116, 68);
            this.end.TabIndex = 11;
            this.end.Text = "Kết thúc";
            this.end.UseVisualStyleBackColor = false;
            this.end.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.end);
            this.Controls.Add(this.tim);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.nhap);
            this.Controls.Add(this.quequan);
            this.Controls.Add(this.hoten);
            this.Controls.Add(this.masv);
            this.Controls.Add(this.lblQueQuan);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "frmDataGridView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.TextBox masv;
        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.TextBox quequan;
        private System.Windows.Forms.Button nhap;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button tim;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQueQuan;
    }
}

