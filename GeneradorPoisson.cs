using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_SIM
{
    class GeneradorPoisson
    { 
        double lambda,a, p;
        int x;
        public GeneradorPoisson(Double lambda)
        {
            this.lambda = lambda;

        }

        public List<decimal> Generar(int cantidad)
        {
            p = 1;
            x = -1;
            a = Math.Exp(-lambda);
            Random rand = new Random();
            List<decimal> lista = new List<decimal>();
            for (int i = 0; i < cantidad; i++)
            {
                p = 1;
                x = -1;
                do
                {
                    double f = Convert.ToDouble(rand.NextDouble());
                    p *= f;
                    x += 1;

                } while (p >= a);

                lista.Add(x);
            }
            return lista;
        }
    }
}
