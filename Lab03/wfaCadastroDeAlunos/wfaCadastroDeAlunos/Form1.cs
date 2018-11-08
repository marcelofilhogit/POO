using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaCadastroDeAlunos
{
    public partial class Form1 : Form
    {

        Aluno objAlunoFinal;
        Materia objMateriaFinal;
        List<Aluno> listaAlunos = new List<Aluno>();
        List<Materia> listaMaterias = new List<Materia>();

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        static Aluno achaAluno(string _nomeAluno, List<Aluno> alunos)
        {
            Aluno acheiAluno = null;
            for (int i = 0; i < alunos.Count(); i++)
            {
                if (_nomeAluno == alunos[i].getNome())
                {
                    acheiAluno = alunos[i];
                    break;
                }
            }
            return acheiAluno;
        }

        static Materia achaMateria(string _nomeMateria, List<Materia> materias)
        {
            Materia acheiMateria = null;

            for (int i = 0; i < materias.Count(); i++)
            {
                if (_nomeMateria == materias[i].getNome())
                {
                    acheiMateria = materias[i];
                    break;
                }
            }
            return acheiMateria;
        }


        //Cadastrar Aluno
        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            if ((txbNomeAluno.Text == "") || (txbMatriculaAluno.Text == "") || (txbPeriodoAluno.Text == ""))
            {
                MessageBox.Show("Preencha os campos vazios!");
            }

            else
            {
                Aluno objAluno = new Aluno(txbNomeAluno.Text, txbMatriculaAluno.Text, int.Parse(txbPeriodoAluno.Text));
                listaAlunos.Add(objAluno);

                MessageBox.Show("Aluno cadastrado com sucesso.");
                txbNomeAluno.Clear();
                txbMatriculaAluno.Clear();
                txbPeriodoAluno.Clear();
            }
        }

        //Cadastrar Materia
        private void btnCadastrarMateria_Click(object sender, EventArgs e)
        {
            if((txbNomeMateria.Text == "") || (txbCodigoMateria.Text == ""))
            {
                MessageBox.Show("Preencha os campos vazios!");
            }

            else
            {
                Materia objMateria = new Materia(txbNomeMateria.Text, txbCodigoMateria.Text);
                listaMaterias.Add(objMateria);

                MessageBox.Show("Materia cadastrada com sucesso.");
                txbNomeMateria.Clear();
                txbCodigoMateria.Clear();
            }
        }

        //Associar Aluno a Materia
        private void btnAssociar_Click(object sender, EventArgs e)
        {

            if ((txbAlunoAssociar.Text == "") || (txbMateriaAssociar.Text == ""))
            {
                MessageBox.Show("Preencha os campos vazios.");
            }

            else
            {
                objAlunoFinal = achaAluno(txbAlunoAssociar.Text, listaAlunos);
                objMateriaFinal = achaMateria(txbMateriaAssociar.Text, listaMaterias);

                objAlunoFinal.addMateria(objMateriaFinal);
                MessageBox.Show("Aluno matriculado na disciplina com sucesso!");
                txbAlunoAssociar.Clear();
                txbMateriaAssociar.Clear();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txbRelatorioAluno.Text == "")
            {
                MessageBox.Show("Preencha os campos vazios.");
            }

            else
            {
                objAlunoFinal = achaAluno(txbRelatorioAluno.Text, listaAlunos);
                txbRelatorioResultado.Text = "Anulo: " + objAlunoFinal.getNome() + "\r\r\nMatricula: " + objAlunoFinal.getMatricula() + "\r\r\nPeriodo: " + objAlunoFinal.getPeriodo() + objAlunoFinal.imprimeMaterias();
            }
        }
    }
}
