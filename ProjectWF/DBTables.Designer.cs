namespace ProjectWF
{
    partial class DBTables
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_dept = new System.Windows.Forms.Button();
            this.btn_doctor = new System.Windows.Forms.Button();
            this.btn_patient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_dept
            // 
            this.btn_dept.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_dept.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dept.Location = new System.Drawing.Point(232, 101);
            this.btn_dept.Name = "btn_dept";
            this.btn_dept.Size = new System.Drawing.Size(132, 55);
            this.btn_dept.TabIndex = 11;
            this.btn_dept.Text = "Dep Table";
            this.btn_dept.UseVisualStyleBackColor = false;
            this.btn_dept.Click += new System.EventHandler(this.Btn_dept_Click);
            // 
            // btn_doctor
            // 
            this.btn_doctor.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_doctor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctor.Location = new System.Drawing.Point(232, 269);
            this.btn_doctor.Name = "btn_doctor";
            this.btn_doctor.Size = new System.Drawing.Size(132, 55);
            this.btn_doctor.TabIndex = 12;
            this.btn_doctor.Text = "Doctor Table";
            this.btn_doctor.UseVisualStyleBackColor = false;
            this.btn_doctor.Click += new System.EventHandler(this.Btn_doctor_Click);
            // 
            // btn_patient
            // 
            this.btn_patient.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_patient.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient.Location = new System.Drawing.Point(232, 426);
            this.btn_patient.Name = "btn_patient";
            this.btn_patient.Size = new System.Drawing.Size(132, 55);
            this.btn_patient.TabIndex = 13;
            this.btn_patient.Text = "Patient Table";
            this.btn_patient.UseVisualStyleBackColor = false;
            this.btn_patient.Click += new System.EventHandler(this.Btn_patient_Click);
            // 
            // DBTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(596, 585);
            this.Controls.Add(this.btn_patient);
            this.Controls.Add(this.btn_doctor);
            this.Controls.Add(this.btn_dept);
            this.Name = "DBTables";
            this.Text = "DB Tables";
            this.Load += new System.EventHandler(this.DBTables_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_dept;
        private System.Windows.Forms.Button btn_doctor;
        private System.Windows.Forms.Button btn_patient;
    }
}