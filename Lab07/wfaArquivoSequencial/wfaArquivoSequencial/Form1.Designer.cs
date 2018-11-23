namespace wfaArquivoSequencial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbConta = new System.Windows.Forms.TextBox();
            this.tbPrimeiroNome = new System.Windows.Forms.TextBox();
            this.tbUltimoNome = new System.Windows.Forms.TextBox();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.btCriarArquivo = new System.Windows.Forms.Button();
            this.btGravarRegistro = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btAbrirArquivo = new System.Windows.Forms.Button();
            this.btProximoRegistro = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtRelatorio = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSaldosNulo = new System.Windows.Forms.Button();
            this.btnSaldosNegativo = new System.Windows.Forms.Button();
            this.btnSaldosPositivos = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primeiro Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Último Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saldo:";
            // 
            // tbConta
            // 
            this.tbConta.Location = new System.Drawing.Point(140, 33);
            this.tbConta.Margin = new System.Windows.Forms.Padding(4);
            this.tbConta.Name = "tbConta";
            this.tbConta.Size = new System.Drawing.Size(239, 22);
            this.tbConta.TabIndex = 4;
            // 
            // tbPrimeiroNome
            // 
            this.tbPrimeiroNome.Location = new System.Drawing.Point(140, 71);
            this.tbPrimeiroNome.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrimeiroNome.Name = "tbPrimeiroNome";
            this.tbPrimeiroNome.Size = new System.Drawing.Size(239, 22);
            this.tbPrimeiroNome.TabIndex = 5;
            // 
            // tbUltimoNome
            // 
            this.tbUltimoNome.Location = new System.Drawing.Point(140, 112);
            this.tbUltimoNome.Margin = new System.Windows.Forms.Padding(4);
            this.tbUltimoNome.Name = "tbUltimoNome";
            this.tbUltimoNome.Size = new System.Drawing.Size(239, 22);
            this.tbUltimoNome.TabIndex = 6;
            // 
            // tbSaldo
            // 
            this.tbSaldo.Location = new System.Drawing.Point(140, 153);
            this.tbSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(239, 22);
            this.tbSaldo.TabIndex = 7;
            // 
            // btCriarArquivo
            // 
            this.btCriarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCriarArquivo.Location = new System.Drawing.Point(41, 226);
            this.btCriarArquivo.Margin = new System.Windows.Forms.Padding(4);
            this.btCriarArquivo.Name = "btCriarArquivo";
            this.btCriarArquivo.Size = new System.Drawing.Size(109, 78);
            this.btCriarArquivo.TabIndex = 8;
            this.btCriarArquivo.Text = "Criar Arquivo";
            this.btCriarArquivo.UseVisualStyleBackColor = true;
            this.btCriarArquivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btCriarArquivo_MouseClick);
            // 
            // btGravarRegistro
            // 
            this.btGravarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravarRegistro.Location = new System.Drawing.Point(193, 226);
            this.btGravarRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.btGravarRegistro.Name = "btGravarRegistro";
            this.btGravarRegistro.Size = new System.Drawing.Size(117, 78);
            this.btGravarRegistro.TabIndex = 9;
            this.btGravarRegistro.Text = "Gravar Registro";
            this.btGravarRegistro.UseVisualStyleBackColor = true;
            this.btGravarRegistro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btGravarRegistro_MouseClick);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(353, 226);
            this.btSair.Margin = new System.Windows.Forms.Padding(4);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(100, 78);
            this.btSair.TabIndex = 10;
            this.btSair.Text = "Fechar Arquivo";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btSair_MouseClick);
            // 
            // btAbrirArquivo
            // 
            this.btAbrirArquivo.AutoEllipsis = true;
            this.btAbrirArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbrirArquivo.Location = new System.Drawing.Point(128, 311);
            this.btAbrirArquivo.Name = "btAbrirArquivo";
            this.btAbrirArquivo.Size = new System.Drawing.Size(101, 76);
            this.btAbrirArquivo.TabIndex = 11;
            this.btAbrirArquivo.Text = "Abrir Arquivo";
            this.btAbrirArquivo.UseVisualStyleBackColor = true;
            this.btAbrirArquivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btAbrirArquivo_MouseClick);
            // 
            // btProximoRegistro
            // 
            this.btProximoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProximoRegistro.Location = new System.Drawing.Point(284, 311);
            this.btProximoRegistro.Name = "btProximoRegistro";
            this.btProximoRegistro.Size = new System.Drawing.Size(104, 76);
            this.btProximoRegistro.TabIndex = 12;
            this.btProximoRegistro.Text = "Próximo Registro";
            this.btProximoRegistro.UseVisualStyleBackColor = true;
            this.btProximoRegistro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btProximoRegistro_MouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 436);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btProximoRegistro);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btAbrirArquivo);
            this.tabPage1.Controls.Add(this.tbConta);
            this.tabPage1.Controls.Add(this.btSair);
            this.tabPage1.Controls.Add(this.tbPrimeiroNome);
            this.tabPage1.Controls.Add(this.btGravarRegistro);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btCriarArquivo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbSaldo);
            this.tabPage1.Controls.Add(this.tbUltimoNome);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(486, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtRelatorio);
            this.tabPage2.Controls.Add(this.btnFechar);
            this.tabPage2.Controls.Add(this.btnSaldosNulo);
            this.tabPage2.Controls.Add(this.btnSaldosNegativo);
            this.tabPage2.Controls.Add(this.btnSaldosPositivos);
            this.tabPage2.Controls.Add(this.btnAbrir);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(486, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Relatório de Contas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtRelatorio
            // 
            this.txtRelatorio.Location = new System.Drawing.Point(6, 6);
            this.txtRelatorio.Multiline = true;
            this.txtRelatorio.Name = "txtRelatorio";
            this.txtRelatorio.Size = new System.Drawing.Size(470, 240);
            this.txtRelatorio.TabIndex = 9;
            this.txtRelatorio.TextChanged += new System.EventHandler(this.txtRelatorio_TextChanged);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 5;
            this.btnFechar.Font = new System.Drawing.Font("Marlett", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(168, 369);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(141, 30);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar Arquivo";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.UseWaitCursor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSaldosNulo
            // 
            this.btnSaldosNulo.FlatAppearance.BorderSize = 5;
            this.btnSaldosNulo.Font = new System.Drawing.Font("Marlett", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaldosNulo.Location = new System.Drawing.Point(249, 322);
            this.btnSaldosNulo.Name = "btnSaldosNulo";
            this.btnSaldosNulo.Size = new System.Drawing.Size(141, 30);
            this.btnSaldosNulo.TabIndex = 7;
            this.btnSaldosNulo.Text = "Saldos Nulos";
            this.btnSaldosNulo.UseVisualStyleBackColor = true;
            this.btnSaldosNulo.UseWaitCursor = true;
            this.btnSaldosNulo.Click += new System.EventHandler(this.btnSaldosNulo_Click);
            // 
            // btnSaldosNegativo
            // 
            this.btnSaldosNegativo.FlatAppearance.BorderSize = 5;
            this.btnSaldosNegativo.Font = new System.Drawing.Font("Marlett", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaldosNegativo.Location = new System.Drawing.Point(87, 322);
            this.btnSaldosNegativo.Name = "btnSaldosNegativo";
            this.btnSaldosNegativo.Size = new System.Drawing.Size(141, 30);
            this.btnSaldosNegativo.TabIndex = 6;
            this.btnSaldosNegativo.Text = "Saldos Negativos";
            this.btnSaldosNegativo.UseVisualStyleBackColor = true;
            this.btnSaldosNegativo.UseWaitCursor = true;
            this.btnSaldosNegativo.Click += new System.EventHandler(this.btnSaldosNegativo_Click);
            // 
            // btnSaldosPositivos
            // 
            this.btnSaldosPositivos.FlatAppearance.BorderSize = 5;
            this.btnSaldosPositivos.Font = new System.Drawing.Font("Marlett", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaldosPositivos.Location = new System.Drawing.Point(250, 276);
            this.btnSaldosPositivos.Name = "btnSaldosPositivos";
            this.btnSaldosPositivos.Size = new System.Drawing.Size(141, 30);
            this.btnSaldosPositivos.TabIndex = 5;
            this.btnSaldosPositivos.Text = "Saldos Positivos";
            this.btnSaldosPositivos.UseVisualStyleBackColor = true;
            this.btnSaldosPositivos.UseWaitCursor = true;
            this.btnSaldosPositivos.Click += new System.EventHandler(this.btnSaldosPositivos_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.FlatAppearance.BorderSize = 5;
            this.btnAbrir.Font = new System.Drawing.Font("Marlett", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(87, 276);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(141, 30);
            this.btnAbrir.TabIndex = 4;
            this.btnAbrir.Text = "Abrir Arquivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.UseWaitCursor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 437);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Gerenciador de Contas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbConta;
        private System.Windows.Forms.TextBox tbPrimeiroNome;
        private System.Windows.Forms.TextBox tbUltimoNome;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.Button btCriarArquivo;
        private System.Windows.Forms.Button btGravarRegistro;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btAbrirArquivo;
        private System.Windows.Forms.Button btProximoRegistro;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSaldosNulo;
        private System.Windows.Forms.Button btnSaldosNegativo;
        private System.Windows.Forms.Button btnSaldosPositivos;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TextBox txtRelatorio;
    }
}

