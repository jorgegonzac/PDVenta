namespace PDVenta
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.btnFinanzas = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministracion.Image = global::PDVenta.Properties.Resources.AdministracionActivo;
            this.btnAdministracion.Location = new System.Drawing.Point(463, 45);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Size = new System.Drawing.Size(105, 105);
            this.btnAdministracion.TabIndex = 0;
            this.btnAdministracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdministracion.UseVisualStyleBackColor = true;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            // 
            // btnFinanzas
            // 
            this.btnFinanzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanzas.Image = global::PDVenta.Properties.Resources.FinanzasActivo;
            this.btnFinanzas.Location = new System.Drawing.Point(574, 45);
            this.btnFinanzas.Name = "btnFinanzas";
            this.btnFinanzas.Size = new System.Drawing.Size(105, 105);
            this.btnFinanzas.TabIndex = 1;
            this.btnFinanzas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFinanzas.UseVisualStyleBackColor = true;
            this.btnFinanzas.Click += new System.EventHandler(this.btnFinanzas_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Image = global::PDVenta.Properties.Resources.VentasActivo;
            this.btnVentas.Location = new System.Drawing.Point(352, 45);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(105, 105);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmacen.Image = global::PDVenta.Properties.Resources.AlmacenActivo;
            this.btnAlmacen.Location = new System.Drawing.Point(685, 45);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(105, 105);
            this.btnAlmacen.TabIndex = 3;
            this.btnAlmacen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlmacen.UseVisualStyleBackColor = true;
            this.btnAlmacen.Click += new System.EventHandler(this.btnAlmacen_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Image = global::PDVenta.Properties.Resources.ComprasActivo;
            this.btnCompras.Location = new System.Drawing.Point(241, 45);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(105, 105);
            this.btnCompras.TabIndex = 4;
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Location = new System.Drawing.Point(12, 156);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(984, 394);
            this.pnlPrincipal.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.btnCompras);
            this.Controls.Add(this.btnAlmacen);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnFinanzas);
            this.Controls.Add(this.btnAdministracion);
            this.Name = "FormMain";
            this.Text = "PDVenta";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.Button btnFinanzas;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Panel pnlPrincipal;


    }
}

