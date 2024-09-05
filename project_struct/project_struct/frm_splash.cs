using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace project_struct
{
    public partial class frm_splash : Form
    {
        SoundPlayer bootSp = new SoundPlayer("C://Workspace//DS//project_struct//o95.wav");
        SoundPlayer loadSp = new SoundPlayer("C://Workspace//DS//project_struct//oxp.wav");

        public frm_splash()
        {
            InitializeComponent();
            bootSp.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                frm_login form = new frm_login();
                form.Show();
                loadSp.Play();
                this.Hide();
            }
        }
    }
}
