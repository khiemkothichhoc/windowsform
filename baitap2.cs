using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baithuchanh2
{
    public partial class Form2 : Form
    {
        string path = Application.StartupPath;

        public Form2()
        {
            InitializeComponent();
        }

        private void vn_CheckedChanged(object sender, EventArgs e)
        {
            if(vn.Checked )
            {
                picCo.Image = global::baithuchanh2.Properties.Resources.Việt_Nam;

            }
           
        }

        private void picCo_Click(object sender, EventArgs e)
        {

        }

        private void USA_CheckedChanged(object sender, EventArgs e)
        {
            if (USA.Checked)
            {
                picCo.Image = global::baithuchanh2.Properties.Resources.USA;

            }
        }

        private void italia_CheckedChanged(object sender, EventArgs e)
        {
            if (italia.Checked)
            {
                picCo.Image = global::baithuchanh2.Properties.Resources.Italia;

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void philipin_CheckedChanged(object sender, EventArgs e)
        {
            if (philipin.Checked)
            {
                picCo.Image = global::baithuchanh2.Properties.Resources.Philippine;
            }
        }
    }
}
