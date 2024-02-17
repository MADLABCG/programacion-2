namespace Descuento
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
            btnCalcular = new Button();
            nPorcentaje = new NumericUpDown();
            nPrecio = new NumericUpDown();
            txtArticulo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            lblPrecioFinal = new Label();
            lblDescuento = new Label();
            lblPorcentaje = new Label();
            lblPrecio = new Label();
            lblArticulo = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nPorcentaje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nPrecio).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCalcular);
            panel1.Controls.Add(nPorcentaje);
            panel1.Controls.Add(nPrecio);
            panel1.Controls.Add(txtArticulo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 147);
            panel1.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(331, 73);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(179, 62);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // nPorcentaje
            // 
            nPorcentaje.DecimalPlaces = 2;
            nPorcentaje.Location = new Point(113, 108);
            nPorcentaje.Name = "nPorcentaje";
            nPorcentaje.Size = new Size(150, 27);
            nPorcentaje.TabIndex = 5;
            // 
            // nPrecio
            // 
            nPrecio.DecimalPlaces = 2;
            nPrecio.Location = new Point(113, 66);
            nPrecio.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nPrecio.Name = "nPrecio";
            nPrecio.Size = new Size(150, 27);
            nPrecio.TabIndex = 4;
            // 
            // txtArticulo
            // 
            txtArticulo.Location = new Point(113, 27);
            txtArticulo.Name = "txtArticulo";
            txtArticulo.Size = new Size(436, 27);
            txtArticulo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 110);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Porcentaje";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 73);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Precio";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 34);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Articulo";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblPrecioFinal);
            panel2.Controls.Add(lblDescuento);
            panel2.Controls.Add(lblPorcentaje);
            panel2.Controls.Add(lblPrecio);
            panel2.Controls.Add(lblArticulo);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 185);
            panel2.Name = "panel2";
            panel2.Size = new Size(581, 125);
            panel2.TabIndex = 1;
            // 
            // lblPrecioFinal
            // 
            lblPrecioFinal.AutoSize = true;
            lblPrecioFinal.Location = new Point(331, 83);
            lblPrecioFinal.Name = "lblPrecioFinal";
            lblPrecioFinal.Size = new Size(85, 20);
            lblPrecioFinal.TabIndex = 16;
            lblPrecioFinal.Text = "Precio Final";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(331, 49);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(79, 20);
            lblDescuento.TabIndex = 15;
            lblDescuento.Text = "Descuento";
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Location = new Point(113, 83);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(78, 20);
            lblPorcentaje.TabIndex = 14;
            lblPorcentaje.Text = "Porcentaje";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(113, 49);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 13;
            lblPrecio.Text = "Precio";
            // 
            // lblArticulo
            // 
            lblArticulo.AutoSize = true;
            lblArticulo.Location = new Point(111, 15);
            lblArticulo.Name = "lblArticulo";
            lblArticulo.Size = new Size(61, 20);
            lblArticulo.TabIndex = 12;
            lblArticulo.Text = "Articulo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(241, 83);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 11;
            label8.Text = "Precio Final";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 83);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 10;
            label7.Text = "Porcentaje";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(247, 49);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 9;
            label6.Text = "Descuento";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 49);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 8;
            label5.Text = "Precio";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 15);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 7;
            label4.Text = "Articulo";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 325);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nPorcentaje).EndInit();
            ((System.ComponentModel.ISupportInitialize)nPrecio).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private NumericUpDown nPorcentaje;
        private NumericUpDown nPrecio;
        private TextBox txtArticulo;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Button btnCalcular;
        private Label lblPrecioFinal;
        private Label lblDescuento;
        private Label lblPorcentaje;
        private Label lblPrecio;
        private Label lblArticulo;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}
