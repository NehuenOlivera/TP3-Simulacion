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
        }

        private void OnClickGenerarNormal(object sender, EventArgs e)
        {
            int cantNumeros = Int32.Parse(txtCantNumNormal.Text);
            double media = Double.Parse(txtMediaNormal.Text);
            double desviacion = Double.Parse(txtDesviacionNormal.Text);


            GeneradorNormal generadorNormal = new GeneradorNormal(cantNumeros, media, desviacion);

            generadorNormal.CalcularNormal();

            generadorNormal.CargarTablaNumeros(gridNumDistNormal);
        }
    }
}
