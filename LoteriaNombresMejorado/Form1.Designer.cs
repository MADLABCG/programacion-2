namespace LoteriaNombresMejorado
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
            txtJugadores = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPremio = new TextBox();
            lblGanador = new Label();
            label3 = new Label();
            btnEjecutar = new Button();
            SuspendLayout();
            // 
            // txtJugadores
            // 
            txtJugadores.Location = new Point(29, 60);
            txtJugadores.Multiline = true;
            txtJugadores.Name = "txtJugadores";
            txtJugadores.Size = new Size(406, 368);
            txtJugadores.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 32);
            label1.Name = "label1";
            label1.Size = new Size(205, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombres para Sorteo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(451, 32);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 2;
            label2.Text = "Premio";
            // 
            // txtPremio
            // 
            txtPremio.Location = new Point(451, 60);
            txtPremio.Name = "txtPremio";
            txtPremio.Size = new Size(333, 23);
            txtPremio.TabIndex = 3;
            // 
            // lblGanador
            // 
            lblGanador.AutoSize = true;
            lblGanador.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGanador.ForeColor = Color.Red;
            lblGanador.Location = new Point(451, 180);
            lblGanador.Name = "lblGanador";
            lblGanador.Size = new Size(90, 25);
            lblGanador.TabIndex = 4;
            lblGanador.Text = "Ganador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(451, 144);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 5;
            label3.Text = "El Ganador es:";
            // 
            // btnEjecutar
            // 
            btnEjecutar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEjecutar.Location = new Point(451, 383);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(333, 45);
            btnEjecutar.TabIndex = 6;
            btnEjecutar.Text = "Ejecutar Sorteo";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEjecutar);
            Controls.Add(label3);
            Controls.Add(lblGanador);
            Controls.Add(txtPremio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtJugadores);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtJugadores;
        private Label label1;
        private Label label2;
        private TextBox txtPremio;
        private Label lblGanador;
        private Label label3;
        private Button btnEjecutar;
    }
}
