namespace BT6
{
    partial class frmTreeView
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
            this.tvDSTen = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addname = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.TextBox();
            this.fn = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.ex = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvDSTen
            // 
            this.tvDSTen.Location = new System.Drawing.Point(30, 30);
            this.tvDSTen.Name = "tvDSTen";
            this.tvDSTen.Size = new System.Drawing.Size(282, 408);
            this.tvDSTen.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addname);
            this.panel1.Controls.Add(this.ln);
            this.panel1.Controls.Add(this.fn);
            this.panel1.Controls.Add(this.lblLastName);
            this.panel1.Controls.Add(this.lblFirstName);
            this.panel1.Location = new System.Drawing.Point(366, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 222);
            this.panel1.TabIndex = 1;
            // 
            // addname
            // 
            this.addname.Location = new System.Drawing.Point(167, 171);
            this.addname.Name = "addname";
            this.addname.Size = new System.Drawing.Size(103, 36);
            this.addname.TabIndex = 4;
            this.addname.Text = "Add Name";
            this.addname.UseVisualStyleBackColor = true;
            this.addname.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(40, 127);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(204, 22);
            this.ln.TabIndex = 3;
            // 
            // fn
            // 
            this.fn.Location = new System.Drawing.Point(37, 54);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(207, 22);
            this.fn.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(37, 97);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 16);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(34, 24);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 16);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // ex
            // 
            this.ex.Location = new System.Drawing.Point(533, 283);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(103, 36);
            this.ex.TabIndex = 2;
            this.ex.Text = "Exit";
            this.ex.UseVisualStyleBackColor = true;
            this.ex.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // frmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 455);
            this.Controls.Add(this.ex);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tvDSTen);
            this.Name = "frmTreeView";
            this.Text = "TreeView_Demo";
            this.Load += new System.EventHandler(this.frmTreeView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvDSTen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button addname;
        private System.Windows.Forms.TextBox ln;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.Button ex;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

