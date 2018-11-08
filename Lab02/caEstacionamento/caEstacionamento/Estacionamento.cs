using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEstacionamento
{
    class Estacionamento
    {
        //Atributos
        String placa;
        String marca;
        Tempo horaEntrada = new Tempo();
        Tempo horaSaida = new Tempo();

        //Metodos Construtor
        public Estacionamento()
        {
            placa = " ";
            marca = " ";
        }

        public Estacionamento(String _placa, String _marca)
        {
            placa = _placa;
            marca = _marca;
        }

        //Metodo Solicitar Dados
        public void solicitaDados()
        {
            Console.WriteLine("------------ DADOS DO VEÍCULO -----------\n");
            Console.Write("Insira a placa do carro: ");
            placa = Console.ReadLine();
            Console.Write("Insira a marca do carro: ");
            marca = Console.ReadLine();
            Console.WriteLine("Horário de entrada: ");
            horaEntrada.solicitaTempo();
            Console.WriteLine("Horário de saída: ");
            horaSaida.solicitaTempo();
        }

        //Metodo Imprimir Carro
        public void imprimeCarro()
        {
            Console.WriteLine("Placa do carro: " + placa);
            Console.WriteLine("Marca do carro: " + marca);
            Console.Write("Horário de entrada: ");
            horaEntrada.imprimeTempo();
            Console.Write("Horário de saída: ");
            horaSaida.imprimeTempo();
        }

        //Metodo Total do Pagamento
        public void totalPagar()
        {
            Tempo totalHoras = horaSaida.subtraiTempo(horaEntrada);
            int qtd_horas;
            qtd_horas = totalHoras.getHora() * 7;
            Console.Write("Tempo de estádia: ");
            totalHoras.imprimeTempo();
            Console.WriteLine("Valor total: R$ " + qtd_horas + ",00");
        }

    }
}
