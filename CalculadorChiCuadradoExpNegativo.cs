using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP3_SIM
{
    class CalculadorChiCuadradoExpNegativo
    {
        private DataGridView grid { get; set; }
        private int cantIntervalos { get; set; }
        private List<double> nrosAleatorios { get; set; }
        private double anchoIntervalo { get; set; }
        private Chart graficoChi { get; set; }
        private double min { get; set; }
        private double max { get; set; }
        private double lambda { get; set; }

        public CalculadorChiCuadradoExpNegativo(DataGridView grid, int cantIntervalos, List<double> nrosAleatorios, Chart graficoChi, double lambda)
        {
            this.grid = grid;
            this.cantIntervalos = cantIntervalos;
            this.nrosAleatorios = nrosAleatorios;
            this.graficoChi = graficoChi;
            graficoChi.Series.Clear();
            min = nrosAleatorios.Min();
            max = nrosAleatorios.Max();
            anchoIntervalo = (max - min) / (double)cantIntervalos;
            this.lambda = lambda;
        }

        public void Calcular()
        {
            Series serieObservada = new Series();
            Series serieEsperada = new Series();
            List<double> extremosSuperiores = new List<double>();
            List<double> extremosInferiores = new List<double>();
            List<string> intervalosLabel = new List<string>();
            List<double> probabilidadCAnchoIntervalo = new List<double>();
            List<double> frecEsperadas = new List<double>();
            for (int i = 0; i < cantIntervalos; i++)
            {
                double intervaloInferior = min + (i * anchoIntervalo);
                double intervaloSuperior = ((i + 1) * anchoIntervalo) - 0.0001;
                string intervalo = $"[{intervaloInferior.ToString("F2")}, {intervaloSuperior.ToString("F2")}]";
                intervalosLabel.Add(intervalo);
                extremosSuperiores.Add(intervaloSuperior);
                extremosInferiores.Add(intervaloInferior);
                double prob = (1 - Math.Exp(-lambda * extremosSuperiores[i])) - (1 - Math.Exp(-lambda * extremosInferiores[i]));
                probabilidadCAnchoIntervalo.Add(prob);
                frecEsperadas.Add(Math.Round(prob * (double)nrosAleatorios.Count, 4));
            }

            List<int> listaFrecObservada = new List<int>(new int[cantIntervalos]);
            for (int i = 0; i < nrosAleatorios.Count; i++)
            {
                for (int j = 0; j < extremosSuperiores.Count; j++)
                {
                    if (nrosAleatorios[i] < extremosSuperiores[j])
                    {
                        listaFrecObservada[j]++;
                        break;
                    }
                }
            }
            double AcumC = 0;
            for (int i = 0; i < cantIntervalos; i++)
            {
                DataGridViewRow fila = new DataGridViewRow();
                DataGridViewTextBoxCell intervalo = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell observado = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell esperado = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell c = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cAcum = new DataGridViewTextBoxCell();

                intervalo.Value = intervalosLabel[i];
                observado.Value = listaFrecObservada[i];
                esperado.Value = frecEsperadas[i];
                c.Value = Math.Round((Math.Pow((listaFrecObservada[i] - frecEsperadas[i]), 2) / frecEsperadas[i]), 4);
                AcumC += Math.Round((double)c.Value,4);
                cAcum.Value = AcumC;

                //Agregando las celdas a la fila...
                fila.Cells.Add(intervalo);
                fila.Cells.Add(observado);
                fila.Cells.Add(esperado);
                fila.Cells.Add(c);
                fila.Cells.Add(cAcum);

                //Agregando la fila a la tabla...
                grid.Rows.Add(fila);

                serieObservada.Points.AddXY(intervalosLabel[i], listaFrecObservada[i]);
                serieEsperada.Points.AddXY(intervalosLabel[i], frecEsperadas[i]);
            }

            serieObservada.Name = "Frec.Observada";
            serieEsperada.Name = "Frec.Esperada";
            serieEsperada.IsValueShownAsLabel = true;
            serieObservada.IsValueShownAsLabel = true;
            graficoChi.ChartAreas[0].AxisX.Interval = 1;

            graficoChi.Series.Add(serieEsperada);
            graficoChi.Series.Add(serieObservada);

            graficoChi.Update();
            
        }



    }
}
