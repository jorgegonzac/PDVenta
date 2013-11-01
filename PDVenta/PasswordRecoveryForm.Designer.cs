namespace PDVenta
{
    partial class PasswordRecoveryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasenaAdmin = new System.Windows.Forms.Label();
            this.txtContrasenaAdmin = new System.Windows.Forms.TextBox();
            this.lblNuevaContrasena = new System.Windows.Forms.Label();
            this.txtNuevaContrasena = new System.Windows.Forms.TextBox();
            this.lblConfirmarContrasena = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.picAceptar = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAceptar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(24, 45);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(107, 29);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(31, 77);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(353, 34);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblContrasenaAdmin
            // 
            this.lblContrasenaAdmin.AutoSize = true;
            this.lblContrasenaAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.lblContrasenaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenaAdmin.Location = new System.Drawing.Point(24, 124);
            this.lblContrasenaAdmin.Name = "lblContrasenaAdmin";
            this.lblContrasenaAdmin.Size = new System.Drawing.Size(355, 29);
            this.lblContrasenaAdmin.TabIndex = 5;
            this.lblContrasenaAdmin.Text = "Contraseña del Administrador:";
            // 
            // txtContrasenaAdmin
            // 
            this.txtContrasenaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenaAdmin.Location = new System.Drawing.Point(31, 156);
            this.txtContrasenaAdmin.Name = "txtContrasenaAdmin";
            this.txtContrasenaAdmin.Size = new System.Drawing.Size(353, 34);
            this.txtContrasenaAdmin.TabIndex = 4;
            this.txtContrasenaAdmin.UseSystemPasswordChar = true;
            // 
            // lblNuevaContrasena
            // 
            this.lblNuevaContrasena.AutoSize = true;
            this.lblNuevaContrasena.BackColor = System.Drawing.SystemColors.Control;
            this.lblNuevaContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaContrasena.Location = new System.Drawing.Point(24, 200);
            this.lblNuevaContrasena.Name = "lblNuevaContrasena";
            this.lblNuevaContrasena.Size = new System.Drawing.Size(230, 29);
            this.lblNuevaContrasena.TabIndex = 7;
            this.lblNuevaContrasena.Text = "Nueva Contraseña:";
            // 
            // txtNuevaContrasena
            // 
            this.txtNuevaContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaContrasena.Location = new System.Drawing.Point(31, 232);
            this.txtNuevaContrasena.Name = "txtNuevaContrasena";
            this.txtNuevaContrasena.Size = new System.Drawing.Size(353, 34);
            this.txtNuevaContrasena.TabIndex = 6;
            this.txtNuevaContrasena.UseSystemPasswordChar = true;
            // 
            // lblConfirmarContrasena
            // 
            this.lblConfirmarContrasena.AutoSize = true;
            this.lblConfirmarContrasena.BackColor = System.Drawing.SystemColors.Control;
            this.lblConfirmarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContrasena.Location = new System.Drawing.Point(24, 284);
            this.lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            this.lblConfirmarContrasena.Size = new System.Drawing.Size(268, 29);
            this.lblConfirmarContrasena.TabIndex = 9;
            this.lblConfirmarContrasena.Text = "Confirmar Contraseña:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(31, 316);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 34);
            this.textBox1.TabIndex = 8;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAceptar.Location = new System.Drawing.Point(77, 366);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(205, 53);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // picAceptar
            // 
            this.picAceptar.BackColor = System.Drawing.Color.Transparent;
            this.picAceptar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAceptar.Image = global::PDVenta.Properties.Resources.button_check_green;
            this.picAceptar.Location = new System.Drawing.Point(288, 366);
            this.picAceptar.Name = "picAceptar";
            this.picAceptar.Size = new System.Drawing.Size(59, 53);
            this.picAceptar.TabIndex = 11;
            this.picAceptar.TabStop = false;
            this.picAceptar.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.SystemColors.Control;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(24, 441);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 29);
            this.lblInfo.TabIndex = 12;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.PaleGreen;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIniciarSesion.Location = new System.Drawing.Point(77, 366);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(205, 53);
            this.btnIniciarSesion.TabIndex = 13;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Visible = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btn_Click);
            // 
            // PasswordRecoveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 488);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.picAceptar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblConfirmarContrasena);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNuevaContrasena);
            this.Controls.Add(this.txtNuevaContrasena);
            this.Controls.Add(this.lblContrasenaAdmin);
            this.Controls.Add(this.txtContrasenaAdmin);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PasswordRecoveryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar Contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.picAceptar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasenaAdmin;
        private System.Windows.Forms.TextBox txtContrasenaAdmin;
        private System.Windows.Forms.Label lblNuevaContrasena;
        private System.Windows.Forms.TextBox txtNuevaContrasena;
        private System.Windows.Forms.Label lblConfirmarContrasena;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox picAceptar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnIniciarSesion;
    }
}