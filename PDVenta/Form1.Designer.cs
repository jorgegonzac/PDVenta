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
            this.buttonAdministracion = new System.Windows.Forms.Button();
            this.buttonFinanzas = new System.Windows.Forms.Button();
            this.buttonVentas = new System.Windows.Forms.Button();
            this.buttonAlmacen = new System.Windows.Forms.Button();
            this.buttonCompras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdministracion
            // 
            this.buttonAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdministracion.Image = global::PDVenta.Properties.Resources.AdministracionActivo;
            this.buttonAdministracion.Location = new System.Drawing.Point(463, 45);
            this.buttonAdministracion.Name = "buttonAdministracion";
            this.buttonAdministracion.Size = new System.Drawing.Size(105, 105);
            this.buttonAdministracion.TabIndex = 0;
            this.buttonAdministracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAdministracion.UseVisualStyleBackColor = true;
            // 
            // buttonFinanzas
            // 
            this.buttonFinanzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinanzas.Image = global::PDVenta.Properties.Resources.FinanzasActivo;
            this.buttonFinanzas.Location = new System.Drawing.Point(574, 45);
            this.buttonFinanzas.Name = "buttonFinanzas";
            this.buttonFinanzas.Size = new System.Drawing.Size(105, 105);
            this.buttonFinanzas.TabIndex = 1;
            this.buttonFinanzas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFinanzas.UseVisualStyleBackColor = true;
            // 
            // buttonVentas
            // 
            this.buttonVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVentas.Image = global::PDVenta.Properties.Resources.VentasActivo;
            this.buttonVentas.Location = new System.Drawing.Point(352, 45);
            this.buttonVentas.Name = "buttonVentas";
            this.buttonVentas.Size = new System.Drawing.Size(105, 105);
            this.buttonVentas.TabIndex = 2;
            this.buttonVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonVentas.UseVisualStyleBackColor = true;
            // 
            // buttonAlmacen
            // 
            this.buttonAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlmacen.Image = global::PDVenta.Properties.Resources.AlmacenActivo;
            this.buttonAlmacen.Location = new System.Drawing.Point(685, 45);
            this.buttonAlmacen.Name = "buttonAlmacen";
            this.buttonAlmacen.Size = new System.Drawing.Size(105, 105);
            this.buttonAlmacen.TabIndex = 3;
            this.buttonAlmacen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAlmacen.UseVisualStyleBackColor = true;
            // 
            // buttonCompras
            // 
            this.buttonCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompras.Image = global::PDVenta.Properties.Resources.ComprasActivo;
            this.buttonCompras.Location = new System.Drawing.Point(241, 45);
            this.buttonCompras.Name = "buttonCompras";
            this.buttonCompras.Size = new System.Drawing.Size(105, 105);
            this.buttonCompras.TabIndex = 4;
            this.buttonCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCompras.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.buttonCompras);
            this.Controls.Add(this.buttonAlmacen);
            this.Controls.Add(this.buttonVentas);
            this.Controls.Add(this.buttonFinanzas);
            this.Controls.Add(this.buttonAdministracion);
            this.Name = "FormMain";
            this.Text = "PDVenta";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdministracion;
        private System.Windows.Forms.Button buttonFinanzas;
        private System.Windows.Forms.Button buttonVentas;
        private System.Windows.Forms.Button buttonAlmacen;
        private System.Windows.Forms.Button buttonCompras;


    }
}

