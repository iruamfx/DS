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
        Authentication auth = new Authentication();

        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_acesso_Click(object sender, EventArgs e)
        {
            auth.setUser(txt_user.Text);
            auth.setPass(txt_password.Text);

            int res = auth.authLogin();

            if(res == 1)
            {
                frm_index index = new frm_index();
                index.Show();
                this.Hide();
            }
            //else if(txt_user.Text == "admin" && txt_password.Text == "admin")
            //{
                //Não necessário
            //}
            else
            {
                MessageBox.Show("Usuário ou Senha Invalida", "Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo sair?", "Steam Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
