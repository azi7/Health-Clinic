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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Btn_show_Click(object sender, EventArgs e)
        {
            ReservationDetailes f = new ReservationDetailes();
            f.ShowDialog();
        }

        private void Btn_addreservation_Click(object sender, EventArgs e)
        {
            Reservation f = new Reservation();
            f.ShowDialog();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            DBTables f = new DBTables();
            f.ShowDialog();
        }
    }
}
