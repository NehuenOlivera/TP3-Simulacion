using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP3_SIM
{
    class GeneradorChiNormal
    {
        private List<double> numerosDistrNormal;
        private List<double> frecObservada;
        private List<string> listaIntervalos;
        private int intervalo;
        private List<double> extremosSuperiores;
        private List<double> extremosInferiores;
        private Chart graficoNormal { get; set; }

        public GeneradorChiNormal(List<double> listaNumerosNormal, int intervalo, Chart grafico)
        {
            this.numerosDistrNormal = listaNumerosNormal;
            this.listaIntervalos = new List<string>();
            this.intervalo = intervalo;
            this.frecObservada = new List<double>(new double[intervalo]);
            this.extremosInferiores = new List<double>(new double[intervalo]);
            this.extremosSuperiores = new List<double>(new double[intervalo]);
            this.graficoNormal = grafico;
            grafico.Series.Clear();
        }

        public void CalcularIntervalos()
        {
            // Calculo de intervalos
            
            double minDeLista = numerosDistrNormal.Min();
            double maxDeLista = numerosDistrNormal.Max();

            double rangoLista = Math.Abs(minDeLista) + Math.Abs(maxDeLista);
            double anchoIntervalos = rangoLista / Convert.ToDouble(intervalo);

            // Agrego el primer intervalo inferior
            double intervaloInferior = minDeLista;
            extremosInferiores[0] = (intervaloInferior);
            // Agrego el primer intervalo superior
            double intervaloSuperior = minDeLista + anchoIntervalos;
            extremosSuperiores[0] = (intervaloSuperior);

            // Agrego primer label de la lista de intervalos
            string intervaloString = $"[{intervaloInferior.ToString("F2")},{intervaloSuperior.ToString("F2")}]";
            listaIntervalos.Add(intervaloString);

            for (int i = 1; i < intervalo; i++)
            {
                intervaloInferior += anchoIntervalos;
                intervaloSuperior += anchoIntervalos;
                extremosInferiores[i] = (intervaloInferior);
                extremosSuperiores[i] = (intervaloSuperior);
                intervaloString = $"[{intervaloInferior.ToString("F2")},{intervaloSuperior.ToString("F2")}]";
                listaIntervalos.Add(intervaloString);
            }
            Console.WriteLine("Frec obs");
            Console.WriteLine(frecObservada.Count);
            Console.WriteLine("Lista inte");
            Console.WriteLine(listaIntervalos.Count);
        }

        public void CalcularFrecObservada()
        {
            for (int i = 0; i < numerosDistrNormal.Count; i++)
            {
                for (int j = 0; j < extremosSuperiores.Count; j++)
                {
                    if(numerosDistrNormal[i] < extremosSuperiores[j])
                    {
                        frecObservada[j]++;
                        break;
                    }
                }
            }
        }

        public void GenerarGraficoNormal()
        {
            Series serieObservada = new Series();
            for (int i = 0; i < intervalo; i++)
            {
                serieObservada.Points.AddXY(listaIntervalos[i], frecObservada[i]);
            }
            serieObservada.Name = "Frecuencia observada";
            graficoNormal.Series.Add(serieObservada);
            
        }

        public void CargarTablaChi(DataGridView gridChi)
        {
            gridChi.Rows.Clear();
            for (int i = 0; i < intervalo; i++)
            {
                DataGridViewRow fila = new DataGridViewRow();
                DataGridViewTextBoxCell colIntervalo = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell colFrecObservada = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell colFrecEsperada = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell colC = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell colCAcum = new DataGridViewTextBoxCell();

                colIntervalo.Value = listaIntervalos[i];
                colFrecObservada.Value = frecObservada[i];

                fila.Cells.Add(colIntervalo);
                fila.Cells.Add(colFrecObservada);

                gridChi.Rows.Add(fila);
            }
        }
    }
}
