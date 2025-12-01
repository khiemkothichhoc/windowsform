namespace BT8
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Đồng Nai");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("9912578-Nguyễn Văn A", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("NCTH3KA", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("NCTH3KB");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("CDTH11K");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Danh sách lớp", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            this.tvDSL = new System.Windows.Forms.TreeView();
            this.grbTTSV = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.grbTTSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvDSL
            // 
            this.tvDSL.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvDSL.Location = new System.Drawing.Point(0, 0);
            this.tvDSL.Name = "tvDSL";
            treeNode1.Name = "Node4";
            treeNode1.Text = "Đồng Nai";
            treeNode2.Name = "Node2";
            treeNode2.Text = "9912578-Nguyễn Văn A";
            treeNode3.Name = "Node1";
            treeNode3.Text = "NCTH3KA";
            treeNode4.Name = "Node5";
            treeNode4.Text = "NCTH3KB";
            treeNode5.Name = "Node6";
            treeNode5.Text = "CDTH11K";
            treeNode6.Name = "NodeDSL";
            treeNode6.Text = "Danh sách lớp";
            this.tvDSL.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.tvDSL.Size = new System.Drawing.Size(342, 459);
            this.tvDSL.TabIndex = 0;
            this.tvDSL.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDSL_AfterSelect);
            // 
            // grbTTSV
            // 
            this.grbTTSV.Controls.Add(this.btnXoa);
            this.grbTTSV.Controls.Add(this.btnCapNhat);
            this.grbTTSV.Controls.Add(this.txtDiaChi);
            this.grbTTSV.Controls.Add(this.txtHoTen);
            this.grbTTSV.Controls.Add(this.txtMaSV);
            this.grbTTSV.Controls.Add(this.lblDiaChi);
            this.grbTTSV.Controls.Add(this.lblHoTen);
            this.grbTTSV.Controls.Add(this.lblMaSV);
            this.grbTTSV.Location = new System.Drawing.Point(377, 23);
            this.grbTTSV.Name = "grbTTSV";
            this.grbTTSV.Size = new System.Drawing.Size(428, 265);
            this.grbTTSV.TabIndex = 1;
            this.grbTTSV.TabStop = false;
            this.grbTTSV.Text = "Thông tin sinh viên";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(246, 179);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 42);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(92, 179);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(120, 42);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(114, 125);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(271, 24);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(114, 79);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(271, 24);
            this.txtHoTen.TabIndex = 4;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(114, 38);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(271, 24);
            this.txtMaSV.TabIndex = 3;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(30, 128);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(53, 18);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(30, 82);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(52, 18);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(30, 42);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(52, 18);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã SV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 459);
            this.Controls.Add(this.grbTTSV);
            this.Controls.Add(this.tvDSL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.grbTTSV.ResumeLayout(false);
            this.grbTTSV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvDSL;
        private System.Windows.Forms.GroupBox grbTTSV;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaSV;
    }
}

