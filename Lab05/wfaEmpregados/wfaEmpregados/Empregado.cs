using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaEmpregados
{
    class Empregado
    {
        //Atributos
        protected string nome;
        protected string cpf;
        protected string endereco;

        //Metodos Construtor 
        public Empregado()
        {
            nome = "";
            cpf = "";
            endereco = "";
        }

        public Empregado(string _nome, string _cpf, string _endereco)
        {
            nome = _nome;
            cpf = _cpf;
            endereco = _endereco;
        }

        //Metodos Get
        public string getNome()
        {
            return nome;
        }

        public string getCpf()
        {
            return cpf;
        }

        public string getEndereco()
        {
            return endereco;
        }

        //Metodos Set
        public void setNome(string _nome)
        {
            nome = _nome;
        }

        public void setCpf(string _cpf)
        {
            cpf = _cpf;
        }

        public void setEndereco(string _endereco)
        {
            endereco = _endereco;
        }

        
        public virtual double salarioLiq()
        {
            return 1.0;
        }

        public virtual String imprime()
        {
            return "";
        }

    }
}
