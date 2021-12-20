﻿using MySqlConnector;
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4("Donors", cnn);
            f4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(@"SELECT h_id FROM Hospital
                                   WHERE h_id IN
                                   (SELECT hospital FROM MedicalStaff ms
                                   JOIN Users u ON    u.medicalStaff = ms.m_id
                                   WHERE EXISTS(SELECT COUNT(*) FROM MedicalStaff WHERE MedicalStaff.m_id = u.medicalStaff)
                                   GROUP BY hospital);", cnn);
            f4.ShowDialog();

        }
        private void button3_Click(object sender, EventArgs e)
        {

            String[] btp = textBox2.Text.Split(',');
            String query = @"SELECT CASE WHEN EXISTS (SELECT * FROM  Patients p WHERE p.p_id =" + textBox3.Text +
            @" AND
            (SELECT COUNT(*) FROM BloodBag b WHERE b.b_group = p.b_group AND b.content = 'b')>=" + btp[0] +
            @" AND
            (SELECT COUNT(*) FROM BloodBag b WHERE b.b_group = p.b_group AND b.content = 't')>=" + btp[1] +
            @" AND
            (SELECT COUNT(*) FROM BloodBag b WHERE b.b_group = p.b_group AND b.content = 'p')>=" + btp[2]+
            ") THEN TRUE ELSE FALSE END AS ans";
            Form4 f4 = new Form4(query, cnn);
            f4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4("Donors", cnn);
            f4.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(@"SELECT h.h_id
                                   FROM Hospital h
                                   JOIN Inventory i ON i.i_id = h.inventory
                                   WHERE
                                   (needles < 5 OR   
                                   vacutainers < 5 OR
                                   gloves < 5 OR    
                                   bloodbags < 5 OR    
                                   tourniquet < 5 OR    
                                   seringe < 5 OR
                                   lancet < 5 OR    
                                   sponges < 5 OR
                                   glucometers < 5 OR
                                   sharps_container < 5)", cnn);
            f4.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(@"SELECT l.l_id
                                   FROM Laboratory l
                                   JOIN Inventory i ON i.i_id = l.inventory
                                   WHERE
                                   (needles < 5 OR
                                   vacutainers < 5 OR
                                   gloves < 5 OR
                                   bloodbags < 5 OR
                                   tourniquet < 5 OR
                                   seringe < 5 OR
                                   lancet < 5 OR
                                   sponges < 5 OR
                                   glucometers < 5 OR
                                   sharps_container < 5)", cnn);
            f4.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4("Donors", cnn);
            f4.ShowDialog();

        }
    }
}
