namespace Itbis
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
            panel2 = new Panel();
            label1 = new Label();
            txtArticulo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            nCantidad = new NumericUpDown();
            nPrecio = new NumericUpDown();
            btnCacular = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblArticulo = new Label();
            lblCantidad = new Label();
            lblPrecio = new Label();
            lblSubTotal = new Label();
            lblItbis = new Label();
            lblTotal = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nPrecio).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCacular);
            panel1.Controls.Add(nPrecio);
            panel1.Controls.Add(nCantidad);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtArticulo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 203);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(lblItbis);
            panel2.Controls.Add(lblSubTotal);
            panel2.Controls.Add(lblPrecio);
            panel2.Controls.Add(lblCantidad);
            panel2.Controls.Add(lblArticulo);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 221);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 146);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 28);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Articulo";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtArticulo
            // 
            txtArticulo.Location = new Point(95, 21);
            txtArticulo.Name = "txtArticulo";
            txtArticulo.Size = new Size(654, 27);
            txtArticulo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 87);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Cantidad";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 146);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "Precio";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nCantidad
            // 
            nCantidad.Location = new Point(95, 80);
            nCantidad.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            nCantidad.Name = "nCantidad";
            nCantidad.Size = new Size(150, 27);
            nCantidad.TabIndex = 4;
            // 
            // nPrecio
            // 
            nPrecio.DecimalPlaces = 2;
            nPrecio.Location = new Point(95, 139);
            nPrecio.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nPrecio.Name = "nPrecio";
            nPrecio.Size = new Size(150, 27);
            nPrecio.TabIndex = 5;
            // 
            // btnCacular
            // 
            btnCacular.Location = new Point(536, 107);
            btnCacular.Name = "btnCacular";
            btnCacular.Size = new Size(213, 59);
            btnCacular.TabIndex = 6;
            btnCacular.Text = "Calcular";
            btnCacular.UseVisualStyleBackColor = true;
            btnCacular.Click += btnCacular_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 30);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 7;
            label4.Text = "Articulo";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 69);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 8;
            label5.Text = "Cantidad";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 105);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 9;
            label6.Text = "Precio Unidad";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(509, 69);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 10;
            label7.Text = "ITBIS";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(484, 30);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 11;
            label8.Text = "SubTotal";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(509, 105);
            label9.Name = "label9";
            label9.Size = new Size(42, 20);
            label9.TabIndex = 12;
            label9.Text = "Total";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblArticulo
            // 
            lblArticulo.AutoSize = true;
            lblArticulo.Location = new Point(136, 30);
            lblArticulo.Name = "lblArticulo";
            lblArticulo.Size = new Size(61, 20);
            lblArticulo.TabIndex = 13;
            lblArticulo.Text = "Articulo";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(136, 69);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 14;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(136, 105);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(129, 20);
            lblPrecio.TabIndex = 15;
            lblPrecio.Text = "Precio por Unidad";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(557, 30);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(67, 20);
            lblSubTotal.TabIndex = 16;
            lblSubTotal.Text = "SubTotal";
            // 
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.Location = new Point(557, 69);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(42, 20);
            lblItbis.TabIndex = 17;
            lblItbis.Text = "ITBIS";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(557, 105);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 18;
            lblTotal.Text = "Total";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 380);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nPrecio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnCacular;
        private NumericUpDown nPrecio;
        private NumericUpDown nCantidad;
        private Label label3;
        private Label label2;
        private TextBox txtArticulo;
        private Label label1;
        private Label lblTotal;
        private Label lblItbis;
        private Label lblSubTotal;
        private Label lblPrecio;
        private Label lblCantidad;
        private Label lblArticulo;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}
