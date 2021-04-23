using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_SIM.Formularios
{
    public partial class frmDistPoisson : Form
    {
        private GeneradorPoisson generador;
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
                
                double lambda = Convert.ToDouble(txtLambda.Text);

                int cantidad = Convert.ToInt32(txtCantNum.Text);

                generador = new GeneradorPoisson(lambda);

                List<decimal> lista = generador.Generar(cantidad);
                int cont = 1;
                foreach (decimal rnd in lista)
                {
                    Console.WriteLine(rnd.ToString("F4"));
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

            }
            catch (ArgumentException ex)
            {

                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
