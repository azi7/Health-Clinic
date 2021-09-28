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
    public partial class DBTables : Form
    {
        public DBTables()
        {
            InitializeComponent();
        }

        private void Btn_dept_Click(object sender, EventArgs e)
        {
            DepTB f = new DepTB();
            f.Show();
        }

        private void Btn_doctor_Click(object sender, EventArgs e)
        {
            DoctorTB f = new DoctorTB();
            f.Show();
        }

        private void Btn_patient_Click(object sender, EventArgs e)
        {
            patientTB f = new patientTB();
            f.Show();
        }

        private void DBTables_Load(object sender, EventArgs e)
        {

        }
    }
}
