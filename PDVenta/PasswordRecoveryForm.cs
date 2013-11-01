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
    public partial class PasswordRecoveryForm : Form
    {
        public PasswordRecoveryForm()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validar la información proporcionada (Usuario, password admin)
            //Si la informacion es valida entonces hacer el cambio de contraseña
            //Si la contraseña es valida entonces se cambia el label del resultado y se cierra la ventana
            
            lblInfo.ForeColor = Color.Red;
            lblInfo.Text = "    !Contraseña modificada!";
            btnAceptar.Text = "Iniciar Sesion";
            picAceptar.Visible = true;
            btnAceptar.Visible = false;
            btnIniciarSesion.Visible = true;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
