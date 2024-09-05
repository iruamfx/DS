using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zoo_crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Animal animal = new Animal();

        private void btn_save_Click(object sender, EventArgs e)
        {
            animal.setName(txt_name.Text);
            animal.setNutrition(txt_nutri.Text);
            animal.setWeight(Convert.ToDouble(txt_weight.Text));
            animal.setHabitat(txt_habitat.Text);

            animal.Insert();
            dataGridView1.DataSource = animal.Query();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {

        }
    }
}
