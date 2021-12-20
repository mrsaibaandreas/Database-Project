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
            Hospitals f2 = new Hospitals(cnn);
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

         private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4("SELECT * FROM MedicalStaff", cnn);
            f4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4("Donors", cnn);
            f4.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4("Donors", cnn);
            f4.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4("Donors", cnn);
            f4.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4("Donors", cnn);
            f4.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(@"SELECT COUNT(p_id), h.name
                                FROM Patients p
                                JOIN Hospital h ON p.hospital = h.h_id
                                WHERE p.emergency = 1
                                GROUP BY h.name
                                HAVING COUNT(p_id) >= 1
                                ORDER BY COUNT(p_id) DESC", cnn);
            f4.ShowDialog();

        }
    }
}
