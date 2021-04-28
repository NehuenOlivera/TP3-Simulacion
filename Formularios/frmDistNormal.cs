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
            try
            {
                int cantNumeros;
                double media, desviacion;
                if (txtCantNumNormal.Text == "") throw new ArgumentException("Ingrese una cantidad de numeros valida");
                if(!int.TryParse(txtCantNumNormal.Text, out cantNumeros)) throw new ArgumentException("No me ingreses letras por favor!");
                if (txtMediaNormal.Text == "") throw new ArgumentException("Ingrese una media valida");
                if (!double.TryParse(txtMediaNormal.Text, out media)) throw new ArgumentException("No me ingreses letras por favor!");
                if (txtDesviacionNormal.Text == "") throw new ArgumentException("Ingrese una desviacion valida");
                if (!double.TryParse(txtDesviacionNormal.Text, out desviacion)) throw new ArgumentException("No me ingreses letras por favor!");
                Int32 intervalos = Int32.Parse(cmbCantIntervalosNormal.Text);

                Console.WriteLine("media " + media);
                bool impar = true;
                if (cantNumeros % 2 == 0) impar = false;
                grafNormal.ResetAutoValues();

                GeneradorNormal generadorNormal = new GeneradorNormal(cantNumeros, media, desviacion);

                List<double> numDistribucionNormal = generadorNormal.CalcularNormal();

                generadorNormal.CargarTablaNumeros(gridNumDistNormal);

                GeneradorChiNormal generadorChi = new GeneradorChiNormal(numDistribucionNormal, intervalos, grafNormal, media, desviacion, impar);

                generadorChi.CalcularIntervalos();
                generadorChi.CalcularFrecObservada();
                generadorChi.CalcularFrecEsperada();
                generadorChi.GenerarGraficoNormal();
                generadorChi.CargarTablaDistribucion(gridDistribucion);
                generadorChi.CargarTablaChi(gridChi);        
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
