using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_SIM
{
    class GeneradorExpNegativa
    {
        private int cantNumeros { get; set; }
        private double media { get; set; }
        private double lambda{ get; set; }

        public GeneradorExpNegativa(int cantNumeros, double media, double lambda)
        {
            if (cantNumeros < 1) cantNumeros = 100; 
            this.cantNumeros = cantNumeros;
            this.media = media;
            this.lambda = lambda;
        }

        public GeneradorExpNegativa(int cantNumeros, double media)
        {
            if (cantNumeros < 1) cantNumeros = 100;
            this.cantNumeros = cantNumeros;
            this.media = media;
        }

        public List<double> Generar()
        {
            List<double> nros = new List<double>();
            Random random = new Random();
            for (int i = 0; i < cantNumeros; i++)
            {
                double RND = random.NextDouble();
                nros.Add(-media * Math.Log(1 - RND));
            }
            return nros;
        }
    }
}
