using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEstacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamento[] objEstacionamento = new Estacionamento[5];
            
            for(int i=0; i<5; i++)
            {
                objEstacionamento[i] = new Estacionamento();
                objEstacionamento[i].solicitaDados();
            }


            Console.WriteLine("\n\n------------------ RELATÓRIO ---------------------\n");

            for (int i=0; i<5; i++)
            {
                Console.WriteLine("VEÍCULO " + (i + 1));
                objEstacionamento[i].imprimeCarro();
                objEstacionamento[i].totalPagar();
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
