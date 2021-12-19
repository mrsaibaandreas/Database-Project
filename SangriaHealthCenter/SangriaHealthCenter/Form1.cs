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
        public Form1()
        {
            InitializeComponent();
          

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        static string connetionString = "server=localhost;database=db_test;uid=root;pwd=example;";

        static MySqlConnection cnn = new MySqlConnection(connetionString);

        private void connect_Click(object sender, EventArgs e)
        {
           /* string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=db_test;uid=root;pwd=example;";
            cnn = new MySqlConnection(connetionString);*/
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open!");

                Queries Q = new Queries();
                MySqlCommand dropTables, createTables, createFKs, populateTables;

                dropTables = new MySqlCommand(Q.DropTables(), cnn);                
                createTables = new MySqlCommand(Q.InitTablesQueries(), cnn);
                createFKs = new MySqlCommand(Q.InitFKs(), cnn);
                populateTables = new MySqlCommand(Q.populateTables(), cnn);

                createTables.ExecuteNonQuery();
                createFKs.ExecuteNonQuery();
                populateTables.ExecuteNonQuery();

                //dropTables.ExecuteNonQuery();   //DELETING TABLES FOR TESTING PURPUOSES ONLY
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex);
            }
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
