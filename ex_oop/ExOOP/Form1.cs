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

namespace ExOOP
{
    public partial class Form1 : Form
    {

        operacoes_matematicas mathop;
        SoundPlayer soundplayer = new SoundPlayer(ExOOP.Properties.Resources.shedontmind);
        bool isPlaying = true;

        int n1, n2;

        public Form1()
        {
            InitializeComponent();
            mathop = new operacoes_matematicas();
            soundplayer.Play();
        }

        private void btn_somar_Click(object sender, EventArgs e)
        {
            /* operacoes_matematicas é o nome da classe
               mathop é o nome do objeto
               new operacoes_matematicas é a criação do construtor da classe.
            */
            n1 = int.Parse(txt_num1.Text);
            n2 = int.Parse(txt_num2.Text);
            txt_resultado.Text = ""+mathop.sumXY(n1, n2);
        }

        private void btn_subtract_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(txt_num1.Text);
            n2 = int.Parse(txt_num2.Text);
            txt_resultado.Text = "" + mathop.subtractXY(n1, n2);
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(txt_num1.Text);
            n2 = int.Parse(txt_num2.Text);
            txt_resultado.Text = "" + mathop.divideXY(n1, n2);
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(txt_num1.Text);
            n2 = int.Parse(txt_num2.Text);
            txt_resultado.Text = "" + mathop.multiplyXY(n1, n2);
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                soundplayer.Stop();
                isPlaying = !isPlaying;
            }else
            {
                soundplayer.Play();
                isPlaying = !isPlaying;
            }
        }
    }
}
