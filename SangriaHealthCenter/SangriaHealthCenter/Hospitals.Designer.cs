
namespace SangriaHealthCenter
{
    partial class Hospitals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hospitals));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.RichTextBox();
            this.deleteRowButton = new System.Windows.Forms.Button();
            this.addRowButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seeInventory = new System.Windows.Forms.Button();
            this.updateRowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 104);
            this.label1.TabIndex = 9;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(224, 298);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(321, 96);
            this.textBoxInput.TabIndex = 8;
            this.textBoxInput.Text = "";
            // 
            // deleteRowButton
            // 
            this.deleteRowButton.Location = new System.Drawing.Point(32, 340);
            this.deleteRowButton.Name = "deleteRowButton";
            this.deleteRowButton.Size = new System.Drawing.Size(85, 32);
            this.deleteRowButton.TabIndex = 7;
            this.deleteRowButton.Text = "Delete Row";
            this.deleteRowButton.UseVisualStyleBackColor = true;
            // 
            // addRowButton
            // 
            this.addRowButton.Location = new System.Drawing.Point(32, 301);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(85, 32);
            this.addRowButton.TabIndex = 6;
            this.addRowButton.Text = "Add Row";
            this.addRowButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(776, 271);
            this.dataGridView1.TabIndex = 5;
            // 
            // seeInventory
            // 
            this.seeInventory.Location = new System.Drawing.Point(32, 416);
            this.seeInventory.Name = "seeInventory";
            this.seeInventory.Size = new System.Drawing.Size(85, 32);
            this.seeInventory.TabIndex = 10;
            this.seeInventory.Text = "See Inventory";
            this.seeInventory.UseVisualStyleBackColor = true;
            this.seeInventory.Click += new System.EventHandler(this.seeInventory_Click);
            // 
            // updateRowButton
            // 
            this.updateRowButton.Location = new System.Drawing.Point(32, 378);
            this.updateRowButton.Name = "updateRowButton";
            this.updateRowButton.Size = new System.Drawing.Size(85, 32);
            this.updateRowButton.TabIndex = 11;
            this.updateRowButton.Text = "Update Row";
            this.updateRowButton.UseVisualStyleBackColor = true;
            // 
            // Hospitals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 446);
            this.Controls.Add(this.updateRowButton);
            this.Controls.Add(this.seeInventory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.deleteRowButton);
            this.Controls.Add(this.addRowButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Hospitals";
            this.Text = "Hospitals";
            this.Load += new System.EventHandler(this.Hospitals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textBoxInput;
        private System.Windows.Forms.Button deleteRowButton;
        private System.Windows.Forms.Button addRowButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button seeInventory;
        private System.Windows.Forms.Button updateRowButton;
    }
}