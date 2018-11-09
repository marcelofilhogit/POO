using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor3D
{
    class Vetor3D : Vetor2D //Herança
    {
        //Atributos
        private double z;

        //Metodos Construtor
        public Vetor3D() : base()
        {
            z = 0.0;
        }

        public Vetor3D(double _x, double _y, double _z) : base(_x, _y)
        {
            z = _z;
        }

        //Método get
        public double getZ()
        {
            return z;
        }

        //Método set
        public void setZ(double _z)
        {
            z = _z;
        }

        public override double norma()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public Vetor3D prodVetorial(Vetor3D vetor3D)
        {
            Vetor3D vetor = new Vetor3D(y * vetor3D.z - z * vetor3D.y,
                                        z * vetor3D.x - x * vetor3D.z,
                                        x * vetor3D.y - y * vetor3D.x);
            return vetor;
        }

        public String imprimeVetor()
        {
            return " ( " + x + ", " + y + ", " + z + " ) ";
        }

    }
}
