using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCadastroDeAlunos
{
    class Aluno
    {
        //Atributos
        private string nome;
        private string matricula;
        private int periodo;
        private Materia[] listaMaterias;
        private int indiceMateria;

        // Métodos Construtor
        public Aluno() 
        {
            nome = "";
            matricula = "";
            periodo = 0;
            listaMaterias = new Materia[5];
            indiceMateria = 0;
        }

        public Aluno(String _nome, String _matricula, int _periodo)
        {
            nome = _nome;
            matricula = _matricula;
            periodo = _periodo;
            listaMaterias = new Materia[5];
            indiceMateria = 0;
        }

        //Metodos Get 
        public string getNome()
        {
            return nome;
        }

        public string getMatricula()
        {
            return matricula;
        }

        public int getPeriodo()
        {
            return periodo;
        }

        //Metodos Set
        public void setNome(string _nome)
        {
            nome = _nome;
        }

        public void setMatricula(string _matricula)
        {
            matricula = _matricula;
        }

        public void setPeriodo(int _periodo)
        {
            periodo = _periodo;
        }

        //Adiciona Aluno
        public void addMateria(Materia _materia)
        {
            if (indiceMateria < 5)
            {
                listaMaterias[indiceMateria] = _materia;
                indiceMateria++;
            }

            else
            {
                Console.WriteLine("O número máximo de matéria permitidas foi alcançado.");
            }
        }
        
        //Detalher Materia 
        public String imprimeMaterias()
        {
            String relatorio = "";
            for (int i = 0; i < indiceMateria; i++)
            {
                relatorio = relatorio + "\r\r\nMateria: " + listaMaterias[i].getNome() + "\r\r\nCódigo: " + listaMaterias[i].getCodigo();
            }
            return relatorio;
        }


    }
}
