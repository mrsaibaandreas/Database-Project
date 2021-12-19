using MySqlConnector;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SangriaHealthCenter
{
    class LoginQueries
    {
        private String _id;
        private String _password;

        private static  String CheckIdFromDbQuery =
            "SELECT u_id, password FROM Users JOIN MedicalStaff ON MedicalStaff.m_id = Users.medicalStaff WHERE Users.u_id = ";
        private static String CheckPassFromDbQuery = " AND Users.password = ";
        
        public LoginQueries(String id, String password)
        {
            this._id = id;
            this._password = CalculateMD5Hash(password);
          
        }

        public bool CheckUserAndPassword(MySqlConnection cnn)
        {

                String TempId, TempPass;
                String check = CheckIdFromDbQuery + "'" + this._id + "'" + CheckPassFromDbQuery + "'" + this._password + "'" + ";";

           
                MySqlCommand checkIdAndPass = new MySqlCommand(check, cnn);

                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
           

                MySqlDataReader rdr = null;

                 Console.WriteLine(check);
                rdr = checkIdAndPass.ExecuteReader();

                while (rdr.Read())
                {
                    TempId = rdr["u_id"].ToString();
                    TempPass = rdr["password"].ToString();
                    if (TempPass == this._password && TempId == this._id)
                    {
                        MessageBox.Show("Acces granted");
                        return true;
                    }
                    else
                        return false;
                }
            MessageBox.Show("NOT");
                return false;
           
        }
        
        private static string CalculateMD5Hash(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);

            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();

        }
    }
}
