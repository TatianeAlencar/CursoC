namespace WindowsFormsApp1
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
            this.linha_2 = new System.Windows.Forms.Label();
            this.pic_papel = new System.Windows.Forms.PictureBox();
            this.pic_tesoura = new System.Windows.Forms.PictureBox();
            this.pic_pedra = new System.Windows.Forms.PictureBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.btn_jogar = new System.Windows.Forms.Button();
            this.rbtn_pedra = new System.Windows.Forms.RadioButton();
            this.rbtn_tesoura = new System.Windows.Forms.RadioButton();
            this.rbtn_papel = new System.Windows.Forms.RadioButton();
            this.lbl_escolha = new System.Windows.Forms.Label();
            this.lbl_comp = new System.Windows.Forms.Label();
            this.lbl_resul = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_jogador = new System.Windows.Forms.TextBox();
            this.txt_Computador = new System.Windows.Forms.TextBox();
            this.linha_3 = new System.Windows.Forms.Label();
            this.txt_escjogador = new System.Windows.Forms.TextBox();
            this.txt_esccomp = new System.Windows.Forms.TextBox();
            this.txt_resul = new System.Windows.Forms.TextBox();
            this.btn_apagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_papel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tesoura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pedra)).BeginInit();
            this.SuspendLayout();
            // 
            // linha_2
            // 
            this.linha_2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.linha_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linha_2.Location = new System.Drawing.Point(216, 43);
            this.linha_2.Name = "linha_2";
            this.linha_2.Size = new System.Drawing.Size(533, 175);
            this.linha_2.TabIndex = 3;
            // 
            // pic_papel
            // 
            this.pic_papel.Image = global::WindowsFormsApp1.Properties.Resources.papel2;
            this.pic_papel.Location = new System.Drawing.Point(49, 169);
            this.pic_papel.Name = "pic_papel";
            this.pic_papel.Size = new System.Drawing.Size(116, 113);
            this.pic_papel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_papel.TabIndex = 6;
            this.pic_papel.TabStop = false;
            // 
            // pic_tesoura
            // 
            this.pic_tesoura.Image = global::WindowsFormsApp1.Properties.Resources.tesoura2;
            this.pic_tesoura.Location = new System.Drawing.Point(49, 300);
            this.pic_tesoura.Name = "pic_tesoura";
            this.pic_tesoura.Size = new System.Drawing.Size(116, 113);
            this.pic_tesoura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_tesoura.TabIndex = 5;
            this.pic_tesoura.TabStop = false;
            // 
            // pic_pedra
            // 
            this.pic_pedra.Image = global::WindowsFormsApp1.Properties.Resources.pedra;
            this.pic_pedra.Location = new System.Drawing.Point(49, 43);
            this.pic_pedra.Name = "pic_pedra";
            this.pic_pedra.Size = new System.Drawing.Size(110, 107);
            this.pic_pedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_pedra.TabIndex = 4;
            this.pic_pedra.TabStop = false;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(231, 61);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(76, 20);
            this.lbl_1.TabIndex = 7;
            this.lbl_1.Text = "Jogador";
            this.lbl_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.Location = new System.Drawing.Point(323, 61);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(110, 20);
            this.lbl_2.TabIndex = 8;
            this.lbl_2.Text = "Computador";
            this.lbl_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_jogar
            // 
            this.btn_jogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jogar.ForeColor = System.Drawing.Color.Blue;
            this.btn_jogar.Location = new System.Drawing.Point(503, 94);
            this.btn_jogar.Name = "btn_jogar";
            this.btn_jogar.Size = new System.Drawing.Size(194, 61);
            this.btn_jogar.TabIndex = 11;
            this.btn_jogar.Text = "Jogar";
            this.btn_jogar.UseVisualStyleBackColor = true;
            this.btn_jogar.Click += new System.EventHandler(this.btn_jogar_Click);
            // 
            // rbtn_pedra
            // 
            this.rbtn_pedra.AutoSize = true;
            this.rbtn_pedra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_pedra.Location = new System.Drawing.Point(245, 267);
            this.rbtn_pedra.Name = "rbtn_pedra";
            this.rbtn_pedra.Size = new System.Drawing.Size(73, 22);
            this.rbtn_pedra.TabIndex = 12;
            this.rbtn_pedra.TabStop = true;
            this.rbtn_pedra.Text = "Pedra";
            this.rbtn_pedra.UseVisualStyleBackColor = true;
            // 
            // rbtn_tesoura
            // 
            this.rbtn_tesoura.AutoSize = true;
            this.rbtn_tesoura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_tesoura.Location = new System.Drawing.Point(244, 352);
            this.rbtn_tesoura.Name = "rbtn_tesoura";
            this.rbtn_tesoura.Size = new System.Drawing.Size(91, 22);
            this.rbtn_tesoura.TabIndex = 13;
            this.rbtn_tesoura.TabStop = true;
            this.rbtn_tesoura.Text = "Tesoura";
            this.rbtn_tesoura.UseVisualStyleBackColor = true;
            // 
            // rbtn_papel
            // 
            this.rbtn_papel.AutoSize = true;
            this.rbtn_papel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_papel.Location = new System.Drawing.Point(245, 312);
            this.rbtn_papel.Name = "rbtn_papel";
            this.rbtn_papel.Size = new System.Drawing.Size(71, 22);
            this.rbtn_papel.TabIndex = 14;
            this.rbtn_papel.TabStop = true;
            this.rbtn_papel.Text = "Papel";
            this.rbtn_papel.UseVisualStyleBackColor = true;
            // 
            // lbl_escolha
            // 
            this.lbl_escolha.AutoSize = true;
            this.lbl_escolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_escolha.Location = new System.Drawing.Point(390, 250);
            this.lbl_escolha.Name = "lbl_escolha";
            this.lbl_escolha.Size = new System.Drawing.Size(194, 20);
            this.lbl_escolha.TabIndex = 15;
            this.lbl_escolha.Text = "A escolha do jogador foi:";
            // 
            // lbl_comp
            // 
            this.lbl_comp.AutoSize = true;
            this.lbl_comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comp.Location = new System.Drawing.Point(390, 300);
            this.lbl_comp.Name = "lbl_comp";
            this.lbl_comp.Size = new System.Drawing.Size(227, 20);
            this.lbl_comp.TabIndex = 17;
            this.lbl_comp.Text = "A escolha do computador foi:";
            // 
            // lbl_resul
            // 
            this.lbl_resul.AutoSize = true;
            this.lbl_resul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resul.Location = new System.Drawing.Point(390, 380);
            this.lbl_resul.Name = "lbl_resul";
            this.lbl_resul.Size = new System.Drawing.Size(89, 20);
            this.lbl_resul.TabIndex = 20;
            this.lbl_resul.Text = "Resultado:";
            // 
            // btn_reset
            // 
            this.btn_reset.AutoSize = true;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.Red;
            this.btn_reset.Location = new System.Drawing.Point(-7, -4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(440, 42);
            this.btn_reset.TabIndex = 21;
            this.btn_reset.Text = "Jogo Pedra, Papel, Tesoura";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // txt_jogador
            // 
            this.txt_jogador.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_jogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_jogador.Location = new System.Drawing.Point(240, 94);
            this.txt_jogador.Multiline = true;
            this.txt_jogador.Name = "txt_jogador";
            this.txt_jogador.Size = new System.Drawing.Size(67, 47);
            this.txt_jogador.TabIndex = 22;
            this.txt_jogador.Text = "\r\n0";
            this.txt_jogador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Computador
            // 
            this.txt_Computador.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_Computador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Computador.Location = new System.Drawing.Point(351, 94);
            this.txt_Computador.Multiline = true;
            this.txt_Computador.Name = "txt_Computador";
            this.txt_Computador.Size = new System.Drawing.Size(67, 47);
            this.txt_Computador.TabIndex = 23;
            this.txt_Computador.Text = "\r\n0";
            this.txt_Computador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linha_3
            // 
            this.linha_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linha_3.Location = new System.Drawing.Point(216, 233);
            this.linha_3.Name = "linha_3";
            this.linha_3.Size = new System.Drawing.Size(533, 180);
            this.linha_3.TabIndex = 2;
            // 
            // txt_escjogador
            // 
            this.txt_escjogador.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_escjogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_escjogador.Location = new System.Drawing.Point(390, 275);
            this.txt_escjogador.Name = "txt_escjogador";
            this.txt_escjogador.Size = new System.Drawing.Size(307, 22);
            this.txt_escjogador.TabIndex = 24;
            this.txt_escjogador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_esccomp
            // 
            this.txt_esccomp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_esccomp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_esccomp.Location = new System.Drawing.Point(390, 335);
            this.txt_esccomp.Name = "txt_esccomp";
            this.txt_esccomp.Size = new System.Drawing.Size(307, 22);
            this.txt_esccomp.TabIndex = 25;
            this.txt_esccomp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_resul
            // 
            this.txt_resul.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_resul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_resul.Location = new System.Drawing.Point(485, 378);
            this.txt_resul.Name = "txt_resul";
            this.txt_resul.Size = new System.Drawing.Size(212, 22);
            this.txt_resul.TabIndex = 26;
            this.txt_resul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_apagar
            // 
            this.btn_apagar.Location = new System.Drawing.Point(711, 0);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(86, 38);
            this.btn_apagar.TabIndex = 27;
            this.btn_apagar.Text = "Reset";
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.txt_resul);
            this.Controls.Add(this.txt_esccomp);
            this.Controls.Add(this.txt_escjogador);
            this.Controls.Add(this.txt_Computador);
            this.Controls.Add(this.txt_jogador);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_resul);
            this.Controls.Add(this.lbl_comp);
            this.Controls.Add(this.lbl_escolha);
            this.Controls.Add(this.rbtn_papel);
            this.Controls.Add(this.rbtn_tesoura);
            this.Controls.Add(this.rbtn_pedra);
            this.Controls.Add(this.btn_jogar);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.pic_papel);
            this.Controls.Add(this.pic_tesoura);
            this.Controls.Add(this.pic_pedra);
            this.Controls.Add(this.linha_2);
            this.Controls.Add(this.linha_3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo Pedra, Pepel, Tesoura";
            ((System.ComponentModel.ISupportInitialize)(this.pic_papel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tesoura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pedra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label linha_2;
        private System.Windows.Forms.PictureBox pic_pedra;
        private System.Windows.Forms.PictureBox pic_tesoura;
        private System.Windows.Forms.PictureBox pic_papel;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Button btn_jogar;
        private System.Windows.Forms.RadioButton rbtn_pedra;
        private System.Windows.Forms.RadioButton rbtn_tesoura;
        private System.Windows.Forms.RadioButton rbtn_papel;
        private System.Windows.Forms.Label lbl_escolha;
        private System.Windows.Forms.Label lbl_comp;
        private System.Windows.Forms.Label lbl_resul;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txt_jogador;
        private System.Windows.Forms.TextBox txt_Computador;
        private System.Windows.Forms.Label linha_3;
        private System.Windows.Forms.TextBox txt_escjogador;
        private System.Windows.Forms.TextBox txt_esccomp;
        private System.Windows.Forms.TextBox txt_resul;
        private System.Windows.Forms.Button btn_apagar;
    }
}

