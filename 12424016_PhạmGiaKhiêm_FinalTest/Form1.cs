using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ktraaa
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        string strcon = @"Data Source=khiemmini\SQLEXPRESS;Initial Catalog=QuanLyDiemTheoMonHoc;Integrated Security=True";
        SqlDataAdapter sqlAdap;
        DataTable dt;
        private void chonmon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chonmon.SelectedValue == null) return;

           
            if (!(chonmon.SelectedValue is int)) return;

            int subjectID = (int)chonmon.SelectedValue;

            DataView dv = new DataView(dt);
            dv.RowFilter = $"SubjectID = {subjectID}";

            dataGridView1.DataSource = dv;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            sqlAdap = new SqlDataAdapter("SELECT * FROM Result", strcon);
            SqlCommandBuilder builder = new SqlCommandBuilder(sqlAdap);
            dt = new DataTable();
            sqlAdap.Fill(dt);
            dataGridView1.DataSource = dt;

          
            SqlDataAdapter daSubject = new SqlDataAdapter(
                "SELECT SubjectID, SubjectName FROM Subject", strcon);

            DataTable dtSubject = new DataTable();
            daSubject.Fill(dtSubject);

            chonmon.DisplayMember = "SubjectName"; 
            chonmon.ValueMember = "SubjectID";     
            chonmon.DataSource = dtSubject;

        }

        private void them_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["StudentName"] = nameee.Text;
            dr["Score"] = score.Text;
            dr["SubjectID"] = subjectid.Text;

            dt.Rows.Add(dr);
            sqlAdap.Update(dt);
            MessageBox.Show("Thêm thành công");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            id.Text = dataGridView1.Rows[e.RowIndex].Cells["ResultID"].Value.ToString();
            score.Text = dataGridView1.Rows[e.RowIndex].Cells["Score"].Value.ToString();
            nameee.Text = dataGridView1.Rows[e.RowIndex].Cells["StudentName"].Value.ToString();
            subjectid.Text = dataGridView1.Rows[e.RowIndex].Cells["SubjectID"].Value.ToString();

        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int indexx = dataGridView1.CurrentRow.Index;

            dt.Rows[indexx]["ResultID"] = id.Text.Trim();
            dt.Rows[indexx]["StudentName"] = nameee.Text.Trim();
            dt.Rows[indexx]["Score"] = score.Text.Trim();
            dt.Rows[indexx]["SubjectID"] = subjectid.Text.Trim();
           
            sqlAdap.Update(dt);
        }

        private void xoadiem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không ?","Xóa",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (dataGridView1.CurrentRow.DataBoundItem is DataRowView drv)
            {
                drv.Row.Delete();  
                sqlAdap.Update(dt);
                MessageBox.Show("Đã xóa thành công");
            }
        }

        private void thongke_Click(object sender, EventArgs e)
        {
            if (!(chonmon.SelectedValue is int subjectID))
            {
                MessageBox.Show("Vui lòng chọn môn");
                return;
            }

            DataView dv = new DataView(dt);
            dv.RowFilter = $"SubjectID = {subjectID}";

           

            int dat = 0, khongDat = 0, tongDiem = 0;

            foreach (DataRowView row in dv)
            {
                int score = Convert.ToInt32(row["Score"]);
                tongDiem += score;

                if (score >= 5)
                    dat++;
                else
                    khongDat++;
            }

            double diemTB = (double)tongDiem / dv.Count;

            MessageBox.Show(
                $"Môn: {chonmon.Text}\n" +
                $"ĐẠT (>=5): {dat}\n" +
                $"KHÔNG ĐẠT (<5): {khongDat}\n" +
                $"Điểm trung bình: {diemTB:F2}",
                "Thống kê môn",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
