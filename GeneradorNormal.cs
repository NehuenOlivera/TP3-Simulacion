using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_SIM
{
    class GeneradorNormal
    {
        private double media { get; set; }
        private double desviacion { get; set; }
        private int cantNum { get; set; }
        private List<double> numerosDistNormal { get; set; }
        private List<double> numerosRandom { get; set; }



        public GeneradorNormal(int cantidad, double media, double desviacion)

        {
            this.media = media;
            this.desviacion = desviacion;
            this.cantNum = cantidad;
            this.numerosDistNormal = new List<double>();
            this.numerosRandom = new List<double>();



        }


        public void CalcularNormal()
        {
            Random random1 = new Random();
            

            double rnd1 = 0;
            double rnd2 = 0;

            for (int i = 1; i < cantNum + 1; i++)
            {
                

                if (i % 2 != 0)
                {
                    //Calculo de numeros randoms
                    rnd1 = random1.NextDouble();
                    rnd2 = random1.NextDouble();

                 
                    //Agrego a lista de numeros randoms
                    numerosRandom.Add(rnd1);
                    numerosRandom.Add(rnd2);

                    //Calculo n1
                    double n1 = ((Math.Sqrt(-2 * Math.Log(rnd1))) * (Math.Cos(2 * Math.PI * rnd2))) * desviacion + media;

                    numerosDistNormal.Add(n1);

                }
                

                //Calculo n2
                double n2 = ((Math.Sqrt(-2 * Math.Log(rnd1))) * (Math.Sin(2 * Math.PI * rnd2))) * desviacion + media;
                numerosDistNormal.Add(n2);

            }

            Console.Write(numerosRandom);

            Console.Write(numerosDistNormal);
        }

        public void CargarTablaNumeros(DataGridView datos)
        {
            int? filas = cantNum % 2 == 0 ? cantNum/2 : cantNum + 1/2;

            for (int i = 0; i < filas; i+=2)
            {

                DataGridViewRow fila = new DataGridViewRow();
                DataGridViewTextBoxCell random1 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell random2 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell num1 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell num2= new DataGridViewTextBoxCell();

                random1.Value = numerosRandom[i];
                random2.Value = numerosRandom[i + 1];
                num1.Value = numerosDistNormal[i];
                num2.Value = numerosDistNormal[i + 1];


                fila.Cells.Add(random1);
                fila.Cells.Add(random2);
                fila.Cells.Add(num1);
                fila.Cells.Add(num2);

                datos.Rows.Add(fila);

            }

        }
    }
}
