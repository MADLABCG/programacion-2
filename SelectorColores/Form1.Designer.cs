﻿namespace SelectorColores
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
            tbRojo = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbVerde = new TrackBar();
            tbAzul = new TrackBar();
            cbPersonalizado = new CheckBox();
            lblRojo = new Label();
            lblVerde = new Label();
            lblAzul = new Label();
            ((System.ComponentModel.ISupportInitialize)tbRojo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbVerde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAzul).BeginInit();
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
            btbEjecutar.Location = new Point(178, 459);
            btbEjecutar.Name = "btbEjecutar";
            btbEjecutar.Size = new Size(346, 44);
            btbEjecutar.TabIndex = 10;
            btbEjecutar.Text = "Cambiar Color";
            btbEjecutar.UseVisualStyleBackColor = true;
            btbEjecutar.Click += btbEjecutar_Click;
            // 
            // tbRojo
            // 
            tbRojo.Location = new Point(504, 99);
            tbRojo.Maximum = 255;
            tbRojo.Name = "tbRojo";
            tbRojo.Size = new Size(139, 45);
            tbRojo.TabIndex = 11;
            tbRojo.Scroll += tbRojo_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(504, 72);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 12;
            label1.Text = "Rojo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(504, 156);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 13;
            label2.Text = "Verde";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(510, 231);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 14;
            label3.Text = "Azul";
            // 
            // tbVerde
            // 
            tbVerde.Location = new Point(504, 183);
            tbVerde.Maximum = 255;
            tbVerde.Name = "tbVerde";
            tbVerde.Size = new Size(139, 45);
            tbVerde.TabIndex = 15;
            tbVerde.Scroll += tbVerde_Scroll;
            // 
            // tbAzul
            // 
            tbAzul.Location = new Point(504, 249);
            tbAzul.Maximum = 255;
            tbAzul.Name = "tbAzul";
            tbAzul.Size = new Size(139, 45);
            tbAzul.TabIndex = 16;
            tbAzul.Scroll += tbAzul_Scroll;
            // 
            // cbPersonalizado
            // 
            cbPersonalizado.AutoSize = true;
            cbPersonalizado.Location = new Point(509, 33);
            cbPersonalizado.Name = "cbPersonalizado";
            cbPersonalizado.Size = new Size(99, 19);
            cbPersonalizado.TabIndex = 17;
            cbPersonalizado.Text = "Personalizado";
            cbPersonalizado.UseVisualStyleBackColor = true;
            // 
            // lblRojo
            // 
            lblRojo.AutoSize = true;
            lblRojo.Location = new Point(541, 72);
            lblRojo.Name = "lblRojo";
            lblRojo.Size = new Size(13, 15);
            lblRojo.TabIndex = 18;
            lblRojo.Text = "0";
            // 
            // lblVerde
            // 
            lblVerde.AutoSize = true;
            lblVerde.Location = new Point(541, 156);
            lblVerde.Name = "lblVerde";
            lblVerde.Size = new Size(13, 15);
            lblVerde.TabIndex = 19;
            lblVerde.Text = "0";
            // 
            // lblAzul
            // 
            lblAzul.AutoSize = true;
            lblAzul.Location = new Point(541, 231);
            lblAzul.Name = "lblAzul";
            lblAzul.Size = new Size(13, 15);
            lblAzul.TabIndex = 20;
            lblAzul.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 524);
            Controls.Add(lblAzul);
            Controls.Add(lblVerde);
            Controls.Add(lblRojo);
            Controls.Add(cbPersonalizado);
            Controls.Add(tbAzul);
            Controls.Add(tbVerde);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbRojo);
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
            ((System.ComponentModel.ISupportInitialize)tbRojo).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbVerde).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAzul).EndInit();
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
        private TrackBar tbRojo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TrackBar tbVerde;
        private TrackBar tbAzul;
        private CheckBox cbPersonalizado;
        private Label lblRojo;
        private Label lblVerde;
        private Label lblAzul;
    }
}
