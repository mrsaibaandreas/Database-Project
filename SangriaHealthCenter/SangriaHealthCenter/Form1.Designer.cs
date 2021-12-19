
namespace SangriaHealthCenter
{
    partial class Form1
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
            this.connect = new System.Windows.Forms.Button();
            this.volunteers = new System.Windows.Forms.Button();
            this.donors = new System.Windows.Forms.Button();
            this.patients = new System.Windows.Forms.Button();
            this.medicalStaff = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.Button();
            this.hospitals = new System.Windows.Forms.Button();
            this.laboratories = new System.Windows.Forms.Button();
            this.bloodBank = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.doctorLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(12, 12);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(94, 33);
            this.connect.TabIndex = 0;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // volunteers
            // 
            this.volunteers.Location = new System.Drawing.Point(12, 97);
            this.volunteers.Name = "volunteers";
            this.volunteers.Size = new System.Drawing.Size(94, 26);
            this.volunteers.TabIndex = 1;
            this.volunteers.Text = "Volunteers";
            this.volunteers.UseVisualStyleBackColor = true;
            this.volunteers.Click += new System.EventHandler(this.volunteers_Click);
            // 
            // donors
            // 
            this.donors.Location = new System.Drawing.Point(12, 129);
            this.donors.Name = "donors";
            this.donors.Size = new System.Drawing.Size(94, 26);
            this.donors.TabIndex = 2;
            this.donors.Text = "Donors";
            this.donors.UseVisualStyleBackColor = true;
            this.donors.Click += new System.EventHandler(this.donors_Click);
            // 
            // patients
            // 
            this.patients.Location = new System.Drawing.Point(12, 161);
            this.patients.Name = "patients";
            this.patients.Size = new System.Drawing.Size(94, 26);
            this.patients.TabIndex = 3;
            this.patients.Text = "Patients";
            this.patients.UseVisualStyleBackColor = true;
            this.patients.Click += new System.EventHandler(this.patients_Click);
            // 
            // medicalStaff
            // 
            this.medicalStaff.Location = new System.Drawing.Point(12, 193);
            this.medicalStaff.Name = "medicalStaff";
            this.medicalStaff.Size = new System.Drawing.Size(94, 26);
            this.medicalStaff.TabIndex = 4;
            this.medicalStaff.Text = "Medical Staff";
            this.medicalStaff.UseVisualStyleBackColor = true;
            this.medicalStaff.Click += new System.EventHandler(this.medicalStaff_Click);
            // 
            // inventory
            // 
            this.inventory.Location = new System.Drawing.Point(12, 225);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(94, 26);
            this.inventory.TabIndex = 5;
            this.inventory.Text = "Inventory";
            this.inventory.UseVisualStyleBackColor = true;
            this.inventory.Click += new System.EventHandler(this.inventory_Click);
            // 
            // hospitals
            // 
            this.hospitals.Location = new System.Drawing.Point(12, 257);
            this.hospitals.Name = "hospitals";
            this.hospitals.Size = new System.Drawing.Size(94, 26);
            this.hospitals.TabIndex = 6;
            this.hospitals.Text = "Hospitals";
            this.hospitals.UseVisualStyleBackColor = true;
            this.hospitals.Click += new System.EventHandler(this.hospitals_Click);
            // 
            // laboratories
            // 
            this.laboratories.Location = new System.Drawing.Point(12, 289);
            this.laboratories.Name = "laboratories";
            this.laboratories.Size = new System.Drawing.Size(94, 26);
            this.laboratories.TabIndex = 7;
            this.laboratories.Text = "Laboratories";
            this.laboratories.UseVisualStyleBackColor = true;
            this.laboratories.Click += new System.EventHandler(this.laboratories_Click);
            // 
            // bloodBank
            // 
            this.bloodBank.Location = new System.Drawing.Point(12, 321);
            this.bloodBank.Name = "bloodBank";
            this.bloodBank.Size = new System.Drawing.Size(94, 26);
            this.bloodBank.TabIndex = 8;
            this.bloodBank.Text = "Blood Banks";
            this.bloodBank.UseVisualStyleBackColor = true;
            this.bloodBank.Click += new System.EventHandler(this.bloodBank_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 353);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 26);
            this.button10.TabIndex = 9;
            this.button10.Text = "Blood Bag";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.bloodBagsOnClick);
            // 
            // doctorLogin
            // 
            this.doctorLogin.Location = new System.Drawing.Point(682, 20);
            this.doctorLogin.Name = "doctorLogin";
            this.doctorLogin.Size = new System.Drawing.Size(94, 26);
            this.doctorLogin.TabIndex = 10;
            this.doctorLogin.Text = "Login";
            this.doctorLogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doctorLogin);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.bloodBank);
            this.Controls.Add(this.laboratories);
            this.Controls.Add(this.hospitals);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.medicalStaff);
            this.Controls.Add(this.patients);
            this.Controls.Add(this.donors);
            this.Controls.Add(this.volunteers);
            this.Controls.Add(this.connect);
            this.Name = "Form1";
            this.Text = "Overview";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button volunteers;
        private System.Windows.Forms.Button donors;
        private System.Windows.Forms.Button patients;
        private System.Windows.Forms.Button medicalStaff;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Button hospitals;
        private System.Windows.Forms.Button laboratories;
        private System.Windows.Forms.Button bloodBank;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button doctorLogin;
    }
}

