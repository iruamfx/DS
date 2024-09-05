using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_encapsulamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Aluno aluno = new Aluno();

        private void btn_set_Click(object sender, EventArgs e)
        {
            aluno.setNome(txt_nome.Text);
            aluno.setCPF(txt_cpf.Text);
        }
        private void btn_get_Click(object sender, EventArgs e)
        {
            lbl_mostrar_nome.Text = aluno.getNome();
            lbl_mostrar_cpf.Text = aluno.getCPF();
        }
    }
}
