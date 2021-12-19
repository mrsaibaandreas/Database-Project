using MySqlConnector;
using System;
using System.Windows.Forms;

namespace SangriaHealthCenter
{
    public partial class Form3 : Form
    {
        private MySqlConnection _cnn;
        public Form3(MySqlConnection cnn)
        {
            this._cnn = cnn;
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            LoginQueries logIn = new LoginQueries(StaffId.Text, password.Text);
            if (logIn.CheckUserAndPassword(_cnn))
                Console.WriteLine("works");
        }

     
    }
}
