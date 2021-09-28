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
    public partial class ReservationDetailes : Form
    {
        public ReservationDetailes()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string sql = "select * from ReservitionTB where r_DATE ='" + DateTime.Now.Date.ToShortDateString() + "'";
            DataTable dt = DataAccess.GetManyRowsColumns(sql);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count - 1 > 0)
            {

                int ind = dataGridView1.CurrentRow.Index;
                rno.Text = dataGridView1.Rows[ind].Cells[0].Value.ToString();
                namee.Text = dataGridView1.Rows[ind].Cells[1].Value.ToString();
                dd.Text = dataGridView1.Rows[ind].Cells[2].Value.ToString();
                idd.Text = dataGridView1.Rows[ind].Cells[3].Value.ToString();

            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string sql = "select * from ReservitionTB where p_ID ='" + textBox1.Text + "' or r_ID ='" + textBox1.Text + "'";
            DataTable dt = DataAccess.GetManyRowsColumns(sql);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }

            if (dataGridView1.Rows.Count - 1 > 0)
            {

                int ind = dataGridView1.CurrentRow.Index;
                rno.Text = dataGridView1.Rows[ind].Cells[0].Value.ToString();
                namee.Text = dataGridView1.Rows[ind].Cells[1].Value.ToString();
                dd.Text = dataGridView1.Rows[ind].Cells[2].Value.ToString();
                idd.Text = dataGridView1.Rows[ind].Cells[3].Value.ToString();
                
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
