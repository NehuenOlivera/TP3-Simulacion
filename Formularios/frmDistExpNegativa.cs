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
    public partial class frmDistExpNegativa : Form
    {
        private GeneradorExpNegativa generadorExpNegativa;
        private CalculadorChiCuadradoExpNegativo calculadorChiCuadradoExpNegativo;

        public frmDistExpNegativa()
        {
            InitializeComponent();

            cmbIntervalos.Items.Add("5");
            cmbIntervalos.Items.Add("10");
            cmbIntervalos.Items.Add("15");
            cmbIntervalos.Items.Add("20");
            cmbIntervalos.SelectedItem = "5";
        }

        private void OnClickRdbLambda(object sender, EventArgs e)
        {
            txtBoxLambda.Enabled = true;
            txtBoxMedia.Enabled = false;
            txtBoxMedia.Text = "";
        }

        private void OnClickRdbMedia(object sender, EventArgs e)
        {
            txtBoxMedia.Enabled = true;
            txtBoxLambda.Enabled = false;
            txtBoxLambda.Text = "";
        }

        private void OnClickBtnGenerar(object sender, EventArgs e)
        {
            try
            {
                dataGridNrosGenerados.Rows.Clear();
                gridChiCuadrado.Rows.Clear();
                double media, lambda;
                if (rdbMedia.Checked)
                {
                    if (String.IsNullOrEmpty(txtBoxMedia.Text) || String.IsNullOrWhiteSpace(txtBoxMedia.Text))
                    {
                        throw new ArgumentException("Complete el Campo Media...");
                    }
                    if(Double.TryParse(txtBoxMedia.Text, out media))
                    {
                        lambda = 1 / media;
                    }
                    else
                    {
                        throw new ArgumentException("Formato NO valido en el Campo Media...");
                    }
                }
                else
                {
                    if (String.IsNullOrEmpty(txtBoxLambda.Text) || String.IsNullOrWhiteSpace(txtBoxLambda.Text))
                    {
                        throw new ArgumentException("Complete el Campo Lambda...");
                    }
                    if (Double.TryParse(txtBoxLambda.Text, out lambda))
                    {
                        media = 1 / lambda;
                    }
                    else
                    {
                        throw new ArgumentException("Formato NO valido en el Campo Media...");
                    }
                }
                if(String.IsNullOrEmpty(txtBoxCantNumeros.Text) || String.IsNullOrWhiteSpace(txtBoxCantNumeros.Text))
                {
                    throw new ArgumentException("Complete el Campo Numeros a Generar...");
                }
                if(Int32.TryParse(txtBoxCantNumeros.Text, out int cantNumeros))
                {
                    if (cantNumeros < 1) throw new ArgumentException("Ingrese un valor positivo de Numeros a Generar...");

                    generadorExpNegativa = new GeneradorExpNegativa(cantNumeros, media);
                    List<double> nrosGenerados =  generadorExpNegativa.Generar();

                    for (int i = 0; i < nrosGenerados.Count; i++)
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        DataGridViewTextBoxCell celdaIteracion = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell celdaNroGenerado = new DataGridViewTextBoxCell();

                        celdaIteracion.Value = i + 1;
                        celdaNroGenerado.Value = nrosGenerados[i].ToString("F4");
                        fila.Cells.Add(celdaIteracion);
                        fila.Cells.Add(celdaNroGenerado);
                        dataGridNrosGenerados.Rows.Add(fila);
                    }
                    int cantIntervalos = int.Parse(cmbIntervalos.Text);
                    calculadorChiCuadradoExpNegativo = new CalculadorChiCuadradoExpNegativo(gridChiCuadrado, cantIntervalos, nrosGenerados,
                        chartExpNegativaFeFo, lambda);

                    calculadorChiCuadradoExpNegativo.Calcular();

                }
                else
                {
                    throw new ArgumentException("Formato NO valido en el Campo Numeros a Generar...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
