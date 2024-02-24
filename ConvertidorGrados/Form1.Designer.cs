namespace ConvertidorGrados
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
            nGrados = new NumericUpDown();
            panel2 = new Panel();
            lblUnidad = new Label();
            lblResultado = new Label();
            btnConvertir = new Button();
            rbCelcius = new RadioButton();
            rbFarenheit = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nGrados).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(nGrados);
            panel1.Location = new Point(12, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 85);
            panel1.TabIndex = 0;
            // 
            // nGrados
            // 
            nGrados.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nGrados.Location = new Point(44, 19);
            nGrados.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nGrados.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nGrados.Name = "nGrados";
            nGrados.Size = new Size(150, 43);
            nGrados.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblUnidad);
            panel2.Controls.Add(lblResultado);
            panel2.Location = new Point(268, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 85);
            panel2.TabIndex = 1;
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnidad.ImageAlign = ContentAlignment.MiddleLeft;
            lblUnidad.Location = new Point(137, 21);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(37, 41);
            lblUnidad.TabIndex = 1;
            lblUnidad.Text = "C";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ImageAlign = ContentAlignment.MiddleRight;
            lblResultado.Location = new Point(78, 21);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(35, 41);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "0";
            // 
            // btnConvertir
            // 
            btnConvertir.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvertir.Location = new Point(143, 154);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(239, 76);
            btnConvertir.TabIndex = 2;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // rbCelcius
            // 
            rbCelcius.AutoSize = true;
            rbCelcius.Location = new Point(30, 15);
            rbCelcius.Name = "rbCelcius";
            rbCelcius.Size = new Size(76, 24);
            rbCelcius.TabIndex = 3;
            rbCelcius.TabStop = true;
            rbCelcius.Text = "Celcius";
            rbCelcius.UseVisualStyleBackColor = true;
            // 
            // rbFarenheit
            // 
            rbFarenheit.AutoSize = true;
            rbFarenheit.Location = new Point(117, 15);
            rbFarenheit.Name = "rbFarenheit";
            rbFarenheit.Size = new Size(90, 24);
            rbFarenheit.TabIndex = 4;
            rbFarenheit.TabStop = true;
            rbFarenheit.Text = "Farenheit";
            rbFarenheit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 243);
            Controls.Add(rbFarenheit);
            Controls.Add(rbCelcius);
            Controls.Add(btnConvertir);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nGrados).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnConvertir;
        private NumericUpDown nGrados;
        private Label lblResultado;
        private RadioButton rbCelcius;
        private RadioButton rbFarenheit;
        private Label lblUnidad;
    }
}
