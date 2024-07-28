namespace LoteriaNombres
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
            txtNombres = new TextBox();
            label1 = new Label();
            btnSorteo = new Button();
            label2 = new Label();
            lblGanador = new Label();
            SuspendLayout();
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(34, 32);
            txtNombres.Multiline = true;
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(375, 392);
            txtNombres.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombres para Sorteo";
            // 
            // btnSorteo
            // 
            btnSorteo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSorteo.Location = new Point(415, 376);
            btnSorteo.Name = "btnSorteo";
            btnSorteo.Size = new Size(373, 48);
            btnSorteo.TabIndex = 2;
            btnSorteo.Text = "Ejecutar Sorteo";
            btnSorteo.UseVisualStyleBackColor = true;
            btnSorteo.Click += btnSorteo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(420, 37);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "Ganador";
            // 
            // lblGanador
            // 
            lblGanador.AutoSize = true;
            lblGanador.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGanador.ForeColor = Color.Red;
            lblGanador.Location = new Point(428, 64);
            lblGanador.Name = "lblGanador";
            lblGanador.Size = new Size(20, 31);
            lblGanador.TabIndex = 4;
            lblGanador.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGanador);
            Controls.Add(label2);
            Controls.Add(btnSorteo);
            Controls.Add(label1);
            Controls.Add(txtNombres);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombres;
        private Label label1;
        private Button btnSorteo;
        private Label label2;
        private Label lblGanador;
    }
}
