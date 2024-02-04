namespace Loteria
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
            txtParticipantes = new TextBox();
            lblGanador = new Label();
            btnSorteo = new Button();
            btnLimpiar = new Button();
            lblPremio = new Label();
            label1 = new Label();
            txtPremios = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblSorteos = new Label();
            label6 = new Label();
            lblJugadores = new Label();
            SuspendLayout();
            // 
            // txtParticipantes
            // 
            txtParticipantes.Location = new Point(14, 68);
            txtParticipantes.Margin = new Padding(3, 4, 3, 4);
            txtParticipantes.Multiline = true;
            txtParticipantes.Name = "txtParticipantes";
            txtParticipantes.Size = new Size(236, 360);
            txtParticipantes.TabIndex = 0;
            // 
            // lblGanador
            // 
            lblGanador.AutoSize = true;
            lblGanador.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblGanador.ForeColor = Color.Red;
            lblGanador.Location = new Point(523, 147);
            lblGanador.Name = "lblGanador";
            lblGanador.Size = new Size(184, 54);
            lblGanador.TabIndex = 1;
            lblGanador.Text = "Ganador";
            // 
            // btnSorteo
            // 
            btnSorteo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSorteo.Location = new Point(197, 456);
            btnSorteo.Margin = new Padding(3, 4, 3, 4);
            btnSorteo.Name = "btnSorteo";
            btnSorteo.Size = new Size(174, 101);
            btnSorteo.TabIndex = 2;
            btnSorteo.Text = "Sorteo";
            btnSorteo.UseVisualStyleBackColor = true;
            btnSorteo.Click += btnSorteo_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(14, 456);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(176, 101);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblPremio
            // 
            lblPremio.AutoSize = true;
            lblPremio.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblPremio.ForeColor = Color.MediumBlue;
            lblPremio.Location = new Point(523, 312);
            lblPremio.Name = "lblPremio";
            lblPremio.Size = new Size(158, 54);
            lblPremio.TabIndex = 4;
            lblPremio.Text = "Premio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 31);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 5;
            label1.Text = "Participantes";
            // 
            // txtPremios
            // 
            txtPremios.Location = new Point(263, 68);
            txtPremios.Margin = new Padding(3, 4, 3, 4);
            txtPremios.Multiline = true;
            txtPremios.Name = "txtPremios";
            txtPremios.Size = new Size(223, 360);
            txtPremios.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(270, 31);
            label2.Name = "label2";
            label2.Size = new Size(142, 23);
            label2.TabIndex = 7;
            label2.Text = "Posibles Premios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(523, 111);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 8;
            label3.Text = "Ganador";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(523, 271);
            label4.Name = "label4";
            label4.Size = new Size(67, 23);
            label4.TabIndex = 9;
            label4.Text = "Premio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(523, 512);
            label5.Name = "label5";
            label5.Size = new Size(178, 23);
            label5.TabIndex = 10;
            label5.Text = "Cantidad de Sorteos:";
            // 
            // lblSorteos
            // 
            lblSorteos.AutoSize = true;
            lblSorteos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSorteos.Location = new Point(707, 512);
            lblSorteos.Name = "lblSorteos";
            lblSorteos.Size = new Size(20, 23);
            lblSorteos.TabIndex = 11;
            lblSorteos.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(523, 456);
            label6.Name = "label6";
            label6.Size = new Size(200, 23);
            label6.TabIndex = 12;
            label6.Text = "Cantidad de Jugadores:";
            // 
            // lblJugadores
            // 
            lblJugadores.AutoSize = true;
            lblJugadores.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblJugadores.Location = new Point(729, 456);
            lblJugadores.Name = "lblJugadores";
            lblJugadores.Size = new Size(20, 23);
            lblJugadores.TabIndex = 13;
            lblJugadores.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 580);
            Controls.Add(lblJugadores);
            Controls.Add(label6);
            Controls.Add(lblSorteos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPremios);
            Controls.Add(label1);
            Controls.Add(lblPremio);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSorteo);
            Controls.Add(lblGanador);
            Controls.Add(txtParticipantes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtParticipantes;
        private Label lblGanador;
        private Button btnSorteo;
        private Button btnLimpiar;
        private Label lblPremio;
        private Label label1;
        private TextBox txtPremios;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblSorteos;
        private Label label6;
        private Label lblJugadores;
    }
}