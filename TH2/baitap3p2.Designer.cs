using System.Windows.Forms;

namespace baithuchanh2
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.capnhat = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.themmoi = new System.Windows.Forms.Button();
            this.ngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.lop = new System.Windows.Forms.TextBox();
            this.hovaten = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.TextBox();
            this.masv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.capnhat);
            this.groupBox1.Controls.Add(this.xoa);
            this.groupBox1.Controls.Add(this.thoat);
            this.groupBox1.Controls.Add(this.themmoi);
            this.groupBox1.Controls.Add(this.ngaysinh);
            this.groupBox1.Controls.Add(this.lop);
            this.groupBox1.Controls.Add(this.hovaten);
            this.groupBox1.Controls.Add(this.diachi);
            this.groupBox1.Controls.Add(this.masv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(70, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 360);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // capnhat
            // 
            this.capnhat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.capnhat.Location = new System.Drawing.Point(447, 105);
            this.capnhat.Name = "capnhat";
            this.capnhat.Size = new System.Drawing.Size(132, 53);
            this.capnhat.TabIndex = 15;
            this.capnhat.Text = "Cập nhật item";
            this.capnhat.UseVisualStyleBackColor = false;
            this.capnhat.Click += new System.EventHandler(this.capnhat_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.xoa.Location = new System.Drawing.Point(447, 164);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(132, 53);
            this.xoa.TabIndex = 14;
            this.xoa.Text = "Xóa item";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.thoat.Location = new System.Drawing.Point(447, 223);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(132, 53);
            this.thoat.TabIndex = 13;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = false;
            // 
            // themmoi
            // 
            this.themmoi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.themmoi.Location = new System.Drawing.Point(447, 46);
            this.themmoi.Name = "themmoi";
            this.themmoi.Size = new System.Drawing.Size(132, 53);
            this.themmoi.TabIndex = 12;
            this.themmoi.Text = "Thêm mới";
            this.themmoi.UseVisualStyleBackColor = false;
            this.themmoi.Click += new System.EventHandler(this.themmoi_Click);
            // 
            // ngaysinh
            // 
            this.ngaysinh.Location = new System.Drawing.Point(167, 189);
            this.ngaysinh.Mask = "00/00/0000";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(229, 27);
            this.ngaysinh.TabIndex = 11;
            this.ngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // lop
            // 
            this.lop.Location = new System.Drawing.Point(167, 247);
            this.lop.Name = "lop";
            this.lop.Size = new System.Drawing.Size(229, 27);
            this.lop.TabIndex = 9;
            // 
            // hovaten
            // 
            this.hovaten.Location = new System.Drawing.Point(167, 92);
            this.hovaten.Name = "hovaten";
            this.hovaten.Size = new System.Drawing.Size(229, 27);
            this.hovaten.TabIndex = 8;
            // 
            // diachi
            // 
            this.diachi.Location = new System.Drawing.Point(167, 135);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(229, 27);
            this.diachi.TabIndex = 7;
            // 
            // masv
            // 
            this.masv.Location = new System.Drawing.Point(167, 43);
            this.masv.Name = "masv";
            this.masv.Size = new System.Drawing.Size(229, 27);
            this.masv.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(32, 403);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(750, 249);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sinh viên";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Địa chỉ";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày sinh";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lớp";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 90;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 687);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "BÀI TẬP LISTVIEW";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lop;
        private System.Windows.Forms.TextBox hovaten;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.TextBox masv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox ngaysinh;
        private System.Windows.Forms.Button capnhat;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button themmoi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}