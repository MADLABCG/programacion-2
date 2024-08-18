namespace TrabajoFinal202402
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtModelo = new TextBox();
            txtDescripcion = new TextBox();
            nCosto = new NumericUpDown();
            nPrecio = new NumericUpDown();
            nCantidad = new NumericUpDown();
            panel1 = new Panel();
            panel3 = new Panel();
            lblGananciaProyectada = new Label();
            lblProyeccionVentaTotal = new Label();
            lblCostoTotalInventario = new Label();
            lblTotalProductosInventario = new Label();
            lblCantidadProductos = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            btnCrearProducto = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            tablaDatos = new ListView();
            ((System.ComponentModel.ISupportInitialize)nCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nCantidad).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(166, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(231, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(166, 106);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(231, 27);
            txtModelo.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(166, 139);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(231, 27);
            txtDescripcion.TabIndex = 2;
            // 
            // nCosto
            // 
            nCosto.DecimalPlaces = 2;
            nCosto.Location = new Point(168, 172);
            nCosto.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nCosto.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nCosto.Name = "nCosto";
            nCosto.Size = new Size(229, 27);
            nCosto.TabIndex = 3;
            nCosto.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nPrecio
            // 
            nPrecio.DecimalPlaces = 2;
            nPrecio.Location = new Point(168, 205);
            nPrecio.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nPrecio.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nPrecio.Name = "nPrecio";
            nPrecio.Size = new Size(229, 27);
            nPrecio.TabIndex = 4;
            nPrecio.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nCantidad
            // 
            nCantidad.Location = new Point(168, 238);
            nCantidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nCantidad.Name = "nCantidad";
            nCantidad.Size = new Size(229, 27);
            nCantidad.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnCrearProducto);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(nCantidad);
            panel1.Controls.Add(txtModelo);
            panel1.Controls.Add(nPrecio);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(nCosto);
            panel1.Location = new Point(29, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 541);
            panel1.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblGananciaProyectada);
            panel3.Controls.Add(lblProyeccionVentaTotal);
            panel3.Controls.Add(lblCostoTotalInventario);
            panel3.Controls.Add(lblTotalProductosInventario);
            panel3.Controls.Add(lblCantidadProductos);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(25, 351);
            panel3.Name = "panel3";
            panel3.Size = new Size(372, 169);
            panel3.TabIndex = 14;
            // 
            // lblGananciaProyectada
            // 
            lblGananciaProyectada.AutoSize = true;
            lblGananciaProyectada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGananciaProyectada.Location = new Point(167, 134);
            lblGananciaProyectada.Name = "lblGananciaProyectada";
            lblGananciaProyectada.Size = new Size(18, 20);
            lblGananciaProyectada.TabIndex = 9;
            lblGananciaProyectada.Text = "0";
            // 
            // lblProyeccionVentaTotal
            // 
            lblProyeccionVentaTotal.AutoSize = true;
            lblProyeccionVentaTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProyeccionVentaTotal.Location = new Point(173, 107);
            lblProyeccionVentaTotal.Name = "lblProyeccionVentaTotal";
            lblProyeccionVentaTotal.Size = new Size(18, 20);
            lblProyeccionVentaTotal.TabIndex = 8;
            lblProyeccionVentaTotal.Text = "0";
            // 
            // lblCostoTotalInventario
            // 
            lblCostoTotalInventario.AutoSize = true;
            lblCostoTotalInventario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCostoTotalInventario.Location = new Point(173, 79);
            lblCostoTotalInventario.Name = "lblCostoTotalInventario";
            lblCostoTotalInventario.Size = new Size(18, 20);
            lblCostoTotalInventario.TabIndex = 7;
            lblCostoTotalInventario.Text = "0";
            // 
            // lblTotalProductosInventario
            // 
            lblTotalProductosInventario.AutoSize = true;
            lblTotalProductosInventario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProductosInventario.Location = new Point(201, 50);
            lblTotalProductosInventario.Name = "lblTotalProductosInventario";
            lblTotalProductosInventario.Size = new Size(18, 20);
            lblTotalProductosInventario.TabIndex = 6;
            lblTotalProductosInventario.Text = "0";
            // 
            // lblCantidadProductos
            // 
            lblCantidadProductos.AutoSize = true;
            lblCantidadProductos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidadProductos.Location = new Point(158, 21);
            lblCantidadProductos.Name = "lblCantidadProductos";
            lblCantidadProductos.Size = new Size(18, 20);
            lblCantidadProductos.TabIndex = 5;
            lblCantidadProductos.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 134);
            label12.Name = "label12";
            label12.Size = new Size(151, 20);
            label12.TabIndex = 4;
            label12.Text = "Ganancia Proyectada:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 107);
            label11.Name = "label11";
            label11.Size = new Size(162, 20);
            label11.TabIndex = 3;
            label11.Text = "Proyeccion Venta Total:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 79);
            label10.Name = "label10";
            label10.Size = new Size(157, 20);
            label10.TabIndex = 2;
            label10.Text = "Costo Total Inventario:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 50);
            label9.Name = "label9";
            label9.Size = new Size(185, 20);
            label9.TabIndex = 1;
            label9.Text = "Total Productos Inventario:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 21);
            label8.Name = "label8";
            label8.Size = new Size(142, 20);
            label8.TabIndex = 0;
            label8.Text = "Cantidad Productos:";
            // 
            // btnCrearProducto
            // 
            btnCrearProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearProducto.Location = new Point(84, 281);
            btnCrearProducto.Name = "btnCrearProducto";
            btnCrearProducto.Size = new Size(261, 58);
            btnCrearProducto.TabIndex = 13;
            btnCrearProducto.Text = "Crear Producto";
            btnCrearProducto.UseVisualStyleBackColor = true;
            btnCrearProducto.Click += btnCrearProducto_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 18);
            label7.Name = "label7";
            label7.Size = new Size(251, 31);
            label7.TabIndex = 12;
            label7.Text = "Crear Nuevo Producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 240);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 11;
            label6.Text = "Cantidades";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 207);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 10;
            label5.Text = "Precio Venta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 174);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 9;
            label4.Text = "Costo Compra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 142);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 8;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 109);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 7;
            label2.Text = "Modelo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 77);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tablaDatos);
            panel2.Location = new Point(467, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 541);
            panel2.TabIndex = 7;
            // 
            // tablaDatos
            // 
            tablaDatos.Location = new Point(17, 18);
            tablaDatos.Name = "tablaDatos";
            tablaDatos.Size = new Size(458, 502);
            tablaDatos.TabIndex = 0;
            tablaDatos.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 579);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nCantidad).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtModelo;
        private TextBox txtDescripcion;
        private NumericUpDown nCosto;
        private NumericUpDown nPrecio;
        private NumericUpDown nCantidad;
        private Panel panel1;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCrearProducto;
        private Panel panel2;
        private ListView tablaDatos;
        private Panel panel3;
        private Label label8;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label12;
        private Label lblGananciaProyectada;
        private Label lblProyeccionVentaTotal;
        private Label lblCostoTotalInventario;
        private Label lblTotalProductosInventario;
        private Label lblCantidadProductos;
    }
}
