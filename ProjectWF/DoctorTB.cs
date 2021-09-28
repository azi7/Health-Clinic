using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWF
{
    public partial class DoctorTB : Form
    {
        public DoctorTB()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string sql = "select * from DoctorTB";
            DataTable dt = DataAccess.GetManyRowsColumns(sql);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            if (dataGridView1.Rows.Count - 1 > 0)
            {
                int ind = dataGridView1.CurrentRow.Index;
                textBox1.Text = dataGridView1.Rows[ind].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[ind].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[ind].Cells[2].Value.ToString();
            }
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = dataGridView1.CurrentRow.Index;
            if (dataGridView1.Rows.Count - 1 > 0)
            {
                textBox1.Text = dataGridView1.Rows[ind].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[ind].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[ind].Cells[2].Value.ToString();
            }
        }

        private void Updateclick_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty && textBox3.Text == string.Empty)
            {
                MessageBox.Show("Fill all text");
                return;
            }
            else
            {
                string sql = "update DoctorTB set dr_Name= '" + textBox2.Text + "' where dr_ID='" + textBox1.Text + "'"+ "update DoctorTB set d_num= '" + textBox3.Text + "' where dr_ID='" + textBox1.Text + "'";
                int rows = DataAccess.InsertUPdateDelete(sql);


                string sql1 = "select * from DoctorTB";
                DataTable dt1 = DataAccess.GetManyRowsColumns(sql1);
                if (dt1.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt1;
                }
                if (dataGridView1.Rows.Count - 1 > 0)
                {

                    int ind = dataGridView1.CurrentRow.Index;
                    textBox1.Text = dataGridView1.Rows[ind].Cells[0].Value.ToString();
                    textBox2.Text = dataGridView1.Rows[ind].Cells[1].Value.ToString();
                    textBox3.Text = dataGridView1.Rows[ind].Cells[2].Value.ToString();
                }
                MessageBox.Show("Update is done");
            }
        }

        private void Deleteclick_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty && textBox3.Text == string.Empty)
            {
                MessageBox.Show("choose element");
                return;
            }
            else
            {
                string sql = "Delete from  DoctorTB  where dr_ID='" + textBox1.Text + "'";
                int rows = DataAccess.InsertUPdateDelete(sql);

                string sql1 = "select * from DoctorTB";
                DataTable dt1 = DataAccess.GetManyRowsColumns(sql1);
                if (dt1.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt1;
                }
                int ind = dataGridView1.CurrentRow.Index;
                if (dataGridView1.Rows.Count - 1 > 0)
                {
                    textBox1.Text = dataGridView1.Rows[ind].Cells[0].Value.ToString();
                    textBox2.Text = dataGridView1.Rows[ind].Cells[1].Value.ToString();
                    textBox3.Text = dataGridView1.Rows[ind].Cells[2].Value.ToString();
                }
                MessageBox.Show("Delete is done");
            }
        }

        private void Newbtn_Click_1(object sender, EventArgs e)
        {
            string sql = "select dr_ID from DoctorTB ";
            DataTable dt = DataAccess.GetManyRowsColumns(sql);
            if (dt.Rows.Count >= 0)
            {
                textBox1.Text = (dt.Rows.Count + 101).ToString();
            }
            else
            {
                textBox1.Text = "";
            }
            textBox2.Text = "";
            textBox3.Text = "";
            addbtn.Visible = true;
            newbtn.Visible = false;
        }

        private void Addbtn_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty && textBox3.Text == string.Empty)
            {
                MessageBox.Show("Fill all text");
                return;
            }
            else
            {
                string sql2 = "select * from DoctorTB where dr_ID='" + textBox1.Text + "'";
                DataTable dt2 = DataAccess.GetManyRowsColumns(sql2);
                if (dt2.Rows.Count == 0)
                {
                    string sql1 = "Insert into DoctorTB values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                    int rows1 = DataAccess.InsertUPdateDelete(sql1);
                    if (rows1 == 0)
                    {
                        MessageBox.Show("No record registered");
                    }

                    string sql = "select * from DoctorTB";
                    DataTable dt = DataAccess.GetManyRowsColumns(sql);
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    if (dataGridView1.Rows.Count - 1 > 0)
                    {
                        int ind = dataGridView1.CurrentRow.Index;
                        textBox1.Text = dataGridView1.Rows[ind].Cells[0].Value.ToString();
                        textBox2.Text = dataGridView1.Rows[ind].Cells[1].Value.ToString();
                        textBox3.Text = dataGridView1.Rows[ind].Cells[2].Value.ToString();
                    }
                    newbtn.Visible = true;
                    addbtn.Visible = false;
                    MessageBox.Show("Add is done");
                }
            }
        }
    }
}
