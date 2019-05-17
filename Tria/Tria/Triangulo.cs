using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tria
{
    class Triangulo
    {
        private double ladoA;
        private double ladoB;
        private double ladoC;

        public double LadoA { get => ladoA; set => ladoA = value; }
        public double LadoB { get => ladoB; set => ladoB = value; }
        public double LadoC { get => ladoC; set => ladoC = value; }

        public double CalculaArea()
        {
            double p = (LadoA + LadoB + ladoC)/2;
            double area =  
    Math.Sqrt( ((p * p)-(p* ladoA)) * ((p * p - p*ladoC) - (ladoB * p) + (ladoB * ladoC)) );
            return (area);
        }
        public double CalculaPerimetro()
        {
            double perimetro = 0;
            return (perimetro);
        }


    }
}
