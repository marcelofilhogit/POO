using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_lab01_vetor2d
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor2D objVet1 = new Vetor2D();
            Vetor2D objVet2 = new Vetor2D();
            Vetor2D objProdEsc = new Vetor2D();
            Vetor2D objAngulo = new Vetor2D();
            Vetor2D objProjecao = new Vetor2D();

            double x;
            double y;

            Console.WriteLine("Digite o valor de X do vetor 1: ");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o valor de Y do vetor 1: ");
            y = double.Parse(Console.ReadLine());

            objVet1.setX(x);
            objVet1.setY(y);

            Console.WriteLine("\nDigite o valor de X do vetor 2: ");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o valor de Y do vetor 2: ");
            y = double.Parse(Console.ReadLine());

            objVet2.setX(x);
            objVet2.setY(y);

            Console.WriteLine("\nVetor 1 = ( " + objVet1.getX() + ", " + objVet1.getY() + " )" + "\nVetor 2 = ( " + objVet2.getX() + ", " + objVet2.getY() + " )");


            objProdEsc.setProdutoEscalar(objVet1.getX(), objVet1.getY(), objVet2.getX(), objVet2.getY());
            Console.WriteLine("\nProduto escalar do vetor 1 com o vetor 2 eh: " + objProdEsc.getProdutoEscalar());


            objVet1.setModuloDoVetor(objVet1.getX(), objVet1.getY());
            Console.WriteLine("\nO módulo do vetor 1 eh: " + objVet1.getModuloDoVetor());

            objVet2.setModuloDoVetor(objVet2.getX(), objVet2.getY());
            Console.WriteLine("O módulo do vetor 2 eh: " + objVet2.getModuloDoVetor());

            objAngulo.setAnguloDosVetores(objProdEsc.getProdutoEscalar(), objVet1.getModuloDoVetor(), objVet2.getModuloDoVetor());
            Console.WriteLine("\nO angulo entre os vetores 1 e 2 eh: " + objAngulo.getAnguloDosVetores());

            objProjecao.setProjecao(objVet1.getX(), objVet1.getY(), objVet2.getX(), objVet2.getY());
            Console.WriteLine("\nO Vetor projeção do vetores 1 em 2 eh: " + "( " + objProjecao.getProjecaoX() + ", " + objProjecao.getProjecaoY() + " )");

            Console.ReadLine();
        }
    }
}
