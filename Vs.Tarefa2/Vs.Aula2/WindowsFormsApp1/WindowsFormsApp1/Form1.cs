using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            //Checar o preencimento da hora de partida.
            if (txt_hp.Text.Length == 0)
            {
                MessageBox.Show("Favor indicar a hora de partida da Vôo.", "Partida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_hp.Clear();
                txt_hp.Focus();
                return;
            }
            int hp = Convert.ToInt32(txt_hp.Text);

            //Checar se a hora está etre 0 e 23.
            if (hp < 0 || hp > 23)
            {
                MessageBox.Show("Favor digitar valores entre 0 e 23.", "Partida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_hp.Clear();
                txt_hp.Focus();
                return;
            }
            //Checar o preencimento do minuto de partida.
            if (txt_mp.Text.Length == 0)
            {
                MessageBox.Show("Favor indicar o minuto de partida da Vôo.", "Partida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_mp.Clear();
                txt_mp.Focus();
                return;
            }
            int mp = Convert.ToInt32(txt_mp.Text);

            //Checar se a hora está etre 0 e 59.
            if (mp < 0 || mp > 59)
            {
                MessageBox.Show("Favor digitar valores entre 0 e 59.", "Partida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_mp.Clear();
                txt_mp.Focus();
                return;
            }
            //Checar o preencimento da hora de duração.
            if (txt_hd.Text.Length == 0)
            {
                MessageBox.Show("Favor indicar a hora de duração do Vôo.", "Duração",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_hd.Clear();
                txt_hd.Focus();
                return;
            }
            int hd = Convert.ToInt32(txt_hd.Text);

            //Checar se a hora está etre 0 e 23.
            if (hd < 0 || hd > 23)
            {
                MessageBox.Show("Favor digitar valores entre 0 e 23.", "Partida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_hd.Clear();
                txt_hd.Focus();
                return;
            }
            //Checar o preencimento do minuto de duração.
            if (txt_md.Text.Length == 0)
            {
                MessageBox.Show("Favor indicar o minuto de partida da Vôo.", "Partida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_md.Clear();
                txt_md.Focus();
                return;
            }
            int md = Convert.ToInt32(txt_md.Text);

            //Checar se a hora está etre 0 e 59.
            if (md < 0 || md > 59)
            {
                MessageBox.Show("Favor digitar valores entre 0 e 59.", "Partida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_md.Clear();
                txt_md.Focus();
                return;
            }

            //Calcular tempo de Voo.

            int hc = (hp + hd);
            int mc = (mp + md);

            if (mc > 59)
            {
                hc++;
                mc -= 60;
            }

            if (hc > 23)
            {
                hc -= 24;
                lbl_situacao.Text = "O voo chegou no dia seguinte";
            }
            else
            {
                lbl_situacao.Text = "O voo chegou no mesmo dia.";
            }

            lbl_hc.Text = hc.ToString();
            lbl_mc.Text = mc.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_hp.Clear();
            txt_mp.Clear();
            txt_hd.Clear();
            txt_md.Clear();
            lbl_hc.ResetText();
            lbl_mc.ResetText();
            lbl_situacao.ResetText();
        }
    }
}
