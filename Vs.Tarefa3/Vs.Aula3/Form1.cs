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

        private void btn_jogar_Click(object sender, EventArgs e)
        {
            int pontuacaoJogador = Convert.ToInt32(txt_jogador.Text);
            int pontuacaoComp = Convert.ToInt32(txt_Computador.Text);

            if (rbtn_pedra.Checked)
            {
                txt_escjogador.Text = "Pedra";
            }
            if (rbtn_papel.Checked)
            {
                txt_escjogador.Text = "Papel";
            }
            if (rbtn_tesoura.Checked)
            {
                txt_escjogador.Text = "Tesoura";
            }

            Random rdn = new Random();
            int selecaoComputador = rdn.Next (1,4);
            switch (selecaoComputador)
            {
               case 1:
                    txt_esccomp.Text = "Pedra";
                    break;
               case 2:
                    txt_esccomp.Text = "Papel";
                    break;
               case 3:
                    txt_esccomp.Text = "Tesoura";
                    break;
            }

            if (txt_esccomp.Text == txt_escjogador.Text)
            {
                txt_resul.Text = "Empate. Ninguém pontua!";
            }

            //Escolha do Jogador
            if (txt_escjogador.Text == "Pedra" && txt_esccomp.Text == "Tesoura")
            {
                txt_resul.Text = "Jogador Ganhou";
                pontuacaoJogador++;
            }
            else if (txt_escjogador.Text == "Papel" && txt_esccomp.Text == "Pedra")
            {
                txt_resul.Text = "Jogador Ganhou";
                pontuacaoJogador++;
            }
            else if (txt_escjogador.Text == "Tesoura" && txt_esccomp.Text == "Papel")
            {
                txt_resul.Text = "Jogador Ganhou";
                pontuacaoJogador++;
            }

            //Escolha do Computador
            if (txt_esccomp.Text == "Pedra" && txt_escjogador.Text == "Tesoura")
            {
                txt_resul.Text = "Computador Ganhou";
                pontuacaoComp++;
            }
            else if (txt_esccomp.Text == "Papel" && txt_escjogador.Text == "Pedra")
            {
                txt_resul.Text = "Computador Ganhou";
                pontuacaoComp++;
            }
            else if (txt_esccomp.Text == "Tesoura" && txt_escjogador.Text == "Papel")
            {
                txt_resul.Text = "Computador Ganhou";
                pontuacaoComp++;
            }

            txt_jogador.Text = pontuacaoJogador.ToString();
            txt_Computador.Text = pontuacaoComp.ToString();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            txt_Computador.Text = "0";
            txt_jogador.Text = "0";
            txt_esccomp.Text = "";
            txt_escjogador.Text = "";
            txt_resul.Text = "";

            rbtn_pedra.Checked = false;
            rbtn_papel.Checked = false;
            rbtn_tesoura.Checked = false;
        }
    }
}

