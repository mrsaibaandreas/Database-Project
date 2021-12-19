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
    public partial class Form2 : Form
    {
        private String tableName;
        private MySqlConnection cnn;

        private String table_id;
        public Form2(String table, MySqlConnection con)
        {
            tableName = table;
            cnn = con;
            InitializeComponent();
            CreateMySqlDataReader();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void CreateMySqlDataReader()
        {
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM " + tableName, cnn);
            if(cnn.State == ConnectionState.Closed)
                cnn.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                for (int i = 0; i < myReader.FieldCount; i++)
                {
                    dataGridView1.Columns.Add(myReader.GetName(i),
                                                myReader.GetName(i));
                }
                table_id = myReader.GetName(0);

                while (myReader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();      
                    for (int i = 0; i < myReader.FieldCount; i++) //nr of cols
                    {
                        row.Cells[i].Value = myReader.GetValue(i);
                    }             
                    dataGridView1.Rows.Add(row);
                }
            }
            finally
            {
                myReader.Close();
                cnn.Close();
            }
        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            if(cnn.State == ConnectionState.Closed)
                cnn.Open();
            try
            {
                String add_commands;
                add_commands = parseText(textBoxInput.Text);

                MySqlCommand addRows = new MySqlCommand(add_commands, cnn);
                addRows.ExecuteNonQuery();

                //Console.WriteLine(parseText(textBoxInput.Text));
                textBoxInput.Text = String.Empty;               
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Could not add.\n" + ex.Message);
            }
            finally
            {
                cnn.Close();
            }

        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            try
            {
                String delete_commands;
                delete_commands = @"DELETE FROM " + tableName +
                                    " WHERE " + table_id + " in(" + textBoxInput.Text + ");";

                Console.WriteLine(delete_commands);
                MySqlCommand deleteRows = new MySqlCommand(delete_commands, cnn);
                deleteRows.ExecuteNonQuery();

                textBoxInput.Text = String.Empty;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Could not delete. " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
    
        }

        private String parseText(String input)
        {
            String builder = "INSERT INTO " + tableName + " VALUES ";
            String[] commands = input.Split(';');
            
            foreach(String command in commands)
            {
                String aux = String.Empty;
                String[] values = command.Split(',');
                foreach(String value in values)
                {
                    aux += "'" + value + "',";
                }
                aux = aux.Remove(aux.Length-1,1);

                builder += "("+ aux + "),";
            }
            builder = builder.Remove(builder.Length-1,1);
            builder += ";";
            //Console.WriteLine(builder);
            return builder;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
