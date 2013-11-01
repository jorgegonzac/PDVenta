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
        public AdministracionForm admForm;
        public AlmacenForm almForm;
        public ComprasForm comForm;
        public VentasForm venForm;
        public FinanzasForm finForm;

        public FormMain()
        {
            InitializeComponent();

            btnAdministracion.FlatAppearance.BorderSize = 0;
            btnAdministracion.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            btnFinanzas.FlatAppearance.BorderSize = 0;
            btnFinanzas.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            btnAlmacen.FlatAppearance.BorderSize = 0;
            btnAlmacen.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            admForm = new AdministracionForm();
            almForm = new AlmacenForm();
            comForm = new ComprasForm();
            venForm = new VentasForm();
            finForm = new FinanzasForm();

            admForm.TopLevel = false;
            almForm.TopLevel = false;
            comForm.TopLevel = false;
            venForm.TopLevel = false;
            finForm.TopLevel = false;

            try
            {
                pnlPrincipal.Controls.Add(admForm);
                pnlPrincipal.Controls.Add(almForm);
                pnlPrincipal.Controls.Add(comForm);
                pnlPrincipal.Controls.Add(venForm);
                pnlPrincipal.Controls.Add(finForm);
            }
            catch(Exception e) {
                System.Console.WriteLine(e.Message);
            }


        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //FormMainload
            //HOLI jorge
            //Holi edu TONTOs
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            admForm.Hide(); btnAdministracion.Image = Properties.Resources.AdministracionInactivo;
            almForm.Hide(); btnAlmacen.Image = Properties.Resources.AlmacenInactivo;
            venForm.Hide(); btnVentas.Image = Properties.Resources.VentasInactivo;
            finForm.Hide(); btnFinanzas.Image = Properties.Resources.FinanzasInactivo;
            comForm.Show(); btnCompras.Image = Properties.Resources.ComprasActivo;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            admForm.Hide(); btnAdministracion.Image = Properties.Resources.AdministracionInactivo;
            almForm.Hide(); btnAlmacen.Image = Properties.Resources.AlmacenInactivo;
            comForm.Hide(); btnCompras.Image = Properties.Resources.ComprasInactivo;
            finForm.Hide(); btnFinanzas.Image = Properties.Resources.FinanzasInactivo;
            venForm.Show(); btnVentas.Image = Properties.Resources.VentasActivo;
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            venForm.Hide(); btnVentas.Image = Properties.Resources.VentasInactivo;
            almForm.Hide(); btnAlmacen.Image = Properties.Resources.AlmacenInactivo;
            comForm.Hide(); btnCompras.Image = Properties.Resources.ComprasInactivo;
            finForm.Hide(); btnFinanzas.Image = Properties.Resources.FinanzasInactivo;
            admForm.Show(); btnAdministracion.Image = Properties.Resources.AdministracionActivo;
        }

        private void btnFinanzas_Click(object sender, EventArgs e)
        {
            admForm.Hide(); btnAdministracion.Image = Properties.Resources.AdministracionInactivo;
            almForm.Hide(); btnAlmacen.Image = Properties.Resources.AlmacenInactivo;
            comForm.Hide(); btnCompras.Image = Properties.Resources.ComprasInactivo;
            venForm.Hide(); btnVentas.Image = Properties.Resources.VentasInactivo;
            finForm.Show(); btnFinanzas.Image = Properties.Resources.FinanzasActivo;
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            admForm.Hide(); btnAdministracion.Image = Properties.Resources.AdministracionInactivo;
            comForm.Hide(); btnCompras.Image = Properties.Resources.ComprasInactivo;
            finForm.Hide(); btnFinanzas.Image = Properties.Resources.FinanzasInactivo;
            venForm.Hide(); btnVentas.Image = Properties.Resources.VentasInactivo;
            almForm.Show(); btnAlmacen.Image = Properties.Resources.AlmacenActivo;
        }
    }
}
