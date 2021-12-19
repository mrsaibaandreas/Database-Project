using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SangriaHealthCenter
{
    public partial class Form1 : Form
    {

        private MySqlConnection cnn;
        public Form1(MySqlConnection cnn)
        {
            this.cnn = cnn;
            InitializeComponent();
        }
        private void donors_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2("Donors", cnn);
            f2.ShowDialog();
        }

        private void hospitals_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2("Hospital", cnn);
            f2.ShowDialog();
        }

        private void volunteers_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2("Volunteers", cnn);
            f2.ShowDialog();
        }

        private void bloodBagsOnClick(object sender, EventArgs e)
        {
            Form2 f2 = new Form2("BloodBag", cnn);
            f2.ShowDialog();
        }

        private void patients_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2("Patients", cnn);
            f2.ShowDialog();
        }

        private void laboratories_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2("Laboratory", cnn);
            f2.ShowDialog();
        }

        private void medicalStaff_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2("MedicalStaff", cnn);
            f2.ShowDialog();
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2("Inventory", cnn);
            f2.ShowDialog();
        }

        private void bloodBank_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2("BloodBank", cnn);
            f2.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
