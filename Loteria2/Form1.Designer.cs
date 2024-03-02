namespace Loteria2
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
            txtJugadores = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txtPremio = new TextBox();
            label2 = new Label();
            lblGanador = new Label();
            lblPremio = new Label();
            lblInfo = new Label();
            btnSorteo = new Button();
            btnLimpiar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtJugadores);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 426);
            panel1.TabIndex = 0;
            // 
            // txtJugadores
            // 
            txtJugadores.Location = new Point(7, 56);
            txtJugadores.Multiline = true;
            txtJugadores.Name = "txtJugadores";
            txtJugadores.Size = new Size(272, 354);
            txtJugadores.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 12);
            label1.Name = "label1";
            label1.Size = new Size(123, 31);
            label1.TabIndex = 0;
            label1.Text = "Jugadores";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtPremio);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(311, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(352, 102);
            panel2.TabIndex = 1;
            // 
            // txtPremio
            // 
            txtPremio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPremio.Location = new Point(14, 51);
            txtPremio.Name = "txtPremio";
            txtPremio.Size = new Size(324, 34);
            txtPremio.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(91, 31);
            label2.TabIndex = 2;
            label2.Text = "Premio";
            // 
            // lblGanador
            // 
            lblGanador.AutoSize = true;
            lblGanador.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGanador.Location = new Point(311, 139);
            lblGanador.Name = "lblGanador";
            lblGanador.Size = new Size(108, 31);
            lblGanador.TabIndex = 2;
            lblGanador.Text = "Ganador";
            // 
            // lblPremio
            // 
            lblPremio.AutoSize = true;
            lblPremio.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPremio.Location = new Point(315, 211);
            lblPremio.Name = "lblPremio";
            lblPremio.Size = new Size(90, 31);
            lblPremio.TabIndex = 3;
            lblPremio.Text = "Premio";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblInfo.ForeColor = Color.Red;
            lblInfo.Location = new Point(426, 178);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(131, 31);
            lblInfo.TabIndex = 4;
            lblInfo.Text = "ha ganado";
            // 
            // btnSorteo
            // 
            btnSorteo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSorteo.ForeColor = Color.MidnightBlue;
            btnSorteo.Location = new Point(326, 272);
            btnSorteo.Name = "btnSorteo";
            btnSorteo.Size = new Size(324, 91);
            btnSorteo.TabIndex = 5;
            btnSorteo.Text = "Ejecutar Sorteo";
            btnSorteo.UseVisualStyleBackColor = true;
            btnSorteo.Click += btnSorteo_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.Red;
            btnLimpiar.Location = new Point(435, 378);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSorteo);
            Controls.Add(lblInfo);
            Controls.Add(lblPremio);
            Controls.Add(lblGanador);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtJugadores;
        private Label label1;
        private Panel panel2;
        private TextBox txtPremio;
        private Label label2;
        private Label lblGanador;
        private Label lblPremio;
        private Label lblInfo;
        private Button btnSorteo;
        private Button btnLimpiar;
    }
}
