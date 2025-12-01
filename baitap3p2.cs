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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                masv.Text = item.SubItems[0].Text;
                hovaten.Text = item.SubItems[1].Text;
                diachi.Text = item.SubItems[2].Text;
                ngaysinh.Text = item.SubItems[3].Text;
                lop.Text = item.SubItems[4].Text;
            }
        }

        private void themmoi_Click(object sender, EventArgs e)
        {
            string[] mang = { masv.Text, hovaten.Text, diachi.Text, ngaysinh.Text, lop.Text };
            ListViewItem item = new ListViewItem(mang);
            listView1.Items.Add(item);
        }

        private void capnhat_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                item.SubItems[0].Text = masv.Text;
                item.SubItems[1].Text = hovaten.Text;
                item.SubItems[2].Text = diachi.Text;
                item.SubItems[3].Text = ngaysinh.Text;
                item.SubItems[4].Text = lop.Text;
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
            }
          
        }
    }
}
