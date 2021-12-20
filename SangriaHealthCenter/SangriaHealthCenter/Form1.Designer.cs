
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
            this.volunteers = new System.Windows.Forms.Button();
            this.donors = new System.Windows.Forms.Button();
            this.patients = new System.Windows.Forms.Button();
            this.medicalStaff = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.Button();
            this.hospitals = new System.Windows.Forms.Button();
            this.laboratories = new System.Windows.Forms.Button();
            this.bloodBank = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "1. See the bloodbanks that have at least:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(408, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "volunteers on each area.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Run1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "2. See the hospitals that have at least 1 user with acces to the DB.";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(655, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Run2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "3. Are there enough (b, t, p)\r\n\r\n";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(343, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "for patient\r\n";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(514, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "?";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(655, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Run3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "4. How many donors from BloodBank(id required)";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(443, 231);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(550, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "are regular donors?";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(655, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Run4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(273, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "5. Hospitals with inventories that need to be replenished.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(288, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "6. Laboratories with inventories that need to be replenished.\r\n";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(655, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 28;
            this.button5.Text = "Run5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(655, 292);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 29;
            this.button6.Text = "Run6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(200, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(400, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "7. Hospitals with pacients in dire need of blood transfusion.(ordered by no. of c" +
    "ases)";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(655, 326);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 31;
            this.button7.Text = "Run7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.bloodBank);
            this.Controls.Add(this.laboratories);
            this.Controls.Add(this.hospitals);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.medicalStaff);
            this.Controls.Add(this.patients);
            this.Controls.Add(this.donors);
            this.Controls.Add(this.volunteers);
            this.Name = "Form1";
            this.Text = "Overview";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button volunteers;
        private System.Windows.Forms.Button donors;
        private System.Windows.Forms.Button patients;
        private System.Windows.Forms.Button medicalStaff;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Button hospitals;
        private System.Windows.Forms.Button laboratories;
        private System.Windows.Forms.Button bloodBank;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button7;
    }
}

