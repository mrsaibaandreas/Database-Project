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
    public partial class Hospitals : Form
    {
        private MySqlConnection cnn;
        private String table_id;
        public Hospitals(MySqlConnection cnn)
        {
            this.cnn = cnn;
            InitializeComponent();
            CreateMySqlDataReader();
        }

        private void CreateMySqlDataReader()
        {
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM Hospital", cnn);
            if (cnn.State == ConnectionState.Closed)
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
                    for (int i = 0; i < myReader.FieldCount; i++) 
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
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            try
            {
                String add_commands;
                add_commands = parseText(textBoxInput.Text);

                MySqlCommand addRows = new MySqlCommand(add_commands, cnn);
                addRows.ExecuteNonQuery();

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
                delete_commands = @"DELETE FROM " + "Hospital" +
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


        private void updateRowButton_Click(object sender, EventArgs e)
        {
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            try
            {
                String update_commands;
                update_commands = parseText_update(textBoxInput.Text);

                MySqlCommand updateRows = new MySqlCommand(update_commands, cnn);
                updateRows.ExecuteNonQuery();

                textBoxInput.Text = String.Empty;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Could not update.\n" + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }
        private String parseText_update(String input)
        {
            String builder = "UPDATE " + "Hospital" + " SET ";
            String[] commandsAndConditions = input.Split(';');
            String[] commands = commandsAndConditions[0].Split(',');
            String[] conditions = commandsAndConditions[1].Split(',');

            foreach (String command in commands)
            {
                String[] values = command.Split('=');
                builder += values[0] + " = '" + values[1] + "',";
            }
            builder = builder.Remove(builder.Length - 1, 1);
            builder += " WHERE ";

            foreach (String command in conditions)
            {
                String[] values = command.Split('=');
                builder += values[0] + " = '" + values[1] + "',";
            }
            builder = builder.Remove(builder.Length - 1, 1);
            builder += ";";
            Console.WriteLine(builder);
            return builder;
        }

        private String parseText(String input)
        {
            String builder = "INSERT INTO " + "Hospital" + " VALUES ";
            String[] commands = input.Split(';');

            foreach (String command in commands)
            {
                String aux = String.Empty;
                String[] values = command.Split(',');
                foreach (String value in values)
                {
                    aux += "'" + value + "',";
                }
                aux = aux.Remove(aux.Length - 1, 1);

                builder += "(" + aux + "),";
            }
            builder = builder.Remove(builder.Length - 1, 1);
            builder += ";";
            return builder;
        }

        private void seeInventory_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this.cnn,textBoxInput.Text);    
            f2.ShowDialog();
        }

        private void Hospitals_Load(object sender, EventArgs e)
        {

        }
    }
}
