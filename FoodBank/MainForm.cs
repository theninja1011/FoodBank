using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FoodBank
{
    public partial class MainForm : Form
    {
        AddNew other;
        public MainForm()
        {
            InitializeComponent();
            other = new AddNew(this);
        }
        private void addNew_Click(object sender, EventArgs e)
        {
            AddNew form = new AddNew(this);
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Person> result = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText("C:/Users/Ninja/source/repos/FoodBank/FoodBank/peeps.json"));
            dataGridView1.DataSource = result;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                other.clear();
                other.update();
                other.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure you want to Delete?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) 
                {
                    List<Person> result = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText("C:/Users/Ninja/source/repos/FoodBank/FoodBank/peeps.json"));

                    //The long journey of finding and removing the entry in the list
                    var boi = result;
                    boi.Remove((Person)boi.Single(r => r.Name == dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()));

                    //writing the new list back into the json
                    string json = JsonConvert.SerializeObject(result, Formatting.Indented);
                    System.IO.File.WriteAllText(@"C:\Users\Ninja\source\repos\FoodBank\FoodBank\peeps.json", json);

                    //message box for confirmation and added time
                    MessageBox.Show("Deleted Successfully");
                    dataGridView1.DataSource = result;
                }
                return;
            }

        }
    }
}
