using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaEmpregados
{
    class EmpregadoCLT : Empregado
    {
        //Atributos 
        private double sBrutoCLT;

        //Metodos Construtor
        public EmpregadoCLT() : base()
        {
            sBrutoCLT = 0.0;
        }

        public EmpregadoCLT(string _nome, string _cpf, string _endereco, double _sBrutoCLT) : base(_nome, _cpf, _endereco)
        {
            sBrutoCLT = _sBrutoCLT;
        }

        //Metodo Get
        public double getsBrutoCLT()
        {
            return sBrutoCLT;
        }

        //Metodo Set
        public void setsBrutoCLT(double _sBrutoCLT)
        {
            sBrutoCLT = _sBrutoCLT;
        }

        public override double salarioLiq()
        {
            if(sBrutoCLT <= 5000.0)
                return sBrutoCLT * 0.85;

            else
                return sBrutoCLT * 0.725;
        }


        public override string imprime()
        {
            return "|\tCLT\t|\t" + nome + "\t|\t" + cpf + "\t|\t" + endereco + "\t|\t" + salarioLiq() + "\t|";
        }

    }
}
