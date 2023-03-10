namespace VS.Tarefa4
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.msk_km = new System.Windows.Forms.MaskedTextBox();
            this.msk_matricula = new System.Windows.Forms.MaskedTextBox();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listkms = new System.Windows.Forms.ListBox();
            this.listmatricula = new System.Windows.Forms.ListBox();
            this.listmodelo = new System.Windows.Forms.ListBox();
            this.listmarca = new System.Windows.Forms.ListBox();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_limpar);
            this.groupBox1.Controls.Add(this.btn_adicionar);
            this.groupBox1.Controls.Add(this.msk_km);
            this.groupBox1.Controls.Add(this.msk_matricula);
            this.groupBox1.Controls.Add(this.txt_modelo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_marca);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(34, 332);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(117, 26);
            this.btn_limpar.TabIndex = 11;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(34, 300);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(117, 26);
            this.btn_adicionar.TabIndex = 10;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // msk_km
            // 
            this.msk_km.Location = new System.Drawing.Point(9, 257);
            this.msk_km.Mask = "AAAAAAAAA";
            this.msk_km.Name = "msk_km";
            this.msk_km.Size = new System.Drawing.Size(175, 22);
            this.msk_km.TabIndex = 9;
            // 
            // msk_matricula
            // 
            this.msk_matricula.Location = new System.Drawing.Point(12, 197);
            this.msk_matricula.Mask = "AA-AA-AA";
            this.msk_matricula.Name = "msk_matricula";
            this.msk_matricula.Size = new System.Drawing.Size(175, 22);
            this.msk_matricula.TabIndex = 8;
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(6, 120);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(181, 22);
            this.txt_modelo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Matrícula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kms Atuais";
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(6, 48);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(181, 22);
            this.txt_marca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.listkms);
            this.groupBox2.Controls.Add(this.listmatricula);
            this.groupBox2.Controls.Add(this.listmodelo);
            this.groupBox2.Controls.Add(this.listmarca);
            this.groupBox2.Location = new System.Drawing.Point(230, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 379);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Kms Atuais";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Matrícula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Marca";
            // 
            // listkms
            // 
            this.listkms.FormattingEnabled = true;
            this.listkms.ItemHeight = 16;
            this.listkms.Location = new System.Drawing.Point(428, 48);
            this.listkms.Name = "listkms";
            this.listkms.Size = new System.Drawing.Size(115, 324);
            this.listkms.TabIndex = 3;
            this.listkms.SelectedIndexChanged += new System.EventHandler(this.listkms_SelectedIndexChanged);
            // 
            // listmatricula
            // 
            this.listmatricula.FormattingEnabled = true;
            this.listmatricula.ItemHeight = 16;
            this.listmatricula.Location = new System.Drawing.Point(296, 48);
            this.listmatricula.Name = "listmatricula";
            this.listmatricula.Size = new System.Drawing.Size(139, 324);
            this.listmatricula.TabIndex = 2;
            this.listmatricula.SelectedIndexChanged += new System.EventHandler(this.listmatricula_SelectedIndexChanged);
            // 
            // listmodelo
            // 
            this.listmodelo.FormattingEnabled = true;
            this.listmodelo.ItemHeight = 16;
            this.listmodelo.Location = new System.Drawing.Point(152, 48);
            this.listmodelo.Name = "listmodelo";
            this.listmodelo.Size = new System.Drawing.Size(147, 324);
            this.listmodelo.TabIndex = 1;
            this.listmodelo.SelectedIndexChanged += new System.EventHandler(this.listmodelo_SelectedIndexChanged);
            // 
            // listmarca
            // 
            this.listmarca.FormattingEnabled = true;
            this.listmarca.ItemHeight = 16;
            this.listmarca.Location = new System.Drawing.Point(8, 48);
            this.listmarca.Name = "listmarca";
            this.listmarca.Size = new System.Drawing.Size(147, 324);
            this.listmarca.TabIndex = 0;
            this.listmarca.SelectedIndexChanged += new System.EventHandler(this.listmarca_SelectedIndexChanged);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(302, 402);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(117, 26);
            this.btn_imprimir.TabIndex = 13;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(671, 402);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(117, 26);
            this.btn_sair.TabIndex = 14;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(548, 402);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(117, 26);
            this.btn_eliminar.TabIndex = 15;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(425, 402);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(117, 26);
            this.btn_alterar.TabIndex = 16;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(35, 403);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(160, 35);
            this.btn_guardar.TabIndex = 17;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stand Aguiar Lda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.MaskedTextBox msk_km;
        private System.Windows.Forms.MaskedTextBox msk_matricula;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listmarca;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listkms;
        private System.Windows.Forms.ListBox listmatricula;
        private System.Windows.Forms.ListBox listmodelo;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btn_guardar;
    }
}

