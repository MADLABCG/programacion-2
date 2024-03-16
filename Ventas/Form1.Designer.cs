namespace Ventas
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
            panel1 = new Panel();
            lstArticulos = new ListView();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnRegistrarVentas = new Button();
            nPrecioArticulo = new NumericUpDown();
            txtNombreArticulo = new TextBox();
            panel3 = new Panel();
            lblArticulosVendido = new Label();
            lblTotalVentas = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nPrecioArticulo).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lstArticulos);
            panel1.Location = new Point(463, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 378);
            panel1.TabIndex = 0;
            // 
            // lstArticulos
            // 
            lstArticulos.FullRowSelect = true;
            lstArticulos.GridLines = true;
            lstArticulos.Location = new Point(3, 3);
            lstArticulos.Name = "lstArticulos";
            lstArticulos.Size = new Size(307, 370);
            lstArticulos.TabIndex = 0;
            lstArticulos.UseCompatibleStateImageBehavior = false;
            lstArticulos.View = View.List;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnRegistrarVentas);
            panel2.Controls.Add(nPrecioArticulo);
            panel2.Controls.Add(txtNombreArticulo);
            panel2.Location = new Point(12, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(421, 145);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 8);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 8);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 3;
            label1.Text = "Articulo";
            // 
            // btnRegistrarVentas
            // 
            btnRegistrarVentas.Location = new Point(20, 90);
            btnRegistrarVentas.Name = "btnRegistrarVentas";
            btnRegistrarVentas.Size = new Size(382, 29);
            btnRegistrarVentas.TabIndex = 2;
            btnRegistrarVentas.Text = "Registrar Ventas";
            btnRegistrarVentas.UseVisualStyleBackColor = true;
            btnRegistrarVentas.Click += btnRegistrarVentas_Click;
            // 
            // nPrecioArticulo
            // 
            nPrecioArticulo.DecimalPlaces = 2;
            nPrecioArticulo.Location = new Point(306, 37);
            nPrecioArticulo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nPrecioArticulo.Name = "nPrecioArticulo";
            nPrecioArticulo.Size = new Size(96, 27);
            nPrecioArticulo.TabIndex = 1;
            // 
            // txtNombreArticulo
            // 
            txtNombreArticulo.Location = new Point(20, 37);
            txtNombreArticulo.Name = "txtNombreArticulo";
            txtNombreArticulo.Size = new Size(244, 27);
            txtNombreArticulo.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblArticulosVendido);
            panel3.Controls.Add(lblTotalVentas);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 244);
            panel3.Name = "panel3";
            panel3.Size = new Size(421, 99);
            panel3.TabIndex = 1;
            // 
            // lblArticulosVendido
            // 
            lblArticulosVendido.AutoSize = true;
            lblArticulosVendido.Location = new Point(150, 23);
            lblArticulosVendido.Name = "lblArticulosVendido";
            lblArticulosVendido.Size = new Size(17, 20);
            lblArticulosVendido.TabIndex = 3;
            lblArticulosVendido.Text = "0";
            // 
            // lblTotalVentas
            // 
            lblTotalVentas.AutoSize = true;
            lblTotalVentas.Location = new Point(150, 61);
            lblTotalVentas.Name = "lblTotalVentas";
            lblTotalVentas.Size = new Size(17, 20);
            lblTotalVentas.TabIndex = 2;
            lblTotalVentas.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 61);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 1;
            label4.Text = "Total Vendido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 23);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 0;
            label3.Text = "Articulos Vendidos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nPrecioArticulo).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Button btnRegistrarVentas;
        private NumericUpDown nPrecioArticulo;
        private TextBox txtNombreArticulo;
        private Panel panel3;
        private ListView lstArticulos;
        private Label lblArticulosVendido;
        private Label lblTotalVentas;
        private Label label4;
        private Label label3;
    }
}
