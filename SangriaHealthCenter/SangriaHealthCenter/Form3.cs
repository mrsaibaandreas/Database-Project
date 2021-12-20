using MySqlConnector;
using System;
using System.Windows.Forms;

namespace SangriaHealthCenter
{
    public partial class Form3 : Form
    {
       
        public Form3()
        {
           
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public static string connetionString = "server=localhost;database=db_test;uid=root;pwd=example;";

        static MySqlConnection cnn = new MySqlConnection(connetionString);

        private void initDB()
        {
            try
            {
                cnn.Open();

                Queries Q = new Queries();
                MySqlCommand dropTables, createTables, createFKs, populateTables;

                dropTables = new MySqlCommand(Q.DropTables(), cnn);
                createTables = new MySqlCommand(Q.InitTablesQueries(), cnn);
                createFKs = new MySqlCommand(Q.InitFKs(), cnn);
                populateTables = new MySqlCommand(Q.populateTables(), cnn);

                createTables.ExecuteNonQuery();
                createFKs.ExecuteNonQuery();
                populateTables.ExecuteNonQuery();

                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! " + ex);
            }
        }


        private void login_Click(object sender, EventArgs e)
        {
            LoginQueries logIn = new LoginQueries(StaffId.Text, password.Text);
            initDB();
            if (logIn.CheckUserAndPassword(cnn))
            {
                Form1 f1 = new Form1(cnn);
                f1.ShowDialog();
                
            }
        }

        private void StaffId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
