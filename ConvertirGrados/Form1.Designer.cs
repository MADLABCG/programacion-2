namespace ConvertirGrados
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
            nValor = new NumericUpDown();
            rbFarenheit = new RadioButton();
            rbCelsius = new RadioButton();
            lblGradosHasta = new Label();
            lblGrados = new Label();
            btnConvertir = new Button();
            lblGradosDesde = new Label();
            ((System.ComponentModel.ISupportInitialize)nValor).BeginInit();
            SuspendLayout();
            // 
            // nValor
            // 
            nValor.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nValor.Location = new Point(32, 33);
            nValor.Name = "nValor";
            nValor.Size = new Size(165, 50);
            nValor.TabIndex = 0;
            // 
            // rbFarenheit
            // 
            rbFarenheit.AutoSize = true;
            rbFarenheit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbFarenheit.Location = new Point(216, 23);
            rbFarenheit.Name = "rbFarenheit";
            rbFarenheit.Size = new Size(112, 29);
            rbFarenheit.TabIndex = 1;
            rbFarenheit.TabStop = true;
            rbFarenheit.Text = "Farenheit";
            rbFarenheit.UseVisualStyleBackColor = true;
            rbFarenheit.CheckedChanged += rbFarenheit_CheckedChanged;
            // 
            // rbCelsius
            // 
            rbCelsius.AutoSize = true;
            rbCelsius.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbCelsius.Location = new Point(216, 58);
            rbCelsius.Name = "rbCelsius";
            rbCelsius.Size = new Size(91, 29);
            rbCelsius.TabIndex = 2;
            rbCelsius.TabStop = true;
            rbCelsius.Text = "Celcius";
            rbCelsius.UseVisualStyleBackColor = true;
            rbCelsius.CheckedChanged += rbCelsius_CheckedChanged;
            // 
            // lblGradosHasta
            // 
            lblGradosHasta.AutoSize = true;
            lblGradosHasta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGradosHasta.Location = new Point(32, 112);
            lblGradosHasta.Name = "lblGradosHasta";
            lblGradosHasta.Size = new Size(68, 25);
            lblGradosHasta.TabIndex = 3;
            lblGradosHasta.Text = "Grado";
            // 
            // lblGrados
            // 
            lblGrados.AutoSize = true;
            lblGrados.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrados.Location = new Point(159, 112);
            lblGrados.Name = "lblGrados";
            lblGrados.Size = new Size(56, 25);
            lblGrados.TabIndex = 4;
            lblGrados.Text = "Valor";
            // 
            // btnConvertir
            // 
            btnConvertir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvertir.Location = new Point(69, 157);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(221, 47);
            btnConvertir.TabIndex = 5;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblGradosDesde
            // 
            lblGradosDesde.AutoSize = true;
            lblGradosDesde.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGradosDesde.ForeColor = Color.Red;
            lblGradosDesde.Location = new Point(32, 9);
            lblGradosDesde.Name = "lblGradosDesde";
            lblGradosDesde.Size = new Size(63, 21);
            lblGradosDesde.TabIndex = 6;
            lblGradosDesde.Text = "Grados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 216);
            Controls.Add(lblGradosDesde);
            Controls.Add(btnConvertir);
            Controls.Add(lblGrados);
            Controls.Add(lblGradosHasta);
            Controls.Add(rbCelsius);
            Controls.Add(rbFarenheit);
            Controls.Add(nValor);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nValor;
        private RadioButton rbFarenheit;
        private RadioButton rbCelsius;
        private Label lblGradosHasta;
        private Label lblGrados;
        private Button btnConvertir;
        private Label lblGradosDesde;
    }
}
