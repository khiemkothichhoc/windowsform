namespace baithuchanh2
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
            this.components = new System.ComponentModel.Container();
            this.dongho = new System.Windows.Forms.Label();
            this.batdau = new System.Windows.Forms.Button();
            this.dung = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // dongho
            // 
            this.dongho.AutoSize = true;
            this.dongho.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongho.Location = new System.Drawing.Point(275, 75);
            this.dongho.Name = "dongho";
            this.dongho.Size = new System.Drawing.Size(0, 54);
            this.dongho.TabIndex = 0;
            this.dongho.Click += new System.EventHandler(this.dongho_Click);
            // 
            // batdau
            // 
            this.batdau.BackColor = System.Drawing.SystemColors.ControlLight;
            this.batdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batdau.Location = new System.Drawing.Point(71, 218);
            this.batdau.Name = "batdau";
            this.batdau.Size = new System.Drawing.Size(168, 86);
            this.batdau.TabIndex = 1;
            this.batdau.Text = "Bắt đầu";
            this.batdau.UseVisualStyleBackColor = false;
            this.batdau.Click += new System.EventHandler(this.batdau_Click);
            // 
            // dung
            // 
            this.dung.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dung.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dung.Location = new System.Drawing.Point(513, 218);
            this.dung.Name = "dung";
            this.dung.Size = new System.Drawing.Size(168, 86);
            this.dung.TabIndex = 2;
            this.dung.Text = "Dừng";
            this.dung.UseVisualStyleBackColor = false;
            this.dung.Click += new System.EventHandler(this.dung_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dung);
            this.Controls.Add(this.batdau);
            this.Controls.Add(this.dongho);
            this.Name = "Form1";
            this.Text = "Đồng hồ đếm ngược";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dongho;
        private System.Windows.Forms.Button batdau;
        private System.Windows.Forms.Button dung;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

