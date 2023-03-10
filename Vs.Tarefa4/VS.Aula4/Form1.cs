using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VS.Tarefa4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
                //verificar preenchimento dos campos
            if (txt_marca.Text.Length == 0)
            {
                MessageBox.Show("Todos os campos são obrigatórios", "marca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_modelo.Text.Length == 0)
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "modelo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (msk_matricula.Text.Length == 0)
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "matricula",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (msk_km.Text.Length == 0)
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "km",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btn_adicionar.Text.Equals("Atualizar"))
            {
                listmarca.Items[listmarca.SelectedIndex] = txt_marca.Text;
                listmodelo.Items[listmodelo.SelectedIndex] = txt_modelo.Text;
                listmatricula.Items[listmatricula.SelectedIndex] = msk_matricula.Text;
                listkms.Items[listkms.SelectedIndex] = msk_km.Text;
            }
            else
            {
                //add dados a lista
                listmarca.Items.Add(txt_marca.Text);
                listmodelo.Items.Add(txt_modelo.Text);
                listmatricula.Items.Add(msk_matricula.Text);
                listkms.Items.Add(msk_km.Text);
            }
                //limpar campos
                txt_marca.Clear();
                txt_modelo.Clear();
                msk_matricula.Clear();
                msk_km.Clear();
            }

        private void listmarca_SelectedIndexChanged(object sender, EventArgs e)
        {           //sincronizar
            listmodelo.SelectedIndex = listmarca.SelectedIndex;
            listmatricula.SelectedIndex = listmarca.SelectedIndex;
            listkms.SelectedIndex = listmarca.SelectedIndex;
        }

        private void listmodelo_SelectedIndexChanged(object sender, EventArgs e)
        {           //sincronizar
            listmarca.SelectedIndex = listmodelo.SelectedIndex;
            listmatricula.SelectedIndex = listmodelo.SelectedIndex;
            listkms.SelectedIndex = listmodelo.SelectedIndex;
        }

        private void listmatricula_SelectedIndexChanged(object sender, EventArgs e)
        {           //sincronizar
            listmarca.SelectedIndex = listmatricula.SelectedIndex;
            listmodelo.SelectedIndex = listmatricula.SelectedIndex;
            listkms.SelectedIndex = listmatricula.SelectedIndex;
        }

        private void listkms_SelectedIndexChanged(object sender, EventArgs e)
        {              //sincronizar
            listmarca.SelectedIndex = listkms.SelectedIndex;
            listmodelo.SelectedIndex = listkms.SelectedIndex;
            listmatricula.SelectedIndex = listkms.SelectedIndex;
        }

        void btn_limpar_Click(object sender, EventArgs e)
        {       //apagar dados
            txt_marca.Clear();
            txt_modelo.Clear();
            msk_matricula.Clear();
            msk_km.Clear();
            btn_adicionar.Text = "Adicionar";
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {      //Verificar se há ítens selecionados ou se a lista está vazia.
            if (listmarca.SelectedIndex < 0)
            {
                MessageBox.Show("Não há ítem selecionado.", "Favor verificar!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Eliminar linha
            int posicao = listmarca.SelectedIndex;
            listmarca.Items.RemoveAt(posicao);
            listmodelo.Items.RemoveAt(posicao);
            listmatricula.Items.RemoveAt(posicao);
            listkms.Items.RemoveAt(posicao);

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {            //Definir as fontes
            Font f1 = new Font("Aril", 18);
            Font f2 = new Font("Arial", 14);
            Font f3 = new Font("Arial", 16, FontStyle.Italic);



            e.Graphics.DrawString("Stand Aguiar Lda", f1, new SolidBrush(Color.Black),
               100, 100);

            e.Graphics.DrawString("Listagem de Viaturas", f1, new SolidBrush(Color.Black),
                100, 150);

            e.Graphics.DrawString("Marca", f1, new SolidBrush(Color.Black),
                100, 200);
            e.Graphics.DrawString("Modelo", f1, new SolidBrush(Color.Black),
                275, 200);
            e.Graphics.DrawString("Matrícula", f1, new SolidBrush(Color.Black),
                450, 200);
            e.Graphics.DrawString("Kms", f1, new SolidBrush(Color.Black),
                625, 200);
            e.Graphics.DrawString("_____________________________________________", f1, new SolidBrush(Color.Black),
                100, 210);



            int linha = 250;
            for (int i = 0; i < listmarca.Items.Count; i++)
            {
                e.Graphics.DrawString(listmarca.Items[i].ToString(),
                    f2, new SolidBrush(Color.Blue), 100, linha);

                e.Graphics.DrawString(listmodelo.Items[i].ToString(),
                     f2, new SolidBrush(Color.Blue), 275, linha);

                e.Graphics.DrawString(listmatricula.Items[i].ToString(),
                    f2, new SolidBrush(Color.Blue), 450, linha);

                e.Graphics.DrawString(listkms.Items[i].ToString(),
                     f2, new SolidBrush(Color.Blue), 625, linha);

                linha += 50;
            }

            e.Graphics.DrawString("_____________________________________________", f1, new SolidBrush(Color.Black),
            100, linha);
            e.Graphics.DrawString("Fim da listagem.", f3, new SolidBrush(Color.Black),
            100, linha += 50);

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (listmarca.SelectedItem != null)
            {
                txt_marca.Text = listmarca.SelectedItem.ToString();
                txt_modelo.Text = listmodelo.SelectedItem.ToString();
                msk_matricula.Text = listmatricula.SelectedItem.ToString();
                msk_km.Text = listkms.SelectedItem.ToString();
                btn_adicionar.Text = "Atualizar";
            }
            else
            {
                MessageBox.Show("Não há ítem selecionado.", "Favor verificar!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (listmarca.Items.Count == 0)
            {
                MessageBox.Show("Não há ítens na lista.", "Atenção!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
            }
            //Guardar os dados
            /*
             * SqlConection - Permite ligar à base de dados
             */
            SqlConnection ligacao = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="+
            AppDomain.CurrentDomain.BaseDirectory+
            "db_stand.mdf;Integrated Security=True;Connect Timeout=30");
            ligacao.Open();

            // SqlCommand - Enviar os comandos de sql á base de dados
            for (int i = 0; i < listmarca.Items.Count; i++)
            {
                SqlCommand cm = new SqlCommand("insert into Stand (Marca, Modelo, Matricula, Kms) values (@mar,@mod,@mat,@km)", ligacao);
                cm.Parameters.Add(new SqlParameter("@mar", listmarca.Items[i].ToString()));
                cm.Parameters.Add(new SqlParameter("@mod", listmodelo.Items[i].ToString()));
                cm.Parameters.Add(new SqlParameter("@mat", listmatricula.Items[i].ToString()));
                cm.Parameters.Add(new SqlParameter("@km", listkms.Items[i].ToString()));
                cm.ExecuteNonQuery();
            }
            ligacao.Close();
            MessageBox.Show("Dados guardados com sucesso", "Atenção!",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            listmarca.Items.Clear();
            listmodelo.Items.Clear();
            listmatricula.Items.Clear();
            listkms.Items.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}