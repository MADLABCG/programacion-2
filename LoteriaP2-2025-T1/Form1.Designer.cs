namespace LoteriaP2_2025_T1
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
            btnSorteo = new Button();
            lblGanador = new Label();
            lblIndice = new Label();
            btnLimpiar = new Button();
            txtGanadores = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtJugadores
            // 
            txtJugadores.Location = new Point(31, 92);
            txtJugadores.Multiline = true;
            txtJugadores.Name = "txtJugadores";
            txtJugadores.Size = new Size(246, 333);
            txtJugadores.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 65);
            label1.Name = "label1";
            label1.Size = new Size(200, 25);
            label1.TabIndex = 1;
            label1.Text = "Lista de Participantes";
            // 
            // btnSorteo
            // 
            btnSorteo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSorteo.Location = new Point(296, 92);
            btnSorteo.Name = "btnSorteo";
            btnSorteo.Size = new Size(221, 42);
            btnSorteo.TabIndex = 2;
            btnSorteo.Text = "Sortear";
            btnSorteo.UseVisualStyleBackColor = true;
            btnSorteo.Click += btnSorteo_Click;
            // 
            // lblGanador
            // 
            lblGanador.AutoSize = true;
            lblGanador.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGanador.ForeColor = Color.Red;
            lblGanador.Location = new Point(296, 179);
            lblGanador.Name = "lblGanador";
            lblGanador.Size = new Size(97, 30);
            lblGanador.TabIndex = 3;
            lblGanador.Text = "Ganador";
            // 
            // lblIndice
            // 
            lblIndice.AutoSize = true;
            lblIndice.Location = new Point(305, 209);
            lblIndice.Name = "lblIndice";
            lblIndice.Size = new Size(13, 15);
            lblIndice.TabIndex = 4;
            lblIndice.Text = "0";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.FromArgb(255, 128, 0);
            btnLimpiar.Location = new Point(305, 381);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(212, 44);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtGanadores
            // 
            txtGanadores.Location = new Point(542, 92);
            txtGanadores.Multiline = true;
            txtGanadores.Name = "txtGanadores";
            txtGanadores.Size = new Size(246, 333);
            txtGanadores.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(542, 65);
            label2.Name = "label2";
            label2.Size = new Size(180, 25);
            label2.TabIndex = 7;
            label2.Text = "Lista de Ganadores";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtGanadores);
            Controls.Add(btnLimpiar);
            Controls.Add(lblIndice);
            Controls.Add(lblGanador);
            Controls.Add(btnSorteo);
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
        private Button btnSorteo;
        private Label lblGanador;
        private Label lblIndice;
        private Button btnLimpiar;
        private TextBox txtGanadores;
        private Label label2;
    }
}
