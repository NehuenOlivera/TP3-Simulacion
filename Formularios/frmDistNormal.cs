using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_SIM.Formularios
{
    public partial class frmDistNormal : Form
    {
        public frmDistNormal()
        {
            InitializeComponent();
            cmbCantIntervalosNormal.Items.Add("5");
            cmbCantIntervalosNormal.Items.Add("10");
            cmbCantIntervalosNormal.Items.Add("15");
            cmbCantIntervalosNormal.Items.Add("20");
            cmbCantIntervalosNormal.SelectedItem = "5";
        }

        private void OnClickGenerarNormal(object sender, EventArgs e)
        {
            int cantNumeros = Int32.Parse(txtCantNumNormal.Text);
            double media = Double.Parse(txtMediaNormal.Text);
            double desviacion = Double.Parse(txtDesviacionNormal.Text);
            Int32 intervalos = Int32.Parse(cmbCantIntervalosNormal.Text);


            GeneradorNormal generadorNormal = new GeneradorNormal(cantNumeros, media, desviacion);

            List<double> numDistribucionNormal = generadorNormal.CalcularNormal();

            generadorNormal.CargarTablaNumeros(gridNumDistNormal);

            GeneradorChiNormal generadorChi = new GeneradorChiNormal(numDistribucionNormal, intervalos, grafNomal);

            generadorChi.CalcularIntervalos();
            generadorChi.CalcularFrecObservada();
            generadorChi.GenerarGraficoNormal();
            generadorChi.CargarTablaChi(gridChi);
        }
    }
}
