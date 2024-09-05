using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Empregado e = null;

        private void btn_verificar_Click(object sender, EventArgs evArgs)
        {
            if(rdb_assalariado.Checked)
            {
                e = new Assalariado();
                double t;
                t = 0;
                lbl_vencimento.Text = e.vencimento(t).ToString();
            }
            else if (rdb_assalariado.Checked)
            {
                e = new Comissionado();
                double t;
                t = 0;
                lbl_vencimento.Text = e.vencimento(t).ToString();
            }
            else if (rdb_horista.Checked)
            {
                e = new Horista();
                double t;
                t = 0;
                lbl_vencimento.Text = e.vencimento(t).ToString();
            }
            //Atividade demonstre as informações digitadas na caixa de texto nome
            //Sobrenome e CPF utilizando set & get. Utilize um botao e demonstre em label ou caixa de texto.
            e.setNome(txt_nome.Text);
            e.setSobrenome(txt_sobrenome.Text);
            e.setCpf(txt_cpf.Text);
            lbl_nome.Text = e.getNome();
            lbl_sobrenome.Text = e.getSobrenome();
            lbl_cpf.Text = e.getCpf();
        }
    }
}
