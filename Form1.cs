using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_SIM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDistUniformeOnClick(object sender, EventArgs e)
        {
            new Formularios.frmDistUniforme().Show();
        }

        private void btnDistExpNegativaOnClick(object sender, EventArgs e)
        {
            new Formularios.frmDistExpNegativa().Show();
        }

        private void btnDistNormalOnClick(object sender, EventArgs e)
        {
            new Formularios.frmDistNormal().Show();
        }

        private void btnDistPoissonOnClick(object sender, EventArgs e)
        {
            new Formularios.frmDistPoisson().Show();
        }
    }
}
