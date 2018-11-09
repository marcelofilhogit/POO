namespace wfaEmpregados
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCLT = new System.Windows.Forms.RadioButton();
            this.rbHorista = new System.Windows.Forms.RadioButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbValorHora = new System.Windows.Forms.TextBox();
            this.txbHoras = new System.Windows.Forms.TextBox();
            this.txbSalario = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.labValorHoras = new System.Windows.Forms.Label();
            this.labNumeroHoras = new System.Windows.Forms.Label();
            this.labSalario = new System.Windows.Forms.Label();
            this.labEndereco = new System.Windows.Forms.Label();
            this.labCPF = new System.Windows.Forms.Label();
            this.labNome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbRelatorio = new System.Windows.Forms.ListBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnCadastrar);
            this.tabPage1.Controls.Add(this.txbValorHora);
            this.tabPage1.Controls.Add(this.txbHoras);
            this.tabPage1.Controls.Add(this.txbSalario);
            this.tabPage1.Controls.Add(this.txbEndereco);
            this.tabPage1.Controls.Add(this.txbCPF);
            this.tabPage1.Controls.Add(this.txbNome);
            this.tabPage1.Controls.Add(this.labValorHoras);
            this.tabPage1.Controls.Add(this.labNumeroHoras);
            this.tabPage1.Controls.Add(this.labSalario);
            this.tabPage1.Controls.Add(this.labEndereco);
            this.tabPage1.Controls.Add(this.labCPF);
            this.tabPage1.Controls.Add(this.labNome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCLT);
            this.groupBox1.Controls.Add(this.rbHorista);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(525, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 176);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empregado";
            // 
            // rbCLT
            // 
            this.rbCLT.AutoSize = true;
            this.rbCLT.Location = new System.Drawing.Point(18, 117);
            this.rbCLT.Name = "rbCLT";
            this.rbCLT.Size = new System.Drawing.Size(181, 28);
            this.rbCLT.TabIndex = 1;
            this.rbCLT.TabStop = true;
            this.rbCLT.Text = "Empregado CLT";
            this.rbCLT.UseVisualStyleBackColor = true;
            this.rbCLT.CheckedChanged += new System.EventHandler(this.rbCLT_CheckedChanged);
            // 
            // rbHorista
            // 
            this.rbHorista.AutoSize = true;
            this.rbHorista.Location = new System.Drawing.Point(18, 66);
            this.rbHorista.Name = "rbHorista";
            this.rbHorista.Size = new System.Drawing.Size(208, 28);
            this.rbHorista.TabIndex = 0;
            this.rbHorista.TabStop = true;
            this.rbHorista.Text = "Empregado Horista";
            this.rbHorista.UseVisualStyleBackColor = true;
            this.rbHorista.CheckedChanged += new System.EventHandler(this.rbHorista_CheckedChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(277, 325);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(238, 57);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbValorHora
            // 
            this.txbValorHora.Location = new System.Drawing.Point(601, 242);
            this.txbValorHora.Multiline = true;
            this.txbValorHora.Name = "txbValorHora";
            this.txbValorHora.Size = new System.Drawing.Size(170, 30);
            this.txbValorHora.TabIndex = 11;
            // 
            // txbHoras
            // 
            this.txbHoras.Location = new System.Drawing.Point(209, 242);
            this.txbHoras.Multiline = true;
            this.txbHoras.Name = "txbHoras";
            this.txbHoras.Size = new System.Drawing.Size(170, 30);
            this.txbHoras.TabIndex = 10;
            // 
            // txbSalario
            // 
            this.txbSalario.Location = new System.Drawing.Point(131, 182);
            this.txbSalario.Multiline = true;
            this.txbSalario.Name = "txbSalario";
            this.txbSalario.Size = new System.Drawing.Size(352, 31);
            this.txbSalario.TabIndex = 9;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(131, 123);
            this.txbEndereco.Multiline = true;
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(352, 31);
            this.txbEndereco.TabIndex = 8;
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(131, 72);
            this.txbCPF.Multiline = true;
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(352, 31);
            this.txbCPF.TabIndex = 7;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(131, 25);
            this.txbNome.Multiline = true;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(352, 31);
            this.txbNome.TabIndex = 6;
            // 
            // labValorHoras
            // 
            this.labValorHoras.AutoSize = true;
            this.labValorHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labValorHoras.Location = new System.Drawing.Point(405, 248);
            this.labValorHoras.Name = "labValorHoras";
            this.labValorHoras.Size = new System.Drawing.Size(190, 24);
            this.labValorHoras.TabIndex = 5;
            this.labValorHoras.Text = "Valor da Hora (R$):";
            // 
            // labNumeroHoras
            // 
            this.labNumeroHoras.AutoSize = true;
            this.labNumeroHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumeroHoras.Location = new System.Drawing.Point(17, 248);
            this.labNumeroHoras.Name = "labNumeroHoras";
            this.labNumeroHoras.Size = new System.Drawing.Size(182, 24);
            this.labNumeroHoras.TabIndex = 4;
            this.labNumeroHoras.Text = "Número de Horas:";
            // 
            // labSalario
            // 
            this.labSalario.AutoSize = true;
            this.labSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSalario.Location = new System.Drawing.Point(45, 189);
            this.labSalario.Name = "labSalario";
            this.labSalario.Size = new System.Drawing.Size(80, 24);
            this.labSalario.TabIndex = 3;
            this.labSalario.Text = "Sálario:";
            // 
            // labEndereco
            // 
            this.labEndereco.AutoSize = true;
            this.labEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEndereco.Location = new System.Drawing.Point(17, 130);
            this.labEndereco.Name = "labEndereco";
            this.labEndereco.Size = new System.Drawing.Size(108, 24);
            this.labEndereco.TabIndex = 2;
            this.labEndereco.Text = "Endereço:";
            // 
            // labCPF
            // 
            this.labCPF.AutoSize = true;
            this.labCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCPF.Location = new System.Drawing.Point(69, 79);
            this.labCPF.Name = "labCPF";
            this.labCPF.Size = new System.Drawing.Size(56, 24);
            this.labCPF.TabIndex = 1;
            this.labCPF.Text = "CPF:";
            // 
            // labNome
            // 
            this.labNome.AutoSize = true;
            this.labNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNome.Location = new System.Drawing.Point(53, 32);
            this.labNome.Name = "labNome";
            this.labNome.Size = new System.Drawing.Size(72, 24);
            this.labNome.TabIndex = 0;
            this.labNome.Text = "Nome:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbRelatorio);
            this.tabPage2.Controls.Add(this.btnRelatorio);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Relatório";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbRelatorio
            // 
            this.lbRelatorio.FormattingEnabled = true;
            this.lbRelatorio.Location = new System.Drawing.Point(0, 104);
            this.lbRelatorio.Name = "lbRelatorio";
            this.lbRelatorio.Size = new System.Drawing.Size(793, 316);
            this.lbRelatorio.TabIndex = 14;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Location = new System.Drawing.Point(255, 16);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(238, 57);
            this.btnRelatorio.TabIndex = 13;
            this.btnRelatorio.Text = "Emitir Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Cadastro de Trabalhadores";
            this.Shown += new System.EventHandler(this.Form);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txbSalario;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label labValorHoras;
        private System.Windows.Forms.Label labNumeroHoras;
        private System.Windows.Forms.Label labSalario;
        private System.Windows.Forms.Label labEndereco;
        private System.Windows.Forms.Label labCPF;
        private System.Windows.Forms.Label labNome;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbValorHora;
        private System.Windows.Forms.TextBox txbHoras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCLT;
        private System.Windows.Forms.RadioButton rbHorista;
        private System.Windows.Forms.ListBox lbRelatorio;
        private System.Windows.Forms.Button btnRelatorio;
    }
}

