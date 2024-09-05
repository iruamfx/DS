using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_struct
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_acesso_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string password = "123";

            if(txt_user.Text == user && txt_password.Text == password)
            {
                frm_index form3 = new frm_index();
                form3.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Usuario ou Senha invalido");
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você quer mesmo sair??", "Windows 6", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
