using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProjectWF
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string sql1 = "select * from userTB where user_ID='" + txt_name.Text + "' and u_pw ='" + txt_pass.Text + "'";
            DataTable dt = DataAccess.GetManyRowsColumns(sql1);

            if (dt.Rows.Count > 0)
            {
                Form2 f = new Form2();
                f.ShowDialog();

            }
            else
                MessageBox.Show("invalid UserName or password");
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txt_pass.PasswordChar = '\0';

            }
            else
            {
                txt_pass.PasswordChar = '*';

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
