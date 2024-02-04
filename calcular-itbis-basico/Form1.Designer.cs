namespace _20240127___P2___Calculo_ITBIS
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
            btnCalcular = new Button();
            txtArticulo = new TextBox();
            nmPrecio = new NumericUpDown();
            nmCantidad = new NumericUpDown();
            panel1 = new Panel();
            lblResultado = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmCantidad).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(307, 109);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtArticulo
            // 
            txtArticulo.Location = new Point(35, 58);
            txtArticulo.Name = "txtArticulo";
            txtArticulo.Size = new Size(316, 27);
            txtArticulo.TabIndex = 1;
            // 
            // nmPrecio
            // 
            nmPrecio.DecimalPlaces = 2;
            nmPrecio.Location = new Point(518, 58);
            nmPrecio.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmPrecio.Name = "nmPrecio";
            nmPrecio.Size = new Size(150, 27);
            nmPrecio.TabIndex = 2;
            // 
            // nmCantidad
            // 
            nmCantidad.Location = new Point(381, 58);
            nmCantidad.Name = "nmCantidad";
            nmCantidad.Size = new Size(92, 27);
            nmCantidad.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblResultado);
            panel1.Location = new Point(35, 154);
            panel1.Name = "panel1";
            panel1.Size = new Size(633, 209);
            panel1.TabIndex = 4;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(18, 14);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(165, 20);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado Calculo ITBIS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 21);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 5;
            label2.Text = "Articulo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 21);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 6;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(518, 21);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "Precio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 375);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(nmCantidad);
            Controls.Add(nmPrecio);
            Controls.Add(txtArticulo);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nmPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmCantidad).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtArticulo;
        private NumericUpDown nmPrecio;
        private NumericUpDown nmCantidad;
        private Panel panel1;
        private Label lblResultado;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
