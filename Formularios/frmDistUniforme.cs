using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP3_SIM.Formularios
{
    public partial class frmDistUniforme : Form
    {
        public frmDistUniforme()
        {
            InitializeComponent();

            cmbIntervalos.Items.Add("5");
            cmbIntervalos.Items.Add("10");
            cmbIntervalos.Items.Add("15");
            cmbIntervalos.Items.Add("20");
            cmbIntervalos.SelectedItem = "5";
        }

        private void onBtnGenerarClick(object sender, EventArgs e)
        {
            double A = 0, B = 0, n = 0;
            int cantidadIntervalos = Int32.Parse(cmbIntervalos.Text);

            try
            {
                bool r1 = Double.TryParse(txtA.Text, out A);
                bool r2 = Double.TryParse(txtB.Text, out B);
                bool r3 = Double.TryParse(txtN.Text, out n);

                if(!r1)
                {
                    throw new ArgumentException("A no es un valor válido");
                }

                if(!r2)
                {
                    throw new ArgumentException("B no es un valor válido");
                }

                if(!r3)
                {
                    throw new ArgumentException("n no es un valor válido");
                }

                if(A >= B)
                {
                    throw new ArgumentException("A no puede ser mayor o igual a B");
                }

                if(n < 1)
                {
                    throw new ArgumentException("n no puede ser menor a 1");
                }

                // Calcular media y varianza
                lblMedia.Text = ((A + B) / 2).ToString("F2");
                lblVarianza.Text = (Math.Pow(B - A, 2) / 12).ToString("F2");

                // Generar los numeros random y llenarlos en la tabla
                Random generadorRandom = new Random();
                List<double> elementosGenerados = new List<double>();
                gridDistUniforme.Rows.Clear();

                for(int i = 0; i < n; i++)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    DataGridViewTextBoxCell col1 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell col2 = new DataGridViewTextBoxCell();

                    double siguienteRandom = generadorRandom.NextDouble();
                    double randomUniforme = A + (siguienteRandom * (B - A));

                    // Asserts
                    Debug.Assert(randomUniforme <= B);
                    Debug.Assert(randomUniforme >= A);

                    col1.Value = siguienteRandom.ToString("F2");
                    col2.Value = randomUniforme.ToString("F2");

                    fila.Cells.Add(col1);
                    fila.Cells.Add(col2);

                    gridDistUniforme.Rows.Add(fila);
                    elementosGenerados.Add(randomUniforme);
                }

                // Crear una lista como contador
                double intervaloInferiorAnterior = A;
                double pasos = (B - A) / cantidadIntervalos;
                List<Tuple<double, double, int>> observados = new List<Tuple<double, double, int>>();

                for(int i = 0; i < cantidadIntervalos; i ++)
                {
                    observados.Add(new Tuple<double, double, int>(intervaloInferiorAnterior, intervaloInferiorAnterior + pasos, 0));
                    intervaloInferiorAnterior += pasos;
                }


                // Contar elementos
                elementosGenerados.ForEach(delegate(double elemento) {
                    bool posicionEncontrada = false;
                    int i = 0;
                    while(!posicionEncontrada)
                    {
                       if(elemento > observados[i].Item2)
                        {
                            i += 1;
                       
                        } else
                        {
                            posicionEncontrada = true;
                        }
                    }

                    observados[i] = new Tuple<double, double, int>(observados[i].Item1, observados[i].Item2, observados[i].Item3 + 1);
                });

                // Generar el gráfico
                chartDistUniforme.Series.Clear();
                chartDistUniforme.ResetAutoValues();

                Series serieObservada = new Series();
                Series serieEsperada = new Series();

                for(int i = 0; i < cantidadIntervalos; i++)
                {
                    serieObservada.Points.AddXY($"{observados[i].Item1} - {observados[i].Item2}", observados[i].Item3);
                    serieEsperada.Points.AddXY($"{observados[i].Item1} - {observados[i].Item2}", elementosGenerados.Count / cantidadIntervalos);
                }

                serieObservada.Name = "Frec. Observada";
                serieEsperada.Name = "Frec. Esperada";
                serieEsperada.IsValueShownAsLabel = true;
                serieObservada.IsValueShownAsLabel = true;

                chartDistUniforme.ChartAreas[0].AxisX.Interval = 1;
                chartDistUniforme.Series.Add(serieObservada);
                chartDistUniforme.Series.Add(serieEsperada);  

                chartDistUniforme.Update();

                // Generar la tabla de prueba de Chi Cuadrado
                gridDistUniformePrueba.Rows.Clear();
                double cAnterior = 0;

                foreach(Tuple<double, double, int> tupla in observados)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    DataGridViewTextBoxCell colIntervalo = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell colFrecObservada = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell colFrecEsperada = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell colC = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell colCAcumulada = new DataGridViewTextBoxCell();

                    double frecObservada = tupla.Item3;
                    double frecEsperada = elementosGenerados.Count / cantidadIntervalos;
                    double c = Math.Pow((frecObservada - frecEsperada), 2) / frecEsperada;

                    colIntervalo.Value = $"{tupla.Item1} - {tupla.Item2}";
                    colFrecObservada.Value = frecObservada;
                    colFrecEsperada.Value = frecEsperada;
                    colC.Value = c.ToString("F4");
                    colCAcumulada.Value = cAnterior == 0 ? c.ToString("F4") : (c + cAnterior).ToString("F4");

                    
                    fila.Cells.Add(colIntervalo);
                    fila.Cells.Add(colFrecObservada);
                    fila.Cells.Add(colFrecEsperada);
                    fila.Cells.Add(colC);
                    fila.Cells.Add(colCAcumulada);

                    gridDistUniformePrueba.Rows.Add(fila);
                    cAnterior += c;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hubo un error", MessageBoxButtons.OK);
            }
         
        }
    }
}
