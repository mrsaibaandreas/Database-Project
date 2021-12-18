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

        private void connect_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=db_test;uid=root;pwd=example;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open!");

                Queries Q = new Queries();
                MySqlCommand dropTables, createTables, createFKs;
                dropTables = new MySqlCommand(Q.DropTables(), cnn);
                

                createTables = new MySqlCommand(Q.InitTablesQueries(), cnn);
                createFKs = new MySqlCommand(Q.InitFKs(), cnn);

                createTables.ExecuteNonQuery();
                createFKs.ExecuteNonQuery();

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

        }
    
        private void hospitals_Click(object sender, EventArgs e)
        {

        }

        private void volunteers_Click(object sender, EventArgs e)
        {

        }

        private void bloodReserves_Click(object sender, EventArgs e)
        {

        }

        private void patients_Click(object sender, EventArgs e)
        {

        }

        private void laboratories_Click(object sender, EventArgs e)
        {

        }

        private void medicalStaff_Click(object sender, EventArgs e)
        {

        }

        private void inventory_Click(object sender, EventArgs e)
        {

        }

        private void bloodBank_Click(object sender, EventArgs e)
        {

        }
    }
}
