using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Funcionario func = new Funcionario();

        private void button1_Click(object sender, EventArgs e)
        {
            //Read and Set data
            func.setNome(txt_nome.Text);
            func.setRg(txt_rg.Text);
            func.setCartao(txt_cartao.Text);
            //Get and Show data
            lbl_nome.Text = func.getNome();
            lbl_rg.Text = func.getRg();
            lbl_cartao.Text = func.getCartao();
        }
    }
}
