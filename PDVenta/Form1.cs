using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDVenta
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            buttonAdministracion.FlatAppearance.BorderSize = 0;
            buttonAdministracion.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            buttonVentas.FlatAppearance.BorderSize = 0;
            buttonVentas.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            buttonCompras.FlatAppearance.BorderSize = 0;
            buttonCompras.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            buttonFinanzas.FlatAppearance.BorderSize = 0;
            buttonFinanzas.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            buttonAlmacen.FlatAppearance.BorderSize = 0;
            buttonAlmacen.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
