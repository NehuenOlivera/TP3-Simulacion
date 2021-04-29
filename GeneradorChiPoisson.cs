using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_SIM
{
    class GeneradorChiPoisson
    {
        private List<double> extremosSuperiores { get; set; }
        private List<double> extremosInferiores { get; set; }
        private List<int> listaordenada { get; set; }
        private List<double> frecObservada { get; set; }
        private List<double> frecEsperada { get; set; }
        public GeneradorChiPoisson(List<double> extremosSuperiores, List<double> extremosInferiores, List<double> frecObservada, List<double> frecEsperada, List<int> listaordenada)
        {
            this.listaordenada = listaordenada;
            this.frecObservada = frecObservada;
            this.frecEsperada = frecEsperada;
            this.extremosInferiores = extremosInferiores;
            this.extremosSuperiores = extremosSuperiores;
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
                DataGridViewTextBoxCell colIntervalo = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell colFrecObs = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell colFrecEsp = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell colC = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell colCAcum = new DataGridViewTextBoxCell();
                colIntervalo.Value = $"[{lista[i].Item1}, {lista[i].Item2}]";
                colFrecObs.Value = lista[i].Item3;
                colFrecEsp.Value = lista[i].Item4;
                colC.Value = listaC[i];
                colCAcum.Value = listaCAcum[i];
                fila.Cells.Add(colIntervalo);
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
            List<Tuple<double, double, double, double>> listaAcum = AcumuladorDeFrecuencias.agrupar(5, lista);
            return listaAcum;
        }
    }
}
