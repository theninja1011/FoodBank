﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodBank
{
    public partial class Form1 : Form
    {
        public List<People> P { get; set; }
        

        public Form1()
        {
            P = GetPerson();
            InitializeComponent();
        }

        private List<People> GetPerson()
        {
            var list = new List<People>();
            list.Add(new People()
            {
                FirstName = "Joe",
                LastName = "Mama",
                Address = "The Place",
                County = "There",
                Household = 12,
                Income = 12000
            });

            return list;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var p = this.P;
            dataGridView1.DataSource = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
