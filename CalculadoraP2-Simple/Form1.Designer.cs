namespace CalculadoraP2_Simple
{
    partial class Calculadora
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
            rbSumar = new RadioButton();
            rbRestar = new RadioButton();
            rbMultiplicar = new RadioButton();
            rbDividir = new RadioButton();
            rbCuadrado = new RadioButton();
            rbCubo = new RadioButton();
            tbResultado = new TextBox();
            btnEjecutar = new Button();
            btnLimpiar = new Button();
            rbItbis = new RadioButton();
            lblNumero1 = new Label();
            lblNumero2 = new Label();
            nNumero1 = new NumericUpDown();
            nNumero2 = new NumericUpDown();
            lblExplicacion = new Label();
            lblVersion = new Label();
            ((System.ComponentModel.ISupportInitialize)nNumero1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nNumero2).BeginInit();
            SuspendLayout();
            // 
            // rbSumar
            // 
            rbSumar.AutoSize = true;
            rbSumar.Location = new Point(12, 12);
            rbSumar.Name = "rbSumar";
            rbSumar.Size = new Size(59, 19);
            rbSumar.TabIndex = 0;
            rbSumar.TabStop = true;
            rbSumar.Text = "Sumar";
            rbSumar.UseVisualStyleBackColor = true;
            rbSumar.CheckedChanged += rbSumar_CheckedChanged;
            // 
            // rbRestar
            // 
            rbRestar.AutoSize = true;
            rbRestar.Location = new Point(12, 37);
            rbRestar.Name = "rbRestar";
            rbRestar.Size = new Size(57, 19);
            rbRestar.TabIndex = 1;
            rbRestar.TabStop = true;
            rbRestar.Text = "Restar";
            rbRestar.UseVisualStyleBackColor = true;
            rbRestar.CheckedChanged += rbRestar_CheckedChanged;
            // 
            // rbMultiplicar
            // 
            rbMultiplicar.AutoSize = true;
            rbMultiplicar.Location = new Point(12, 62);
            rbMultiplicar.Name = "rbMultiplicar";
            rbMultiplicar.Size = new Size(82, 19);
            rbMultiplicar.TabIndex = 2;
            rbMultiplicar.TabStop = true;
            rbMultiplicar.Text = "Multiplicar";
            rbMultiplicar.UseVisualStyleBackColor = true;
            rbMultiplicar.CheckedChanged += rbMultiplicar_CheckedChanged;
            // 
            // rbDividir
            // 
            rbDividir.AutoSize = true;
            rbDividir.Location = new Point(12, 87);
            rbDividir.Name = "rbDividir";
            rbDividir.Size = new Size(59, 19);
            rbDividir.TabIndex = 3;
            rbDividir.TabStop = true;
            rbDividir.Text = "Dividir";
            rbDividir.UseVisualStyleBackColor = true;
            rbDividir.CheckedChanged += rbDividir_CheckedChanged;
            // 
            // rbCuadrado
            // 
            rbCuadrado.AutoSize = true;
            rbCuadrado.Location = new Point(12, 112);
            rbCuadrado.Name = "rbCuadrado";
            rbCuadrado.Size = new Size(77, 19);
            rbCuadrado.TabIndex = 4;
            rbCuadrado.TabStop = true;
            rbCuadrado.Text = "Cuadrado";
            rbCuadrado.UseVisualStyleBackColor = true;
            rbCuadrado.CheckedChanged += rbCuadrado_CheckedChanged;
            // 
            // rbCubo
            // 
            rbCubo.AutoSize = true;
            rbCubo.Location = new Point(12, 137);
            rbCubo.Name = "rbCubo";
            rbCubo.Size = new Size(54, 19);
            rbCubo.TabIndex = 5;
            rbCubo.TabStop = true;
            rbCubo.Text = "Cubo";
            rbCubo.UseVisualStyleBackColor = true;
            rbCubo.CheckedChanged += rbCubo_CheckedChanged;
            // 
            // tbResultado
            // 
            tbResultado.BackColor = Color.DarkSeaGreen;
            tbResultado.Font = new Font("Segoe UI", 33.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbResultado.Location = new Point(109, 12);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(309, 94);
            tbResultado.TabIndex = 6;
            tbResultado.Text = "Hola";
            tbResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnEjecutar
            // 
            btnEjecutar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEjecutar.Location = new Point(14, 240);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(102, 35);
            btnEjecutar.TabIndex = 7;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(122, 240);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(102, 35);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // rbItbis
            // 
            rbItbis.AutoSize = true;
            rbItbis.Location = new Point(12, 162);
            rbItbis.Name = "rbItbis";
            rbItbis.Size = new Size(47, 19);
            rbItbis.TabIndex = 11;
            rbItbis.TabStop = true;
            rbItbis.Text = "Itbis";
            rbItbis.UseVisualStyleBackColor = true;
            rbItbis.CheckedChanged += rbItbis_CheckedChanged;
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero1.Location = new Point(138, 129);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(86, 21);
            lblNumero1.TabIndex = 12;
            lblNumero1.Text = "Numero 1";
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero2.Location = new Point(138, 169);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(86, 21);
            lblNumero2.TabIndex = 13;
            lblNumero2.Text = "Numero 2";
            // 
            // nNumero1
            // 
            nNumero1.DecimalPlaces = 2;
            nNumero1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nNumero1.Location = new Point(263, 124);
            nNumero1.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nNumero1.Name = "nNumero1";
            nNumero1.Size = new Size(155, 33);
            nNumero1.TabIndex = 14;
            nNumero1.TextAlign = HorizontalAlignment.Right;
            // 
            // nNumero2
            // 
            nNumero2.DecimalPlaces = 2;
            nNumero2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nNumero2.Location = new Point(263, 164);
            nNumero2.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nNumero2.Name = "nNumero2";
            nNumero2.Size = new Size(155, 33);
            nNumero2.TabIndex = 15;
            nNumero2.TextAlign = HorizontalAlignment.Right;
            // 
            // lblExplicacion
            // 
            lblExplicacion.AutoSize = true;
            lblExplicacion.Location = new Point(19, 205);
            lblExplicacion.Name = "lblExplicacion";
            lblExplicacion.Size = new Size(66, 15);
            lblExplicacion.TabIndex = 16;
            lblExplicacion.Text = "Explicacion";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(362, 260);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(13, 15);
            lblVersion.TabIndex = 17;
            lblVersion.Text = "v";
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 287);
            Controls.Add(lblVersion);
            Controls.Add(lblExplicacion);
            Controls.Add(nNumero2);
            Controls.Add(nNumero1);
            Controls.Add(lblNumero2);
            Controls.Add(lblNumero1);
            Controls.Add(rbItbis);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEjecutar);
            Controls.Add(tbResultado);
            Controls.Add(rbCubo);
            Controls.Add(rbCuadrado);
            Controls.Add(rbDividir);
            Controls.Add(rbMultiplicar);
            Controls.Add(rbRestar);
            Controls.Add(rbSumar);
            Name = "Calculadora";
            Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)nNumero1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nNumero2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbSumar;
        private RadioButton rbRestar;
        private RadioButton rbMultiplicar;
        private RadioButton rbDividir;
        private RadioButton rbCuadrado;
        private RadioButton rbCubo;
        private TextBox tbResultado;
        private Button btnEjecutar;
        private Button btnLimpiar;
        private RadioButton rbItbis;
        private Label lblNumero1;
        private Label lblNumero2;
        private NumericUpDown nNumero1;
        private NumericUpDown nNumero2;
        private Label lblExplicacion;
        private Label lblVersion;
    }
}
