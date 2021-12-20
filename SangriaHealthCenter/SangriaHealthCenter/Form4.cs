using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace SangriaHealthCenter
{
    public partial class Form4 : Form
    {
        private MySqlConnection cnn;
        public Form4(String query, MySqlConnection con)
        {
            cnn = con;
            InitializeComponent();
            CreateMySqlDataReader(query);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void CreateMySqlDataReader(String query)
        {
            MySqlCommand myCommand = new MySqlCommand(query, cnn);
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                for (int i = 0; i < myReader.FieldCount; i++)
                {
                    dataGridView2.Columns.Add(myReader.GetName(i),
                                                myReader.GetName(i));
                }

                while (myReader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                    for (int i = 0; i < myReader.FieldCount; i++) //nr of cols
                    {
                        row.Cells[i].Value = myReader.GetValue(i);
                    }
                    dataGridView2.Rows.Add(row);
                }
            }
            finally
            {
                myReader.Close();
                cnn.Close();
            }
        }
    }
}
