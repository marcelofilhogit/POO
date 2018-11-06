using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_lab01_vetor2d
{
    class Vetor2D
    {
        //Atributos 
        private double x;
        private double y;
        private double produtoEscalar;
        private double moduloDoVetor;
        private double anguloDosVetores;
        private double projecaoX;
        private double projecaoY;

        //Metodo Construtor 
        public Vetor2D()
        {
            x = 0;
            y = 0;
        }

        //Metodo Construtor 
        public Vetor2D(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        //Metodos Get
        public double getX()
        {
            return x;
        }

        public double getY()
        {
            return y;
        }

        //Metodos Set
        public void setX(double _x)
        {
            x = _x;
        }

        public void setY(double _y)
        {
            y = _y;
        }

        //Produto escalar entre dois vetores
        public double getProdutoEscalar()
        {
            return produtoEscalar;
        }

        public void setProdutoEscalar(double vet1X, double vet1Y, double vet2X, double vet2Y)
        {
            produtoEscalar = ((vet1X * vet2X) + (vet1Y * vet2Y));
        }

        //Módulo do vetor
        public double getModuloDoVetor()
        {
            return moduloDoVetor;
        }

        public void setModuloDoVetor(double _x, double _y)
        {
            moduloDoVetor = Math.Sqrt((_x * _x) + (_y * _y));
        }


        //Angulo entre dois vetores
        public double getAnguloDosVetores()
        {
            return anguloDosVetores;
        }

        public void setAnguloDosVetores(double _produtoEscalar, double _modV1, double _modv2)
        {
            anguloDosVetores = Math.Cos(_produtoEscalar / ((_modV1) * (_modv2)));
        }


        //Vetor projecão de um vetor a em um vetor b
        public double getProjecaoX()
        {
            return projecaoX;
        }

        public double getProjecaoY()
        {
            return projecaoY;
        }

        public void setProjecao(double vet1X, double vet1Y, double vet2X, double vet2Y)
        {
            projecaoX = (((vet1X * vet2X) + (vet1Y * vet2Y)) * vet2X) / (((vet2X * vet2X) + (vet2Y * vet2Y)));
            projecaoY = (((vet1X * vet2X) + (vet1Y * vet2Y)) * vet2Y) / (((vet2X * vet2X) + (vet2Y * vet2Y)));
        }

    }
}
