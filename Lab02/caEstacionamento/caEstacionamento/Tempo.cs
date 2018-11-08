using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEstacionamento
{
    class Tempo
    {
        //Atributos
        private int hora;
        private int min;
        private int seg;

        //Metodos Construtor 
        public Tempo()
        {
            hora = 0;
            min = 0;
            seg = 0;
        }

        public Tempo(int _hora, int _min, int _seg)
        {
            hora = _hora;
            min = _min;
            seg = _seg;
        }

        //Metodos Get
        public int getHora()
        {
            return hora;
        }

        public int getMin()
        {
            return min;
        }

        public int getSeg()
        {
            return seg;
        }

        //Metodos Set
        public void setHora(int _hora)
        {
            hora = _hora;
        }

        public void setMin(int _min)
        {
            min = _min;
        }

        public void setSeg(int _seg)
        {
            seg = _seg;
        }

        //Metodo Solicita Tempo
        public void solicitaTempo()
        {
            Console.Write("Insira a hora no formato hh:mm:ss: ");
            hora = int.Parse(Console.ReadLine());
            min = int.Parse(Console.ReadLine());
            seg = int.Parse(Console.ReadLine());
        }

        //Metodo Imprimir Tempo    
        public void imprimeTempo()
        {
            if(hora < 10)
            {
                Console.Write("0" + hora.ToString());
            }

            else
            {
                Console.Write(hora.ToString());
            }
                
            if(min < 10)
            {
                Console.Write(":0" + min.ToString());
            }

            else
            {
                Console.Write(":" + min.ToString());
            }
                
            if(seg < 10)
            {
                Console.Write(":0" + seg.ToString());
            }

            else
            {
                Console.Write(":" + seg.ToString());
            }
                
            Console.WriteLine();
        }

        //Metodo Converte Segundos    
        public int convertSegundos()
        {
            return hora * 3600 + min * 60 + seg;
        }

        //Metodo Converte Horas
        public Tempo convertHHMMSS(int _seg)
        {
            int h;
            int m;
            int s;

            h = seg / 3600;
            m = (seg - h * 3600) / 60;
            s = seg - h * 3600 - m * 60;

            Tempo objTemp = new Tempo(h, m, s);
            return objTemp;
        }


        //Metodo Adiciona Tempo
        public Tempo adicionaTempo(Tempo _t)
        {
            int segundos;
            segundos = convertSegundos() + _t.convertSegundos();
            return convertHHMMSS(segundos);
        }

        //Metodo Subtrai Tempo
        public Tempo subtraiTempo(Tempo _t)
        {
            int segundos;
            segundos = convertSegundos() - _t.convertSegundos();
            return convertHHMMSS(segundos);
        }

    }
}
