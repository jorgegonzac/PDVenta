namespace PDVenta
{
    partial class VentasForm
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
            this.dgdVenta = new System.Windows.Forms.DataGridView();
            this.cBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadVendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarProd2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregarProd = new System.Windows.Forms.Button();
            this.txtCB = new System.Windows.Forms.TextBox();
            this.lblCB = new System.Windows.Forms.Label();
            this.btnModCant = new System.Windows.Forms.Button();
            this.btnCantMas = new System.Windows.Forms.Button();
            this.btnCantMenos = new System.Windows.Forms.Button();
            this.btnFinVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnRegPago = new System.Windows.Forms.Button();
            this.lblTitVenta = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdVenta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgdVenta
            // 
            this.dgdVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cBarras,
            this.nombreProd,
            this.cantidadVendida,
            this.precioTotal});
            this.dgdVenta.Location = new System.Drawing.Point(11, 36);
            this.dgdVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgdVenta.Name = "dgdVenta";
            this.dgdVenta.RowTemplate.Height = 24;
            this.dgdVenta.Size = new System.Drawing.Size(488, 171);
            this.dgdVenta.TabIndex = 0;
            // 
            // cBarras
            // 
            this.cBarras.HeaderText = "Código de barras";
            this.cBarras.Name = "cBarras";
            // 
            // nombreProd
            // 
            this.nombreProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreProd.HeaderText = "Nombre";
            this.nombreProd.Name = "nombreProd";
            // 
            // cantidadVendida
            // 
            this.cantidadVendida.HeaderText = "Cantidad";
            this.cantidadVendida.Name = "cantidadVendida";
            // 
            // precioTotal
            // 
            this.precioTotal.HeaderText = "Precio";
            this.precioTotal.Name = "precioTotal";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregarProd2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Location = new System.Drawing.Point(672, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 332);
            this.panel1.TabIndex = 1;
            // 
            // btnAgregarProd2
            // 
            this.btnAgregarProd2.Location = new System.Drawing.Point(37, 238);
            this.btnAgregarProd2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarProd2.Name = "btnAgregarProd2";
            this.btnAgregarProd2.Size = new System.Drawing.Size(178, 52);
            this.btnAgregarProd2.TabIndex = 17;
            this.btnAgregarProd2.Text = "Agregar producto (F10)";
            this.btnAgregarProd2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 176);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 30);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(37, 119);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(179, 23);
            this.textBox4.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(37, 13);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(178, 81);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar Producto por nombre (F2)";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.Location = new System.Drawing.Point(11, 253);
            this.btnAgregarProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(92, 52);
            this.btnAgregarProd.TabIndex = 2;
            this.btnAgregarProd.Text = "Agregar producto (F10)";
            this.btnAgregarProd.UseVisualStyleBackColor = true;
            // 
            // txtCB
            // 
            this.txtCB.Location = new System.Drawing.Point(117, 219);
            this.txtCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCB.Name = "txtCB";
            this.txtCB.Size = new System.Drawing.Size(382, 20);
            this.txtCB.TabIndex = 3;
            // 
            // lblCB
            // 
            this.lblCB.AutoSize = true;
            this.lblCB.Location = new System.Drawing.Point(11, 219);
            this.lblCB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCB.Name = "lblCB";
            this.lblCB.Size = new System.Drawing.Size(91, 13);
            this.lblCB.TabIndex = 4;
            this.lblCB.Text = "Código de Barras:";
            // 
            // btnModCant
            // 
            this.btnModCant.Location = new System.Drawing.Point(115, 253);
            this.btnModCant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModCant.Name = "btnModCant";
            this.btnModCant.Size = new System.Drawing.Size(92, 52);
            this.btnModCant.TabIndex = 5;
            this.btnModCant.Text = "Modificar Cantidad Anterior (F9)";
            this.btnModCant.UseVisualStyleBackColor = true;
            // 
            // btnCantMas
            // 
            this.btnCantMas.Location = new System.Drawing.Point(218, 253);
            this.btnCantMas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCantMas.Name = "btnCantMas";
            this.btnCantMas.Size = new System.Drawing.Size(92, 52);
            this.btnCantMas.TabIndex = 6;
            this.btnCantMas.Text = "Cantidad Anterior +1 (F8)";
            this.btnCantMas.UseVisualStyleBackColor = true;
            // 
            // btnCantMenos
            // 
            this.btnCantMenos.Location = new System.Drawing.Point(324, 253);
            this.btnCantMenos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCantMenos.Name = "btnCantMenos";
            this.btnCantMenos.Size = new System.Drawing.Size(92, 52);
            this.btnCantMenos.TabIndex = 7;
            this.btnCantMenos.Text = "Cantidad Anterior -1 (F7)";
            this.btnCantMenos.UseVisualStyleBackColor = true;
            // 
            // btnFinVenta
            // 
            this.btnFinVenta.Location = new System.Drawing.Point(532, 90);
            this.btnFinVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFinVenta.Name = "btnFinVenta";
            this.btnFinVenta.Size = new System.Drawing.Size(125, 36);
            this.btnFinVenta.TabIndex = 8;
            this.btnFinVenta.Text = "Finalizar Venta (F4)";
            this.btnFinVenta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Efectivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tarjeta";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(582, 143);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(582, 165);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(582, 187);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 20);
            this.textBox3.TabIndex = 14;
            // 
            // btnRegPago
            // 
            this.btnRegPago.Location = new System.Drawing.Point(532, 219);
            this.btnRegPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegPago.Name = "btnRegPago";
            this.btnRegPago.Size = new System.Drawing.Size(125, 34);
            this.btnRegPago.TabIndex = 15;
            this.btnRegPago.Text = "Registrar pago (F5)";
            this.btnRegPago.UseVisualStyleBackColor = true;
            // 
            // lblTitVenta
            // 
            this.lblTitVenta.AutoSize = true;
            this.lblTitVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitVenta.Location = new System.Drawing.Point(9, 7);
            this.lblTitVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitVenta.Name = "lblTitVenta";
            this.lblTitVenta.Size = new System.Drawing.Size(190, 26);
            this.lblTitVenta.TabIndex = 16;
            this.lblTitVenta.Text = "Venta en progreso";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(426, 253);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 52);
            this.button3.TabIndex = 17;
            this.button3.Text = "Eliminar producto anterior(F6)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 356);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblTitVenta);
            this.Controls.Add(this.btnRegPago);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinVenta);
            this.Controls.Add(this.btnCantMenos);
            this.Controls.Add(this.btnCantMas);
            this.Controls.Add(this.btnModCant);
            this.Controls.Add(this.lblCB);
            this.Controls.Add(this.txtCB);
            this.Controls.Add(this.btnAgregarProd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgdVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentasForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgdVenta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdVenta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregarProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadVendida;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTotal;
        private System.Windows.Forms.TextBox txtCB;
        private System.Windows.Forms.Label lblCB;
        private System.Windows.Forms.Button btnAgregarProd2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModCant;
        private System.Windows.Forms.Button btnCantMas;
        private System.Windows.Forms.Button btnCantMenos;
        private System.Windows.Forms.Button btnFinVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnRegPago;
        private System.Windows.Forms.Label lblTitVenta;
        private System.Windows.Forms.Button button3;
    }
}