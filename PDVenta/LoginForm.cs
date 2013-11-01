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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblContrasenaOlvidada_Click(object sender, EventArgs e)
        {
            PasswordRecoveryForm newPassForm = new PasswordRecoveryForm();
            newPassForm.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            main.Show();
            this.Hide();
        }
    }
}
