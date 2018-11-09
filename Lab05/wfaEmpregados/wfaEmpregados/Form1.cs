using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaEmpregados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Empregado> empregados = new List<Empregado>();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (rbCLT.Checked)
            {
                EmpregadoCLT empregadoCLT = new EmpregadoCLT(txbNome.Text, txbCPF.Text,
                    txbEndereco.Text, Convert.ToDouble(txbSalario.Text));
                empregados.Add(empregadoCLT);
                MessageBox.Show("Cadastro do Empregado CLT realizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                EmpregadoHorista empregadoHorista = new EmpregadoHorista(txbNome.Text, txbCPF.Text,
                    txbEndereco.Text, Convert.ToInt32(txbHoras.Text), Convert.ToDouble(txbValorHora.Text));
                empregados.Add(empregadoHorista);
                MessageBox.Show("Cadastro do Empregado Horista realizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rbHorista_CheckedChanged(object sender, EventArgs e)
        {
            labSalario.Hide();
            labNumeroHoras.Show();
            labValorHoras.Show();
            txbHoras.Show();
            txbValorHora.Show();
            txbSalario.Hide();

        }

        private void rbCLT_CheckedChanged(object sender, EventArgs e)
        {
            labNumeroHoras.Hide();
            labValorHoras.Hide();
            txbHoras.Hide();
            txbValorHora.Hide();
            labSalario.Show();
            txbSalario.Show();
        }

        private void Form(object sender, EventArgs e)
        {
            rbHorista.Select();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

            lbRelatorio.Items.Clear();
            lbRelatorio.Items.Add("|\tTipo de Empregado\t|\tNome\t|\tCPF\t|\tEndereço\t|\tSalário\t|");
            lbRelatorio.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            for (int i=0; i<empregados.Count; i++)
            {
                lbRelatorio.Items.Add(empregados[i].imprime());
            }

        }

    }
}
