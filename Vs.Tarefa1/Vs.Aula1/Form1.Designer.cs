namespace Vs.Aula1
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
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.btn_mais = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_divisor = new System.Windows.Forms.Button();
            this.btn_vezes = new System.Windows.Forms.Button();
            this.btn_menos = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(138, 68);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(67, 22);
            this.txt_1.TabIndex = 0;
            this.txt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(135, 38);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(70, 16);
            this.lbl_1.TabIndex = 1;
            this.lbl_1.Text = "1º Número";
            this.lbl_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(135, 120);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(70, 16);
            this.lbl_2.TabIndex = 3;
            this.lbl_2.Text = "2º Número";
            this.lbl_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(138, 150);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(67, 22);
            this.txt_2.TabIndex = 2;
            this.txt_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_mais
            // 
            this.btn_mais.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_mais.Location = new System.Drawing.Point(36, 245);
            this.btn_mais.Name = "btn_mais";
            this.btn_mais.Size = new System.Drawing.Size(46, 52);
            this.btn_mais.TabIndex = 4;
            this.btn_mais.Text = "+";
            this.btn_mais.UseVisualStyleBackColor = true;
            this.btn_mais.Click += new System.EventHandler(this.btn_mais_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_limpar.Location = new System.Drawing.Point(288, 245);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(46, 52);
            this.btn_limpar.TabIndex = 5;
            this.btn_limpar.Text = "c";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_divisor
            // 
            this.btn_divisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divisor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_divisor.Location = new System.Drawing.Point(223, 245);
            this.btn_divisor.Name = "btn_divisor";
            this.btn_divisor.Size = new System.Drawing.Size(46, 52);
            this.btn_divisor.TabIndex = 6;
            this.btn_divisor.Text = "/";
            this.btn_divisor.UseVisualStyleBackColor = true;
            this.btn_divisor.Click += new System.EventHandler(this.btn_divisor_Click);
            // 
            // btn_vezes
            // 
            this.btn_vezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vezes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_vezes.Location = new System.Drawing.Point(159, 245);
            this.btn_vezes.Name = "btn_vezes";
            this.btn_vezes.Size = new System.Drawing.Size(46, 52);
            this.btn_vezes.TabIndex = 7;
            this.btn_vezes.Text = "x";
            this.btn_vezes.UseVisualStyleBackColor = true;
            this.btn_vezes.Click += new System.EventHandler(this.btn_vezes_Click);
            // 
            // btn_menos
            // 
            this.btn_menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_menos.Location = new System.Drawing.Point(97, 245);
            this.btn_menos.Name = "btn_menos";
            this.btn_menos.Size = new System.Drawing.Size(46, 52);
            this.btn_menos.TabIndex = 8;
            this.btn_menos.Text = "-";
            this.btn_menos.UseVisualStyleBackColor = true;
            this.btn_menos.Click += new System.EventHandler(this.btn_menos_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.Location = new System.Drawing.Point(119, 347);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(119, 22);
            this.lbl_resultado.TabIndex = 9;
            this.lbl_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_menos);
            this.Controls.Add(this.btn_vezes);
            this.Controls.Add(this.btn_divisor);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_mais);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.txt_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.Button btn_mais;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_divisor;
        private System.Windows.Forms.Button btn_vezes;
        private System.Windows.Forms.Button btn_menos;
        private System.Windows.Forms.TextBox lbl_resultado;
    }
}

