namespace ProjectWF
{
    partial class Form2
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_addreservation = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_table = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_exit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(334, 392);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(132, 56);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // btn_addreservation
            // 
            this.btn_addreservation.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_addreservation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addreservation.Location = new System.Drawing.Point(334, 163);
            this.btn_addreservation.Name = "btn_addreservation";
            this.btn_addreservation.Size = new System.Drawing.Size(132, 55);
            this.btn_addreservation.TabIndex = 6;
            this.btn_addreservation.Text = "Add a reservation";
            this.btn_addreservation.UseVisualStyleBackColor = false;
            this.btn_addreservation.Click += new System.EventHandler(this.Btn_addreservation_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_show.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.Location = new System.Drawing.Point(334, 38);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(132, 55);
            this.btn_show.TabIndex = 5;
            this.btn_show.Text = "Show reservations";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.Btn_show_Click);
            // 
            // btn_table
            // 
            this.btn_table.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_table.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_table.Location = new System.Drawing.Point(334, 273);
            this.btn_table.Name = "btn_table";
            this.btn_table.Size = new System.Drawing.Size(132, 55);
            this.btn_table.TabIndex = 8;
            this.btn_table.Text = "Tables";
            this.btn_table.UseVisualStyleBackColor = false;
            this.btn_table.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(769, 525);
            this.Controls.Add(this.btn_table);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_addreservation);
            this.Controls.Add(this.btn_show);
            this.Name = "Form2";
            this.Text = "Program services";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_addreservation;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_table;
    }
}