
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP3_SIM
{
    class GeneradorChiNormal
    {
        private List<double> numerosDistrNormal { get; set; }
        private List<double> frecObservada { get; set; }
        private List<double> probEsperada { get; set; }
        private List<double> frecEsperada { get; set; }
        private List<string> listaIntervalos { get; set; }
        private List<double> marcasDeClase { get; set; }
        private int intervalo { get; set; }
        private List<double> extremosSuperiores { get; set; }
        private List<double> extremosInferiores { get; set; }
        private Chart graficoNormal { get; set; }
        private double media;
        private double desviacion;
        private bool impar;
        private int cantidadNum;
        private double anchoIntervalos;

        public GeneradorChiNormal(List<double> listaNumerosNormal, int intervalo, Chart grafico, double media, double desviacion, bool impar)
        {
            this.numerosDistrNormal = listaNumerosNormal;
            this.listaIntervalos = new List<string>();
            this.intervalo = intervalo;
            this.frecObservada = new List<double>(new double[intervalo]);
            this.probEsperada = new List<double>(new double[intervalo]);
            this.frecEsperada = new List<double>(new double[intervalo]);
            this.marcasDeClase = new List<double>(new double[intervalo]);
            this.extremosInferiores = new List<double>(new double[intervalo]);
            this.extremosSuperiores = new List<double>(new double[intervalo]);
            this.graficoNormal = grafico;
            this.media = media;
            this.desviacion = desviacion;
            this.impar = impar;
            this.cantidadNum = impar == true ? numerosDistrNormal.Count - 1 : numerosDistrNormal.Count;
            this.anchoIntervalos = 0;
            grafico.Series.Clear();
        }

        public void CalcularIntervalos()
        {
            // Calculo de intervalos

            double minDeLista = numerosDistrNormal.Min();
            double maxDeLista = numerosDistrNormal.Max();

            //Calculo de rango
            double rangoLista;

            if (minDeLista > 0 && maxDeLista > 0)
            {
                rangoLista = Math.Abs(maxDeLista) - Math.Abs(minDeLista);
            }
            else
            {
                rangoLista = (maxDeLista) + Math.Abs(minDeLista);
            }

            //Calculo ancho de intervalos
            anchoIntervalos = rangoLista / Convert.ToDouble(intervalo);

            // Agrego el primer intervalo inferior
            double intervaloInferior = minDeLista;
            extremosInferiores[0] = (intervaloInferior);
            // Agrego el primer intervalo superior
            double intervaloSuperior = minDeLista + anchoIntervalos;
            extremosSuperiores[0] = (intervaloSuperior);

            //Agrego primer Marca de clase

            marcasDeClase[0] = Math.Truncate(100 * (intervaloInferior + intervaloSuperior) / 2) / 100;

            // Agrego primer label de la lista de intervalos
            string intervaloString = $"[{intervaloInferior.ToString("F2")},{intervaloSuperior.ToString("F2")}]";
            listaIntervalos.Add(intervaloString);

            for (int i = 1; i < intervalo; i++)
            {
                intervaloInferior += anchoIntervalos;
                intervaloSuperior += anchoIntervalos;
                extremosInferiores[i] = (intervaloInferior);
                extremosSuperiores[i] = (intervaloSuperior);
                intervaloString = $"[{intervaloInferior.ToString("F2")}-{intervaloSuperior.ToString("F2")}]";
                listaIntervalos.Add(intervaloString);

                marcasDeClase[i] = Math.Truncate(100 * ((intervaloInferior + intervaloSuperior) / 2)) / 100;
            }


        }

        public void CalcularFrecObservada()
        {
            for (int i = 0; i < cantidadNum; i++)
            {
                for (int j = 0; j < extremosSuperiores.Count; j++)
                {
                    if (numerosDistrNormal[i] < extremosSuperiores[j] || j == extremosSuperiores.Count - 1)
                    {
                        frecObservada[j]++;
                        break;
                    }
                }
            }
        }

        public void CalcularFrecEsperada()
        {

            double prob;
            double calculoIntermedio;

            for (int i = 0; i < intervalo; i++)
            {
                //Calculo del exponente del exponencial

                calculoIntermedio = ((Math.Pow(((marcasDeClase[i] - media) / desviacion), 2)) * -0.5);

                Console.WriteLine("Calculo Intermedio: " + calculoIntermedio);

                //Calculo de probabilidad 
                prob = ((Math.Exp(calculoIntermedio)) * anchoIntervalos) / (desviacion * Math.Sqrt(2 * Math.PI));

                probEsperada[i] = Math.Truncate(10000 * (prob)) / 10000;

                //Calculo de frecuencia esperada

                frecEsperada[i] = Math.Truncate(10000 * (prob * cantidadNum)) / 10000;


            }

        }

        public void GenerarGraficoNormal()
        {
            Series serieObservada = new Series();
            Series serieEsperada = new Series();
            for (int i = 0; i < intervalo; i++)
            {
                serieObservada.Points.AddXY(listaIntervalos[i], frecObservada[i]);
                serieEsperada.Points.AddXY(listaIntervalos[i], frecEsperada[i]);
            }
            serieObservada.Name = "Frecuencia observada";
            serieEsperada.Name = "Frecuencia esperada";

            graficoNormal.ChartAreas[0].AxisX.Interval = 1;
            serieEsperada.IsValueShownAsLabel = true;
            serieObservada.IsValueShownAsLabel = true;

            graficoNormal.Series.Add(serieObservada);
            graficoNormal.Series.Add(serieEsperada);

        }

        public void CargarTablaDistribucion(DataGridView gridDistribucion)
        {
            gridDistribucion.Rows.Clear();
            for (int i = 0; i < intervalo; i++)
            {
                DataGridViewRow fila = new DataGridViewRow();
                DataGridViewTextBoxCell colIntervalo = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell colMarcaClase = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell colFrecObservada = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell colProbEsperada = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell colFrecEsperada = new DataGridViewTextBoxCell();


                colIntervalo.Value = listaIntervalos[i];
                colMarcaClase.Value = marcasDeClase[i];
                colFrecObservada.Value = frecObservada[i];
                colProbEsperada.Value = probEsperada[i];
                colFrecEsperada.Value = frecEsperada[i];



                fila.Cells.Add(colIntervalo);
                fila.Cells.Add(colMarcaClase);
                fila.Cells.Add(colFrecObservada);
                fila.Cells.Add(colProbEsperada);
                fila.Cells.Add(colFrecEsperada);


                gridDistribucion.Rows.Add(fila);
            }

        }

        public void CargarTablaChi(DataGridView gridChi)
        {
            List<Tuple<double, double, double, double>> lista = AgruparFrecuencias();
            gridChi.Rows.Clear();

            // Calculo de C y CAcum
            List<double> listaCAcum = new List<double>(new double[lista.Count]);
            List<double> listaC = new List<double>(new double[lista.Count]);
            double acumulador = 0;
            for (int i = 0; i < listaC.Count; i++)
            {
                listaC[i] = Math.Truncate(10000 * (Math.Pow(lista[i].Item3 - lista[i].Item4, 2) / lista[i].Item4)) / 10000;
                listaCAcum[i] = Math.Truncate(10000 * (listaC[i] + acumulador)) / 10000;
                acumulador += listaC[i];
            }

            for (int i = 0; i < lista.Count; i++)
            {
                DataGridViewRow fila = new DataGridViewRow();

                DataGridViewTextBoxCell colDesde = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell colHasta = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell colFrecObs = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell colFrecEsp = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell colC = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell colCAcum = new DataGridViewTextBoxCell();

                colDesde.Value = Math.Truncate(100*(lista[i].Item1))/100;
                colHasta.Value = Math.Truncate(100*(lista[i].Item2))/100;
                colFrecObs.Value = lista[i].Item3;
                colFrecEsp.Value = lista[i].Item4;
                colC.Value = listaC[i];
                colCAcum.Value = listaCAcum[i];

                fila.Cells.Add(colDesde);
                fila.Cells.Add(colHasta);
                fila.Cells.Add(colFrecObs);
                fila.Cells.Add(colFrecEsp);
                fila.Cells.Add(colC);
                fila.Cells.Add(colCAcum);

                gridChi.Rows.Add(fila);


            }
        }


        public List<Tuple<double, double, double, double>> AgruparFrecuencias()
        {
            List<Tuple<double, double, double, double>> lista = AcumuladorDeFrecuencias.crearTuplas(extremosInferiores, extremosSuperiores, frecObservada, frecEsperada);
            List<Tuple<double, double, double, double>> listaAcum = AcumuladorDeFrecuencias.agrupar(5, lista) ;

            listaAcum.ForEach(Console.WriteLine);

            return listaAcum;
        }




    }
}
