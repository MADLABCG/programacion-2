namespace CalculadoraSimple012025
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
            nNumero1 = new NumericUpDown();
            nNumero2 = new NumericUpDown();
            lblResultado = new Label();
            rbSumar = new RadioButton();
            rbRestar = new RadioButton();
            rbMultiplicar = new RadioButton();
            rbDividir = new RadioButton();
            rbModulo = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            btnLimpiar = new Button();
            btnEjecutar = new Button();
            ((System.ComponentModel.ISupportInitialize)nNumero1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nNumero2).BeginInit();
            SuspendLayout();
            // 
            // nNumero1
            // 
            nNumero1.DecimalPlaces = 2;
            nNumero1.Location = new Point(88, 81);
            nNumero1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nNumero1.Name = "nNumero1";
            nNumero1.Size = new Size(120, 23);
            nNumero1.TabIndex = 0;
            // 
            // nNumero2
            // 
            nNumero2.DecimalPlaces = 2;
            nNumero2.Location = new Point(87, 117);
            nNumero2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nNumero2.Name = "nNumero2";
            nNumero2.Size = new Size(120, 23);
            nNumero2.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(238, 92);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(127, 32);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado";
            // 
            // rbSumar
            // 
            rbSumar.AutoSize = true;
            rbSumar.Location = new Point(22, 36);
            rbSumar.Name = "rbSumar";
            rbSumar.Size = new Size(59, 19);
            rbSumar.TabIndex = 3;
            rbSumar.TabStop = true;
            rbSumar.Text = "Sumar";
            rbSumar.UseVisualStyleBackColor = true;
            // 
            // rbRestar
            // 
            rbRestar.AutoSize = true;
            rbRestar.Location = new Point(87, 36);
            rbRestar.Name = "rbRestar";
            rbRestar.Size = new Size(57, 19);
            rbRestar.TabIndex = 4;
            rbRestar.TabStop = true;
            rbRestar.Text = "Restar";
            rbRestar.UseVisualStyleBackColor = true;
            // 
            // rbMultiplicar
            // 
            rbMultiplicar.AutoSize = true;
            rbMultiplicar.Location = new Point(150, 36);
            rbMultiplicar.Name = "rbMultiplicar";
            rbMultiplicar.Size = new Size(82, 19);
            rbMultiplicar.TabIndex = 5;
            rbMultiplicar.TabStop = true;
            rbMultiplicar.Text = "Multiplicar";
            rbMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rbDividir
            // 
            rbDividir.AutoSize = true;
            rbDividir.Location = new Point(238, 36);
            rbDividir.Name = "rbDividir";
            rbDividir.Size = new Size(59, 19);
            rbDividir.TabIndex = 6;
            rbDividir.TabStop = true;
            rbDividir.Text = "Dividir";
            rbDividir.UseVisualStyleBackColor = true;
            // 
            // rbModulo
            // 
            rbModulo.AutoSize = true;
            rbModulo.Location = new Point(303, 36);
            rbModulo.Name = "rbModulo";
            rbModulo.Size = new Size(113, 19);
            rbModulo.TabIndex = 7;
            rbModulo.TabStop = true;
            rbModulo.Text = "Funcion Modulo";
            rbModulo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 83);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 8;
            label2.Text = "Numero 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 119);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 9;
            label3.Text = "Numero 2";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(22, 162);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(186, 54);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(230, 162);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(186, 54);
            btnEjecutar.TabIndex = 11;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 228);
            Controls.Add(btnEjecutar);
            Controls.Add(btnLimpiar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rbModulo);
            Controls.Add(rbDividir);
            Controls.Add(rbMultiplicar);
            Controls.Add(rbRestar);
            Controls.Add(rbSumar);
            Controls.Add(lblResultado);
            Controls.Add(nNumero2);
            Controls.Add(nNumero1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nNumero1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nNumero2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nNumero1;
        private NumericUpDown nNumero2;
        private Label lblResultado;
        private RadioButton rbSumar;
        private RadioButton rbRestar;
        private RadioButton rbMultiplicar;
        private RadioButton rbDividir;
        private RadioButton rbModulo;
        private Label label2;
        private Label label3;
        private Button btnLimpiar;
        private Button btnEjecutar;
    }
}
