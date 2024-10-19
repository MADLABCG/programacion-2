namespace SelectorColores
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
            pColor = new Panel();
            lblColor = new Label();
            rbAmarillo = new RadioButton();
            rbNegro = new RadioButton();
            rbRojo = new RadioButton();
            rbNaranja = new RadioButton();
            rbVerde = new RadioButton();
            rbMorado = new RadioButton();
            rbAzul = new RadioButton();
            rbRosado = new RadioButton();
            btbEjecutar = new Button();
            SuspendLayout();
            // 
            // pColor
            // 
            pColor.BackColor = Color.Yellow;
            pColor.Location = new Point(54, 31);
            pColor.Name = "pColor";
            pColor.Size = new Size(432, 254);
            pColor.TabIndex = 0;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColor.Location = new Point(54, 288);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(117, 50);
            lblColor.TabIndex = 1;
            lblColor.Text = "Color";
            // 
            // rbAmarillo
            // 
            rbAmarillo.AutoSize = true;
            rbAmarillo.Location = new Point(64, 365);
            rbAmarillo.Name = "rbAmarillo";
            rbAmarillo.Size = new Size(74, 19);
            rbAmarillo.TabIndex = 2;
            rbAmarillo.TabStop = true;
            rbAmarillo.Text = "Amarrillo";
            rbAmarillo.UseVisualStyleBackColor = true;
            // 
            // rbNegro
            // 
            rbNegro.AutoSize = true;
            rbNegro.Location = new Point(64, 401);
            rbNegro.Name = "rbNegro";
            rbNegro.Size = new Size(58, 19);
            rbNegro.TabIndex = 3;
            rbNegro.TabStop = true;
            rbNegro.Text = "Negro";
            rbNegro.UseVisualStyleBackColor = true;
            // 
            // rbRojo
            // 
            rbRojo.AutoSize = true;
            rbRojo.Location = new Point(178, 365);
            rbRojo.Name = "rbRojo";
            rbRojo.Size = new Size(49, 19);
            rbRojo.TabIndex = 4;
            rbRojo.TabStop = true;
            rbRojo.Text = "Rojo";
            rbRojo.UseVisualStyleBackColor = true;
            // 
            // rbNaranja
            // 
            rbNaranja.AutoSize = true;
            rbNaranja.Location = new Point(178, 401);
            rbNaranja.Name = "rbNaranja";
            rbNaranja.Size = new Size(66, 19);
            rbNaranja.TabIndex = 5;
            rbNaranja.TabStop = true;
            rbNaranja.Text = "Naranja";
            rbNaranja.UseVisualStyleBackColor = true;
            // 
            // rbVerde
            // 
            rbVerde.AutoSize = true;
            rbVerde.Location = new Point(291, 365);
            rbVerde.Name = "rbVerde";
            rbVerde.Size = new Size(54, 19);
            rbVerde.TabIndex = 6;
            rbVerde.TabStop = true;
            rbVerde.Text = "Verde";
            rbVerde.UseVisualStyleBackColor = true;
            // 
            // rbMorado
            // 
            rbMorado.AutoSize = true;
            rbMorado.Location = new Point(291, 401);
            rbMorado.Name = "rbMorado";
            rbMorado.Size = new Size(67, 19);
            rbMorado.TabIndex = 7;
            rbMorado.TabStop = true;
            rbMorado.Text = "Morado";
            rbMorado.UseVisualStyleBackColor = true;
            // 
            // rbAzul
            // 
            rbAzul.AutoSize = true;
            rbAzul.Location = new Point(403, 365);
            rbAzul.Name = "rbAzul";
            rbAzul.Size = new Size(48, 19);
            rbAzul.TabIndex = 8;
            rbAzul.TabStop = true;
            rbAzul.Text = "Azul";
            rbAzul.UseVisualStyleBackColor = true;
            // 
            // rbRosado
            // 
            rbRosado.AutoSize = true;
            rbRosado.Location = new Point(403, 401);
            rbRosado.Name = "rbRosado";
            rbRosado.Size = new Size(64, 19);
            rbRosado.TabIndex = 9;
            rbRosado.TabStop = true;
            rbRosado.Text = "Rosado";
            rbRosado.UseVisualStyleBackColor = true;
            // 
            // btbEjecutar
            // 
            btbEjecutar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btbEjecutar.Location = new Point(89, 451);
            btbEjecutar.Name = "btbEjecutar";
            btbEjecutar.Size = new Size(346, 44);
            btbEjecutar.TabIndex = 10;
            btbEjecutar.Text = "Cambiar Color";
            btbEjecutar.UseVisualStyleBackColor = true;
            btbEjecutar.Click += btbEjecutar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 514);
            Controls.Add(btbEjecutar);
            Controls.Add(rbRosado);
            Controls.Add(rbAzul);
            Controls.Add(rbMorado);
            Controls.Add(rbVerde);
            Controls.Add(rbNaranja);
            Controls.Add(rbRojo);
            Controls.Add(rbNegro);
            Controls.Add(rbAmarillo);
            Controls.Add(lblColor);
            Controls.Add(pColor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pColor;
        private Label lblColor;
        private RadioButton rbAmarillo;
        private RadioButton rbNegro;
        private RadioButton rbRojo;
        private RadioButton rbNaranja;
        private RadioButton rbVerde;
        private RadioButton rbMorado;
        private RadioButton rbAzul;
        private RadioButton rbRosado;
        private Button btbEjecutar;
    }
}
