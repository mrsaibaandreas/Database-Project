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

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=db_test;uid=root;pwd=example;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                MySqlCommand Create_table = new MySqlCommand(@" CREATE TABLE IF NOT EXISTS `123`  (id INT NOT NULL AUTO_INCREMENT, action VARCHAR(15) NOT NULL,  PRIMARY KEY (id)) COLLATE='utf8_general_ci' ENGINE=InnoDB;", cnn);
                MySqlCommand insertValue = new MySqlCommand(@"INSERT INTO `123` (id, action) VALUES(3,'SASA');", cnn);
                Create_table.ExecuteNonQuery();
                insertValue.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    
        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
