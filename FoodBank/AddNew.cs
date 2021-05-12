using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FoodBank
{
    public partial class AddNew : Form
    {
        MainForm main;
        public List<Person> Person { get; set; }

        public AddNew(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void update()
        {
            label1.Text = "Update";
            new_save.Text = "Update";
        }

        public void clear() 
        {
            nametxt.Text = addrtxt.Text = phonetxt.Text = numOfFamBox.Text = incometxt.Text = string.Empty;
            countyBox.SelectedIndex = -1;
        }

        private void new_save_Click(object sender, EventArgs e)
        {
            if (nametxt.Text.Trim().Length < 1) 
            {
                MessageBox.Show("Name is empty");
                return;
            }
            if (addrtxt.Text.Trim().Length < 1)
            {
                MessageBox.Show("Address is empty");
                return;
            }
            if (countyBox.SelectedIndex == -1)
            {
                MessageBox.Show("County not selected");
                return;
            }
            if (phonetxt.Text.Trim().Length < 1)
            {
                MessageBox.Show("Phone is empty");
                return;
            }
            if (numOfFamBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("Family is empty");
                return;
            }
            if (incometxt.Text.Trim().Length < 1)
            {
                MessageBox.Show("Income is empty");
                return;
            }
            if (new_save.Text == "Save")
            {
                int fam = int.Parse(numOfFamBox.Text);
                int income = int.Parse(incometxt.Text);
                List<Person> result = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText("C:/Users/Ninja/source/repos/FoodBank/FoodBank/peeps.json"));
                result.Add(new Person()
                {
                    Date = dateTimePicker1.Value,
                    Name = nametxt.Text.Trim(),
                    Birthday = birthdayPick.Value,
                    NumOfFam = fam,
                    County = countyBox.SelectedItem.ToString(),
                    Address = addrtxt.Text.Trim(),
                    Phone = phonetxt.Text.Trim(),
                    Income = income
                });

                string json = JsonConvert.SerializeObject(result, Formatting.Indented);
                System.IO.File.WriteAllText(@"C:\Users\Ninja\source\repos\FoodBank\FoodBank\peeps.json", json);
                //messagebox for added time before rebinding datasource
                MessageBox.Show("Added Successfully");
                main.dataGridView1.DataSource = result;
                clear();
            }
            if (new_save.Text == "Update") 
            {
                //List<Person> result = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText("C:/Users/Ninja/source/repos/FoodBank/FoodBank/peeps.json"));
            }
        }

        private void AddNew_Load(object sender, EventArgs e)
        {

        }
    }
}
