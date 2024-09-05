using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Car car = new Car();

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                car.setPlate(txt_plate.Text);
                car.setModel(txt_model.Text);
                car.setColor(txt_color.Text);
                car.Insert();
                dataGridView1.DataSource = car.Query();

                dataGridView1.Columns["id"].HeaderText = "Codigo";
                dataGridView1.Columns["model"].HeaderText = "Modelo";
                dataGridView1.Columns["plate"].HeaderText = "Placa";
                dataGridView1.Columns["color"].HeaderText = "Cor";
            }
            //catch
            //{
            //    MessageBox.Show("Ocorreu um erro ao gravar as informações");
            //}
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = car.Query();

            dataGridView1.Columns["id"].HeaderText = "Codigo";
            dataGridView1.Columns["model"].HeaderText = "Modelo";
            dataGridView1.Columns["plate"].HeaderText = "Placa";
            dataGridView1.Columns["color"].HeaderText = "Cor";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                car.setId(txt_id.Text);
                car.Delete();
                dataGridView1.DataSource = car.Query();

                dataGridView1.Columns["id"].HeaderText = "Codigo";
                dataGridView1.Columns["model"].HeaderText = "Modelo";
                dataGridView1.Columns["plate"].HeaderText = "Placa";
                dataGridView1.Columns["color"].HeaderText = "Cor";
            }
            finally {
                MessageBox.Show("Informações apagadas com sucesso");
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            try
            {
                car.setId(txt_id.Text);
                car.setPlate(txt_plate.Text);
                car.setModel(txt_model.Text);
                car.setColor(txt_color.Text);
                car.Update();
                dataGridView1.DataSource = car.Query();

                dataGridView1.Columns["id"].HeaderText = "Codigo";
                dataGridView1.Columns["model"].HeaderText = "Modelo";
                dataGridView1.Columns["plate"].HeaderText = "Placa";
                dataGridView1.Columns["color"].HeaderText = "Cor";
            }
            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            txt_plate.Text = "";
            txt_model.Text = "";
            txt_id.Text = "";
            txt_color.Text = "";
        }

        public void showDataTable(int index)
        {
            txt_id.Text = " " + dataGridView1[0, index].Value;
            txt_model.Text = " " + dataGridView1[1, index].Value;
            txt_plate.Text = " " + dataGridView1[2, index].Value;
            txt_color.Text = " " + dataGridView1[3, index].Value;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            showDataTable(dataGridView1.CurrentRow.Index);
        }
    }
}
