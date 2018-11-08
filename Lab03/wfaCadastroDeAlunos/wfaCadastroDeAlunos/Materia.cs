using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCadastroDeAlunos
{
    class Materia
    {
        //Atributos
        private string nome;
        private string codigo;

        //Metodos Construtor
        public Materia()
        {
            nome = "";
            codigo = "";
        }

        public Materia(string _nome, string _codigo)
        {
            nome = _nome;
            codigo = _codigo;
        }

        //Metodos Get
        public string getNome()
        {
            return nome;
        }

        public string getCodigo()
        {
            return codigo;
        }

        //Metodos Set
        public void setNome(string _nome)
        {
            nome = _nome;
        }

        //Detalher
        public string showMaterias()
        {
            return nome + " " + codigo;
        }
    }
}
