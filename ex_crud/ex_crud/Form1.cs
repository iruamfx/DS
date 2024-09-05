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

        Colaborador colab = new Colaborador();

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                colab.setCpf(txt_cpf.Text);
                colab.setNome(txt_nome.Text);
                colab.setSobrenome(txt_sobrenome.Text);
                colab.Insert();
                dataGridView1.DataSource = colab.Query();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = colab.Query();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                colab.setCodigo(txt_codigo.Text);
                colab.Delete();
                dataGridView1.DataSource = colab.Query();
            }
            finally {
                MessageBox.Show("Informações apagadas com sucesso");
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            try
            {
                colab.setCodigo(txt_codigo.Text);
                colab.setCpf(txt_cpf.Text);
                colab.setNome(txt_nome.Text);
                colab.setSobrenome(txt_sobrenome.Text);
                colab.Update();
                dataGridView1.DataSource = colab.Query();
            }
            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
        }
    }
}
