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
    public partial class patientTB : Form
    {
        public patientTB()
        {
            InitializeComponent();
        }

        private void PatientTB_Load(object sender, EventArgs e)
        {
            string sql = "select * from patientTB";
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
                string sql = "update patientTB set p_name= '" + textBox2.Text + "' where p_id='" + textBox1.Text + "'" + "update patientTB set p_email= '" + textBox3.Text + "' where p_id='" + textBox1.Text + "'";
                int rows = DataAccess.InsertUPdateDelete(sql);


                string sql1 = "select * from patientTB";
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
                string sql = "Delete from  patientTB  where p_id='" + textBox1.Text + "'";
                int rows = DataAccess.InsertUPdateDelete(sql);

                string sql1 = "select * from patientTB";
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

        private void Newbtn_Click(object sender, EventArgs e)
        {
            string sql = "select p_id from patientTB ";
            DataTable dt = DataAccess.GetManyRowsColumns(sql);
            if (dt.Rows.Count >= 0)
            {
                textBox1.Text = "";
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            addbtn.Visible = true;
            newbtn.Visible = false;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty && textBox3.Text == string.Empty)
            {
                MessageBox.Show("Fill all text");
                return;
            }
            else
            {
                string sql2 = "select * from patientTB where p_id='" + textBox1.Text + "'";
                DataTable dt2 = DataAccess.GetManyRowsColumns(sql2);
                if (dt2.Rows.Count == 0)
                {
                    string sql1 = "Insert into patientTB values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                    int rows1 = DataAccess.InsertUPdateDelete(sql1);
                    if (rows1 == 0)
                    {
                        MessageBox.Show("No record registered");
                    }

                    string sql = "select * from patientTB";
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
                    MessageBox.Show(" Add is done");
                }
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
