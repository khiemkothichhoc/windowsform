namespace ktraaa
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
            this.chonmon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.score = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.them = new System.Windows.Forms.Button();
            this.xoadiem = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.thongke = new System.Windows.Forms.Button();
            this.nameee = new System.Windows.Forms.TextBox();
            this.subjectid = new System.Windows.Forms.TextBox();
            this.ten = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chonmon
            // 
            this.chonmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chonmon.FormattingEnabled = true;
            this.chonmon.Items.AddRange(new object[] {
            "Toán",
            "Lý",
            "Hóa",
            "Sinh",
            "Anh"});
            this.chonmon.Location = new System.Drawing.Point(229, 69);
            this.chonmon.Name = "chonmon";
            this.chonmon.Size = new System.Drawing.Size(222, 33);
            this.chonmon.TabIndex = 0;
            this.chonmon.SelectedIndexChanged += new System.EventHandler(this.chonmon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý điểm theo môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "ResultID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Điểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Chọn môn học:";
            // 
            // id
            // 
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(185, 430);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(213, 30);
            this.id.TabIndex = 5;
            // 
            // score
            // 
            this.score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(185, 468);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(213, 30);
            this.score.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(783, 280);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.Color.LightCyan;
            this.them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them.Location = new System.Drawing.Point(12, 537);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(190, 47);
            this.them.TabIndex = 8;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // xoadiem
            // 
            this.xoadiem.BackColor = System.Drawing.Color.Red;
            this.xoadiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoadiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xoadiem.Location = new System.Drawing.Point(528, 537);
            this.xoadiem.Name = "xoadiem";
            this.xoadiem.Size = new System.Drawing.Size(190, 47);
            this.xoadiem.TabIndex = 9;
            this.xoadiem.Text = "Xóa điểm";
            this.xoadiem.UseVisualStyleBackColor = false;
            this.xoadiem.Click += new System.EventHandler(this.xoadiem_Click);
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.Color.LightCyan;
            this.sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua.Location = new System.Drawing.Point(280, 537);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(190, 47);
            this.sua.TabIndex = 10;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // thongke
            // 
            this.thongke.BackColor = System.Drawing.Color.LightCyan;
            this.thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongke.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.thongke.Location = new System.Drawing.Point(859, 226);
            this.thongke.Name = "thongke";
            this.thongke.Size = new System.Drawing.Size(138, 114);
            this.thongke.TabIndex = 11;
            this.thongke.Text = "Thống kê";
            this.thongke.UseVisualStyleBackColor = false;
            this.thongke.Click += new System.EventHandler(this.thongke_Click);
            // 
            // nameee
            // 
            this.nameee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameee.Location = new System.Drawing.Point(608, 426);
            this.nameee.Name = "nameee";
            this.nameee.Size = new System.Drawing.Size(213, 30);
            this.nameee.TabIndex = 12;
            // 
            // subjectid
            // 
            this.subjectid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subjectid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectid.Location = new System.Drawing.Point(608, 468);
            this.subjectid.Name = "subjectid";
            this.subjectid.Size = new System.Drawing.Size(213, 30);
            this.subjectid.TabIndex = 13;
            // 
            // ten
            // 
            this.ten.AutoSize = true;
            this.ten.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten.Location = new System.Drawing.Point(467, 427);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(135, 27);
            this.ten.TabIndex = 14;
            this.ten.Text = "Tên sinh viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(467, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 27);
            this.label5.TabIndex = 15;
            this.label5.Text = "SubjectID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1040, 596);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.subjectid);
            this.Controls.Add(this.nameee);
            this.Controls.Add(this.thongke);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.xoadiem);
            this.Controls.Add(this.them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.score);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chonmon);
            this.Name = "Form1";
            this.Text = "Chương trình quản lý điểm theo môn học";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox chonmon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox score;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button xoadiem;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button thongke;
        private System.Windows.Forms.TextBox nameee;
        private System.Windows.Forms.TextBox subjectid;
        private System.Windows.Forms.Label ten;
        private System.Windows.Forms.Label label5;
    }
}

