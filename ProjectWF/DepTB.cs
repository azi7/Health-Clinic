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
    public partial class DepTB : Form
    {
        public DepTB()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string sql = "select * from DepTB";
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
            }
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count - 1 > 0)
            {

                int ind = dataGridView1.CurrentRow.Index;
                textBox1.Text = dataGridView1.Rows[ind].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[ind].Cells[1].Value.ToString();
            }
        }


        private void Addbtn_Click(object sender, EventArgs e)
        {
            
                if (textBox1.Text == string.Empty && textBox2.Text == string.Empty)
                {
                    MessageBox.Show("Fill all text");
                    return;
                }
                else
                {
                    string sql2 = "select * from DepTB where d_num='" + textBox1.Text + "'";
                    DataTable dt2 = DataAccess.GetManyRowsColumns(sql2);
                    if (dt2.Rows.Count == 0)
                    {
                        string sql1 = "Insert into DepTB values('" + textBox1.Text + "','" + textBox2.Text + "')";
                        int rows1 = DataAccess.InsertUPdateDelete(sql1);
                        if (rows1 == 0)
                        {
                            MessageBox.Show("No record registered");
                        }

                        string sql = "select * from DepTB";
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
                        }
                        newbtn.Visible = true;
                        addbtn.Visible = false;
                        MessageBox.Show(" Add a new Clinic is done");
                    }
                }
        }

        private void Newbtn_Click(object sender, EventArgs e)
        {
            string sql = "select d_num from DepTB ";
            DataTable dt = DataAccess.GetManyRowsColumns(sql);
            if (dt.Rows.Count >= 0)
            {
                textBox1.Text = (dt.Rows.Count + 1).ToString();
            }
            else
            {
                textBox1.Text = "1";
            }

            textBox2.Text = "";
            addbtn.Visible = true;
            newbtn.Visible = false;
        }

        private void Updateclick_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty)
            {
                MessageBox.Show("Fill all text");
                return;
            }
            else
            {
                string sql = "update DepTB set d_name= '" + textBox2.Text + "' where d_num='" + textBox1.Text + "'";
                int rows = DataAccess.InsertUPdateDelete(sql);


                string sql1 = "select * from DepTB";
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
                }
                MessageBox.Show("Update is done");
            }
        }

        private void Deleteclick_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty)
            {
                MessageBox.Show("choose element");
                return;
            }
            else
            {
                string sql = "Delete from  DepTB  where d_num='" + textBox1.Text + "'";
                int rows = DataAccess.InsertUPdateDelete(sql);

                string sql1 = "select * from DepTB";
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
                }
                MessageBox.Show("Delete is done");
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
