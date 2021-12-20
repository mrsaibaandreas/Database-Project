
namespace SangriaHealthCenter
{
    partial class Form3
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
            this.StaffId = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StaffId
            // 
            this.StaffId.Location = new System.Drawing.Point(38, 61);
            this.StaffId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StaffId.Name = "StaffId";
            this.StaffId.Size = new System.Drawing.Size(162, 20);
            this.StaffId.TabIndex = 0;
            this.StaffId.TextChanged += new System.EventHandler(this.StaffId_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(38, 103);
            this.password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(162, 20);
            this.password.TabIndex = 1;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(142, 137);
            this.login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(56, 23);
            this.login.TabIndex = 2;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(36, 45);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(43, 13);
            this.IdLabel.TabIndex = 3;
            this.IdLabel.Text = "Staff ID";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(36, 87);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 191);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.StaffId);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StaffId;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label PasswordLabel;
    }
}