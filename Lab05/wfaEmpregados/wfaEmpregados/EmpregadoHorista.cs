using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaEmpregados
{
    class EmpregadoHorista : Empregado
    {
        //Atributos 
        private int nHoras;
        private double valorHora;

        //Metodos Construtor
        public EmpregadoHorista() : base()
        {
            nHoras = 0;
            valorHora = 0.0;
        }

        public EmpregadoHorista(String _nome, String _cpf, String _endereco, int _nHoras, double _valorHora) : base(_nome, _cpf, _endereco)
        {
            nHoras = _nHoras;
            valorHora = _valorHora;
        }

        //Metodos Get
        public int getHoras()
        {
            return nHoras;
        }

        public double getValor()
        {
            return valorHora;
        }

        //Metodos Set
        public void setHoras(int _nHoras)
        {
            nHoras = _nHoras;
        }

        public void setValor(double _valorHora)
        {
            valorHora = _valorHora;
        }

        //Metodo Salario Liquido    
        public override double salarioLiq()
        {
            if ((valorHora * nHoras) <= 5000.0)
                return valorHora * nHoras * 0.85;
            else
                return valorHora * nHoras * 0.725;
        }


        public override String imprime()
        {
            return "|\tHorista\t|\t" + nome + "\t|\t" + cpf + "\t|\t" + endereco + "\t|\t" + salarioLiq() + "\t|";
        }

    }
}
