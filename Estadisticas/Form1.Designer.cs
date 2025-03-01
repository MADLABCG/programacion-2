namespace Estadisticas
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
            txtNumeros = new TextBox();
            label1 = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblDesviacion = new Label();
            lblVarianza = new Label();
            lblModa = new Label();
            lblMediana = new Label();
            lblMedia = new Label();
            SuspendLayout();
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(23, 41);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(177, 331);
            txtNumeros.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 17);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 1;
            label1.Text = "Numeros a Usar";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.Green;
            btnCalcular.Location = new Point(23, 378);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(177, 38);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.Red;
            btnLimpiar.Location = new Point(222, 278);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(198, 38);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(222, 43);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 4;
            label2.Text = "Estadisticas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(222, 97);
            label3.Name = "label3";
            label3.Size = new Size(159, 25);
            label3.TabIndex = 5;
            label3.Text = "Media (Average)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(222, 133);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 6;
            label4.Text = "Mediana";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(222, 167);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 7;
            label5.Text = "Moda";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(222, 201);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 8;
            label6.Text = "Varianza";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(222, 236);
            label7.Name = "label7";
            label7.Size = new Size(107, 25);
            label7.TabIndex = 9;
            label7.Text = "Desviacion";
            // 
            // lblDesviacion
            // 
            lblDesviacion.AutoSize = true;
            lblDesviacion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesviacion.Location = new Point(397, 236);
            lblDesviacion.Name = "lblDesviacion";
            lblDesviacion.Size = new Size(23, 25);
            lblDesviacion.TabIndex = 14;
            lblDesviacion.Text = "0";
            // 
            // lblVarianza
            // 
            lblVarianza.AutoSize = true;
            lblVarianza.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVarianza.Location = new Point(397, 201);
            lblVarianza.Name = "lblVarianza";
            lblVarianza.Size = new Size(23, 25);
            lblVarianza.TabIndex = 13;
            lblVarianza.Text = "0";
            // 
            // lblModa
            // 
            lblModa.AutoSize = true;
            lblModa.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModa.Location = new Point(397, 167);
            lblModa.Name = "lblModa";
            lblModa.Size = new Size(23, 25);
            lblModa.TabIndex = 12;
            lblModa.Text = "0";
            // 
            // lblMediana
            // 
            lblMediana.AutoSize = true;
            lblMediana.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMediana.Location = new Point(397, 133);
            lblMediana.Name = "lblMediana";
            lblMediana.Size = new Size(23, 25);
            lblMediana.TabIndex = 11;
            lblMediana.Text = "0";
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedia.Location = new Point(397, 97);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(23, 25);
            lblMedia.TabIndex = 10;
            lblMedia.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 429);
            Controls.Add(lblDesviacion);
            Controls.Add(lblVarianza);
            Controls.Add(lblModa);
            Controls.Add(lblMediana);
            Controls.Add(lblMedia);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(label1);
            Controls.Add(txtNumeros);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumeros;
        private Label label1;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblDesviacion;
        private Label lblVarianza;
        private Label lblModa;
        private Label lblMediana;
        private Label lblMedia;
    }
}
