using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace ProjectWF
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
            string sql = "select r_ID from ReservitionTB ";
            DataTable dt = DataAccess.GetManyRowsColumns(sql);
            if (dt.Rows.Count > 0)
            {
                txt_sequence.Text = (dt.Rows.Count + 1).ToString();
            }
            else
            {
                txt_sequence.Text = "1";
            }

            string sql1 = "select * from DepTB";
            combo_clinic.DataSource = DataAccess.GetManyRowsColumns(sql1); ;
            combo_clinic.DisplayMember = "d_name";
            combo_clinic.ValueMember = "d_num";
            combo_clinic.Text = "Dentistry";

            string sql2 = "select * from DoctorTB where d_num=1";
            comboBox1.DataSource = DataAccess.GetManyRowsColumns(sql2); ;
            comboBox1.DisplayMember = "dr_Name";
            comboBox1.ValueMember = "dr_ID";
        }
        bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z");
        }
        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_id.Text == string.Empty)
                {
                    MessageBox.Show("Eneter Sick ID");
                    return;
                }
                if (txt_name.Text == string.Empty)
                {
                    MessageBox.Show("Eneter Sick Name");
                    return;
                }
                if (txt_email.Text == string.Empty)
                {
                    MessageBox.Show("Eneter Sick Email");
                    return;
                }
                if (txt_note.Text == string.Empty)
                {
                    MessageBox.Show("Eneter Pathological case");
                    return;
                }


                summarytxt.Text = "Reservation No : " + txt_sequence.Text + "\r\nDate :" + dateTimePicker1.Value.Date.ToString() + "\r\nSick ID :" + txt_id.Text + "\r\nSick Name :" + txt_name.Text + "\r\nSick Email :" + txt_email.Text + "\r\nClinic :" + combo_clinic.Text + "\r\nDoctor :" + comboBox1.Text + "\r\nPathological case :" + txt_note.Text;

                string no = txt_sequence.Text;
                string datt = dateTimePicker1.Value.ToShortDateString();
                string id = txt_id.Text;
                string name = txt_name.Text;
                string eemail = txt_email.Text;
                string cli = combo_clinic.SelectedValue.ToString();
                string doc = comboBox1.SelectedValue.ToString();
                string scase = txt_note.Text;
                string myEmail = "";
                string mypass = "";

                string sql3 = "select * from userTB";
                DataTable dt3 = DataAccess.GetManyRowsColumns(sql3);
                if (dt3.Rows.Count > 0)
                {
                    myEmail = dt3.Rows[0][2].ToString();
                    mypass = dt3.Rows[0][3].ToString();

                }
                string sql2 = "select * from patientTB where p_id='" + id + "'";
                DataTable dt2 = DataAccess.GetManyRowsColumns(sql2);
                if (dt2.Rows.Count == 0)
                {
                    string sql1 = "Insert into patientTB values('" + id + "','" + name + "','" + eemail +"')";
                    int rows1 = DataAccess.InsertUPdateDelete(sql1);
                    if (rows1 == 0)
                    {
                        MessageBox.Show("No record registered");
                    }

                }
                string sql4 = "select * from ReservitionTB where r_ID='" + no + "'";
                DataTable dt4 = DataAccess.GetManyRowsColumns(sql4);
                if (dt4.Rows.Count == 0)
                {
                    string sql = "Insert into ReservitionTB values('" + no + "','" + name + "','" + datt + "','" + id + "','" + scase + "','" + eemail + "')";
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows == 0)
                    {
                        MessageBox.Show("No record registered");
                    }
                    else
                    {
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);
                        SmtpServer.Credentials = new NetworkCredential(myEmail, mypass);
                        SmtpServer.EnableSsl = true;
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress(myEmail);
                        mail.To.Add(eemail);
                        mail.Subject = "Clinic reservation -confirmation";
                        mail.Body = summarytxt.Text;
                        mail.IsBodyHtml = false;
                        SmtpServer.Send(mail);
                        MessageBox.Show("mail Sent");
                        groupBox1.Enabled = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Combo_clinic_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Combo_clinic_DropDownClosed(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(combo_clinic.SelectedValue);
            string sql = "select * from DoctorTB where d_num = '" + no + "'";
            comboBox1.DataSource = DataAccess.GetManyRowsColumns(sql); ;
            comboBox1.DisplayMember = "dr_Name";
            comboBox1.ValueMember = "dr_ID";
        }

        private void Txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_email_Validated(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            var res = IsValidEmail(email);
            if (res == false)
            {
                MessageBox.Show("your email is not correct");
                return;
            }
        }

        private void Txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            summarytxt.Text = "Reservation No : " + txt_sequence.Text + "\r\nDate :" + dateTimePicker1.Value.Date.ToString() + "\r\nSick ID :" + txt_id.Text + "\r\nSick Name :" + txt_name.Text + "\r\nSick Email :" + txt_email.Text + "\r\nClinic :" + combo_clinic.Text + "\r\nDoctor :" + comboBox1.Text + "\r\nPathological case :" + txt_note.Text;

        }
        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            summarytxt.Text = "Reservation No : " + txt_sequence.Text + "\r\nDate :" + dateTimePicker1.Value.Date.ToString() + "\r\nSick ID :" + txt_id.Text + "\r\nSick Name :" + txt_name.Text + "\r\nSick Email :" + txt_email.Text + "\r\nClinic :" + combo_clinic.Text + "\r\nDoctor :" + comboBox1.Text + "\r\nPathological case :" + txt_note.Text;
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            summarytxt.Text = "Reservation No : " + txt_sequence.Text + "\r\nDate :" + dateTimePicker1.Value.Date.ToString() + "\r\nSick ID :" + txt_id.Text + "\r\nSick Name :" + txt_name.Text + "\r\nSick Email :" + txt_email.Text + "\r\nClinic :" + combo_clinic.Text + "\r\nDoctor :" + comboBox1.Text + "\r\nPathological case :" + txt_note.Text;
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            summarytxt.Text = "Reservation No : " + txt_sequence.Text + "\r\nDate :" + dateTimePicker1.Value.Date.ToString() + "\r\nSick ID :" + txt_id.Text + "\r\nSick Name :" + txt_name.Text + "\r\nSick Email :" + txt_email.Text + "\r\nClinic :" + combo_clinic.Text + "\r\nDoctor :" + comboBox1.Text + "\r\nPathological case :" + txt_note.Text;

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_note_KeyPress(object sender, KeyPressEventArgs e)
        {
            summarytxt.Text = "Reservation No : " + txt_sequence.Text + "\r\nDate :" + dateTimePicker1.Value.Date.ToString() + "\r\nSick ID :" + txt_id.Text + "\r\nSick Name :" + txt_name.Text + "\r\nSick Email :" + txt_email.Text + "\r\nClinic :" + combo_clinic.Text + "\r\nDoctor :" + comboBox1.Text + "\r\nPathological case :" + txt_note.Text;
        }

        private void Btn_back_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_sequence_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
