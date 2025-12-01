namespace baithuchanh2
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vn = new System.Windows.Forms.RadioButton();
            this.USA = new System.Windows.Forms.RadioButton();
            this.italia = new System.Windows.Forms.RadioButton();
            this.philipin = new System.Windows.Forms.RadioButton();
            this.picCo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(234, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "COUNTRY FLAGS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.philipin);
            this.groupBox1.Controls.Add(this.italia);
            this.groupBox1.Controls.Add(this.USA);
            this.groupBox1.Controls.Add(this.vn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 295);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // vn
            // 
            this.vn.AutoSize = true;
            this.vn.Location = new System.Drawing.Point(27, 54);
            this.vn.Name = "vn";
            this.vn.Size = new System.Drawing.Size(113, 29);
            this.vn.TabIndex = 4;
            this.vn.TabStop = true;
            this.vn.Text = "Việt Nam";
            this.vn.UseVisualStyleBackColor = true;
            this.vn.CheckedChanged += new System.EventHandler(this.vn_CheckedChanged);
            // 
            // USA
            // 
            this.USA.AutoSize = true;
            this.USA.Location = new System.Drawing.Point(27, 100);
            this.USA.Name = "USA";
            this.USA.Size = new System.Drawing.Size(75, 29);
            this.USA.TabIndex = 5;
            this.USA.TabStop = true;
            this.USA.Text = "USA";
            this.USA.UseVisualStyleBackColor = true;
            this.USA.CheckedChanged += new System.EventHandler(this.USA_CheckedChanged);
            // 
            // italia
            // 
            this.italia.AutoSize = true;
            this.italia.Location = new System.Drawing.Point(27, 153);
            this.italia.Name = "italia";
            this.italia.Size = new System.Drawing.Size(73, 29);
            this.italia.TabIndex = 6;
            this.italia.TabStop = true;
            this.italia.Text = "Italia";
            this.italia.UseVisualStyleBackColor = true;
            this.italia.CheckedChanged += new System.EventHandler(this.italia_CheckedChanged);
            // 
            // philipin
            // 
            this.philipin.AutoSize = true;
            this.philipin.Location = new System.Drawing.Point(27, 209);
            this.philipin.Name = "philipin";
            this.philipin.Size = new System.Drawing.Size(117, 29);
            this.philipin.TabIndex = 7;
            this.philipin.TabStop = true;
            this.philipin.Text = "Philippine";
            this.philipin.UseVisualStyleBackColor = true;
            this.philipin.CheckedChanged += new System.EventHandler(this.philipin_CheckedChanged);
            // 
            // picCo
            // 
            this.picCo.Image = global::baithuchanh2.Properties.Resources.USA;
            this.picCo.Location = new System.Drawing.Point(364, 109);
            this.picCo.Name = "picCo";
            this.picCo.Size = new System.Drawing.Size(349, 267);
            this.picCo.TabIndex = 4;
            this.picCo.TabStop = false;
            this.picCo.Click += new System.EventHandler(this.picCo_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picCo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Quốc Kỳ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton philipin;
        private System.Windows.Forms.RadioButton italia;
        private System.Windows.Forms.RadioButton USA;
        private System.Windows.Forms.RadioButton vn;
        private System.Windows.Forms.PictureBox picCo;
    }
}