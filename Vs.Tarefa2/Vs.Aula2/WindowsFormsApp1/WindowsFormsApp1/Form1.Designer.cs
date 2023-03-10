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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_hp = new System.Windows.Forms.MaskedTextBox();
            this.txt_mp = new System.Windows.Forms.MaskedTextBox();
            this.txt_md = new System.Windows.Forms.MaskedTextBox();
            this.txt_hd = new System.Windows.Forms.MaskedTextBox();
            this.lbl_hc = new System.Windows.Forms.Label();
            this.lbl_mc = new System.Windows.Forms.Label();
            this.lbl_situacao = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Partida";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Minuto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Minuto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Duração";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(350, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "_________________________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(350, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "_________________________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(350, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "_________________________________________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(161, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 32);
            this.label10.TabIndex = 10;
            this.label10.Text = "Minuto";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 32);
            this.label11.TabIndex = 9;
            this.label11.Text = "Hora";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 32);
            this.label12.TabIndex = 8;
            this.label12.Text = "Chegada";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_hp
            // 
            this.txt_hp.Location = new System.Drawing.Point(22, 99);
            this.txt_hp.Mask = "99";
            this.txt_hp.Name = "txt_hp";
            this.txt_hp.Size = new System.Drawing.Size(101, 22);
            this.txt_hp.TabIndex = 12;
            // 
            // txt_mp
            // 
            this.txt_mp.Location = new System.Drawing.Point(191, 99);
            this.txt_mp.Mask = "99";
            this.txt_mp.Name = "txt_mp";
            this.txt_mp.Size = new System.Drawing.Size(101, 22);
            this.txt_mp.TabIndex = 13;
            // 
            // txt_md
            // 
            this.txt_md.Location = new System.Drawing.Point(192, 244);
            this.txt_md.Mask = "99";
            this.txt_md.Name = "txt_md";
            this.txt_md.Size = new System.Drawing.Size(101, 22);
            this.txt_md.TabIndex = 15;
            // 
            // txt_hd
            // 
            this.txt_hd.Location = new System.Drawing.Point(23, 244);
            this.txt_hd.Mask = "99";
            this.txt_hd.Name = "txt_hd";
            this.txt_hd.Size = new System.Drawing.Size(101, 22);
            this.txt_hd.TabIndex = 14;
            // 
            // lbl_hc
            // 
            this.lbl_hc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_hc.Location = new System.Drawing.Point(23, 392);
            this.lbl_hc.Name = "lbl_hc";
            this.lbl_hc.Size = new System.Drawing.Size(106, 43);
            this.lbl_hc.TabIndex = 16;
            // 
            // lbl_mc
            // 
            this.lbl_mc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_mc.Location = new System.Drawing.Point(161, 392);
            this.lbl_mc.Name = "lbl_mc";
            this.lbl_mc.Size = new System.Drawing.Size(106, 43);
            this.lbl_mc.TabIndex = 17;
            // 
            // lbl_situacao
            // 
            this.lbl_situacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_situacao.Location = new System.Drawing.Point(23, 478);
            this.lbl_situacao.Name = "lbl_situacao";
            this.lbl_situacao.Size = new System.Drawing.Size(270, 43);
            this.lbl_situacao.TabIndex = 18;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(288, 360);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(117, 41);
            this.btn_Calcular.TabIndex = 19;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(288, 419);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(117, 41);
            this.btn_clear.TabIndex = 20;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 570);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.lbl_situacao);
            this.Controls.Add(this.lbl_mc);
            this.Controls.Add(this.lbl_hc);
            this.Controls.Add(this.txt_md);
            this.Controls.Add(this.txt_hd);
            this.Controls.Add(this.txt_mp);
            this.Controls.Add(this.txt_hp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Companhia Só Ida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txt_hp;
        private System.Windows.Forms.MaskedTextBox txt_mp;
        private System.Windows.Forms.MaskedTextBox txt_md;
        private System.Windows.Forms.MaskedTextBox txt_hd;
        private System.Windows.Forms.Label lbl_hc;
        private System.Windows.Forms.Label lbl_mc;
        private System.Windows.Forms.Label lbl_situacao;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_clear;
    }
}

