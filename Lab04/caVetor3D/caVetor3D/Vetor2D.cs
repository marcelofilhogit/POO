using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor3D
{
    class Vetor2D
    {
        //Atributos
        protected double x;
        protected double y;

        //Metodos Construtor
        public Vetor2D()
        {
            x = 0.0;
            y = 0.0;
        }

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

        //Métodos set
        public void setX(double _x)
        {
            x = _x;
        }

        public void setY(double _y)
        {
            y = _y;
        }


        public double prodEscalar(Vetor2D vet1)
        {
            return x * vet1.getX() + y * vet1.getY();
        }

        public virtual double norma()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public double angulo(Vetor2D vet1)
        {
            return Math.Acos(prodEscalar(vet1) / (norma() * vet1.norma()));
        }

        public Vetor2D multiplica(double escalar)
        {
            Vetor2D aux = new Vetor2D(escalar * x, escalar * y);
            return aux;
        }

        public Vetor2D soma(Vetor2D vet1)
        {
            Vetor2D aux = new Vetor2D(x + vet1.getX(), y + vet1.getY());
            return aux;
        }

        public Vetor2D projVetor(Vetor2D vet1)
        {
            return vet1.multiplica(prodEscalar(vet1) / Math.Pow(vet1.norma(), 2));
        }

    }
}
