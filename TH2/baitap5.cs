using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai6
{
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }

        private void frmTreeView_Load(object sender, EventArgs e)
        {
            for (int i = 65; i <= 90; i++)
            {
                string kt = ((char)i).ToString();
                tvDSTen.Nodes.Add(kt,kt);
            }
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            String key = fn.Text.Trim()[0].ToString();
            tvDSTen.Nodes[key].Nodes.Add(fn.Text + "," + ln.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
