using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor3D vetA = new Vetor3D(5, 3, 1);
            Vetor3D vetB = new Vetor3D(1, -1, 0);

            Console.WriteLine("A = " + vetA.imprimeVetor());
            Console.WriteLine("B = " + vetB.imprimeVetor());

            Console.WriteLine("\nProduto vetorial dos vetores A x B: " + vetA.prodVetorial(vetB).imprimeVetor());

            Console.WriteLine("\nMódulo do vetor A: " + vetA.norma());
            Console.WriteLine("Módulo do vetor B: " + vetB.norma());

            Console.ReadLine();
        }
    }
}
