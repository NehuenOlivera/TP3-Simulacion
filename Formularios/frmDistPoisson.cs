using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace TP3_SIM.Formularios
{
    public partial class frmDistPoisson : Form
    {
        private GeneradorPoisson generador;
        private GeneradorChiPoisson generadorChiPoisson;
        public frmDistPoisson()
        {
            InitializeComponent();
        }

        private void frmDistPoisson_Load(object sender, EventArgs e)
        {
        }
        private void btnGenerarPoisson_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(txtCantNum.Text) <= 0) throw new ArgumentException("La Cantidad de Numeros a Generar debe ser mayor a cero...");
                if (String.IsNullOrEmpty(txtLambda.Text) || String.IsNullOrEmpty(txtCantNum.Text)) throw new ArgumentException("Te falto ingresar los datos requeridos...");
                gridDistPoisson.Rows.Clear();
                double lambda = Convert.ToDouble(txtLambda.Text);
                int cantidad = Convert.ToInt32(txtCantNum.Text);
                generador = new GeneradorPoisson(lambda);
                List<int> lista = generador.Generar(cantidad);
                int cont = 1;
                foreach (double rnd in lista)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    DataGridViewTextBoxCell iteracion = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell nroAleatorio = new DataGridViewTextBoxCell();
                    iteracion.Value = cont;
                    nroAleatorio.Value = rnd.ToString();
                    cont++;
                    fila.Cells.Add(iteracion);
                    fila.Cells.Add(nroAleatorio);
                    gridPoisson.Rows.Add(fila);
                }
                List<int> frecobs = new List<int>();
                List<int> listaordenada = lista.OrderBy(n => n).Distinct().ToList();
                foreach (var item in lista.OrderBy(n => n).GroupBy(x => x))
                {
                    frecobs.Add(item.Count());
                }
                List<double> probesperadas = new List<double>();
                List<double> frecesperadas = new List<double>();
                for (int i = 0; i < listaordenada.Count(); i++)
                {
                    DataGridViewRow fila2 = new DataGridViewRow();
                    DataGridViewTextBoxCell valor = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell colFrecObs = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell colProbEsp = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell colFrecEsp = new DataGridViewTextBoxCell();
                    double probabilidad = (Math.Pow(lambda, listaordenada[i]) * Math.Exp(-lambda)) / Enumerable.Range(1, listaordenada[i]).Aggregate(1, (p, item) => p * item);
                    frecesperadas.Add(Math.Round(probabilidad * lista.Count(), 2));
                    valor.Value = listaordenada[i];
                    colFrecObs.Value = frecobs[i];
                    colProbEsp.Value = probabilidad.ToString("F2");
                    colFrecEsp.Value = (probabilidad * lista.Count()).ToString("F2");
                    fila2.Cells.Add(valor);
                    fila2.Cells.Add(colFrecObs);
                    fila2.Cells.Add(colProbEsp);
                    fila2.Cells.Add(colFrecEsp);
                    gridDistPoisson.Rows.Add(fila2);
                }
                // Generar el gráfico
                chartPoissonChi.Series.Clear();
                chartPoissonChi.ResetAutoValues();
                Series serieObservada = new Series();
                Series serieEsperada = new Series();

                for (int i = 0; i < listaordenada.Count(); i++)
                {
                    serieObservada.Points.AddXY($"{listaordenada[i]}", frecobs[i]);
                    serieEsperada.Points.AddXY($"{listaordenada[i]}", frecesperadas[i]);
                }

                serieObservada.Name = "Frec. Observada";
                serieEsperada.Name = "Frec. Esperada";
                serieEsperada.IsValueShownAsLabel = true;
                serieObservada.IsValueShownAsLabel = true;
                chartPoissonChi.ChartAreas[0].AxisX.Interval = 1;
                chartPoissonChi.Series.Add(serieObservada);
                chartPoissonChi.Series.Add(serieEsperada);
                chartPoissonChi.Update();
                List<double> frecobsdouble = frecobs.Select(i => (double)i).ToList();
                List<double> extremossup = listaordenada.Select(i => (double)i).ToList();
                generadorChiPoisson = new GeneradorChiPoisson(extremossup, extremossup,frecobsdouble,frecesperadas,listaordenada);
                generadorChiPoisson.CargarTablaChi(gridChiCuadradoPoisson);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
