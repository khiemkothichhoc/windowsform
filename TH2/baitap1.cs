using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baithuchanh2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int demnguoc = 1000009000;

        private void batdau_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void dung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            this.dongho.Text = demnguoc.ToString();

            demnguoc = demnguoc - 1;

            
            if (demnguoc < 0)
            {
                this.timer1.Enabled = false;
                this.dongho.Text = "Hết giờ !";
            }


        }

        private void dongho_Click(object sender, EventArgs e)
        {

        }
    }
}
