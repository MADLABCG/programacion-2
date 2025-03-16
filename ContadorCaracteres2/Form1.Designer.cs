namespace ContadorCaracteres2
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
            txtTexto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblPuntuacion = new Label();
            lblAcentos = new Label();
            lblMinusculas = new Label();
            lblMayusculas = new Label();
            lblEspacios = new Label();
            lblLetras = new Label();
            btnContar = new Button();
            btnLimpiar = new Button();
            lblCaracteres = new Label();
            label8 = new Label();
            lblNumeros = new Label();
            label9 = new Label();
            lblEspeciales = new Label();
            label11 = new Label();
            lblPalabras = new Label();
            label10 = new Label();
            lblTildeA = new Label();
            label12 = new Label();
            lblTildeE = new Label();
            label14 = new Label();
            lblTildeI = new Label();
            label16 = new Label();
            lblTildeO = new Label();
            label18 = new Label();
            lblTildeU = new Label();
            label20 = new Label();
            SuspendLayout();
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(12, 12);
            txtTexto.Multiline = true;
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(776, 209);
            txtTexto.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 265);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 1;
            label1.Text = "Cantidad Letras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 288);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 2;
            label2.Text = "Cantidad Espacios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 311);
            label3.Name = "label3";
            label3.Size = new Size(154, 15);
            label3.TabIndex = 3;
            label3.Text = "Cantidad Letras Mayusculas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 334);
            label4.Name = "label4";
            label4.Size = new Size(152, 15);
            label4.TabIndex = 4;
            label4.Text = "Cantidad Letras Minusculas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 356);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 5;
            label5.Text = "Cantidad de Acentos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 379);
            label6.Name = "label6";
            label6.Size = new Size(157, 15);
            label6.TabIndex = 6;
            label6.Text = "Cantidad Signos Puntuacion";
            // 
            // lblPuntuacion
            // 
            lblPuntuacion.AutoSize = true;
            lblPuntuacion.Location = new Point(176, 379);
            lblPuntuacion.Name = "lblPuntuacion";
            lblPuntuacion.Size = new Size(13, 15);
            lblPuntuacion.TabIndex = 12;
            lblPuntuacion.Text = "0";
            // 
            // lblAcentos
            // 
            lblAcentos.AutoSize = true;
            lblAcentos.Location = new Point(176, 356);
            lblAcentos.Name = "lblAcentos";
            lblAcentos.Size = new Size(13, 15);
            lblAcentos.TabIndex = 11;
            lblAcentos.Text = "0";
            // 
            // lblMinusculas
            // 
            lblMinusculas.AutoSize = true;
            lblMinusculas.Location = new Point(176, 334);
            lblMinusculas.Name = "lblMinusculas";
            lblMinusculas.Size = new Size(13, 15);
            lblMinusculas.TabIndex = 10;
            lblMinusculas.Text = "0";
            // 
            // lblMayusculas
            // 
            lblMayusculas.AutoSize = true;
            lblMayusculas.Location = new Point(176, 311);
            lblMayusculas.Name = "lblMayusculas";
            lblMayusculas.Size = new Size(13, 15);
            lblMayusculas.TabIndex = 9;
            lblMayusculas.Text = "0";
            // 
            // lblEspacios
            // 
            lblEspacios.AutoSize = true;
            lblEspacios.Location = new Point(176, 288);
            lblEspacios.Name = "lblEspacios";
            lblEspacios.Size = new Size(13, 15);
            lblEspacios.TabIndex = 8;
            lblEspacios.Text = "0";
            // 
            // lblLetras
            // 
            lblLetras.AutoSize = true;
            lblLetras.Location = new Point(176, 265);
            lblLetras.Name = "lblLetras";
            lblLetras.Size = new Size(13, 15);
            lblLetras.TabIndex = 7;
            lblLetras.Text = "0";
            // 
            // btnContar
            // 
            btnContar.Location = new Point(410, 362);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(186, 48);
            btnContar.TabIndex = 13;
            btnContar.Text = "Contar";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += btnContar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(602, 362);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(186, 48);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblCaracteres
            // 
            lblCaracteres.AutoSize = true;
            lblCaracteres.Location = new Point(176, 243);
            lblCaracteres.Name = "lblCaracteres";
            lblCaracteres.Size = new Size(13, 15);
            lblCaracteres.TabIndex = 16;
            lblCaracteres.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 243);
            label8.Name = "label8";
            label8.Size = new Size(113, 15);
            label8.TabIndex = 15;
            label8.Text = "Cantidad Caracteres";
            // 
            // lblNumeros
            // 
            lblNumeros.AutoSize = true;
            lblNumeros.Location = new Point(402, 243);
            lblNumeros.Name = "lblNumeros";
            lblNumeros.Size = new Size(13, 15);
            lblNumeros.TabIndex = 18;
            lblNumeros.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(238, 243);
            label9.Name = "label9";
            label9.Size = new Size(107, 15);
            label9.TabIndex = 17;
            label9.Text = "Cantidad Numeros";
            // 
            // lblEspeciales
            // 
            lblEspeciales.AutoSize = true;
            lblEspeciales.Location = new Point(402, 265);
            lblEspeciales.Name = "lblEspeciales";
            lblEspeciales.Size = new Size(13, 15);
            lblEspeciales.TabIndex = 20;
            lblEspeciales.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(238, 265);
            label11.Name = "label11";
            label11.Size = new Size(85, 15);
            label11.TabIndex = 19;
            label11.Text = "Cantidad ñ - Ñ";
            // 
            // lblPalabras
            // 
            lblPalabras.AutoSize = true;
            lblPalabras.Location = new Point(402, 288);
            lblPalabras.Name = "lblPalabras";
            lblPalabras.Size = new Size(13, 15);
            lblPalabras.TabIndex = 22;
            lblPalabras.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(238, 288);
            label10.Name = "label10";
            label10.Size = new Size(118, 15);
            label10.TabIndex = 21;
            label10.Text = "Cantidad de Palabras";
            // 
            // lblTildeA
            // 
            lblTildeA.AutoSize = true;
            lblTildeA.Location = new Point(607, 243);
            lblTildeA.Name = "lblTildeA";
            lblTildeA.Size = new Size(13, 15);
            lblTildeA.TabIndex = 24;
            lblTildeA.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(443, 243);
            label12.Name = "label12";
            label12.Size = new Size(118, 15);
            label12.TabIndex = 23;
            label12.Text = "Cantidad A con Tilde";
            // 
            // lblTildeE
            // 
            lblTildeE.AutoSize = true;
            lblTildeE.Location = new Point(607, 265);
            lblTildeE.Name = "lblTildeE";
            lblTildeE.Size = new Size(13, 15);
            lblTildeE.TabIndex = 26;
            lblTildeE.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(443, 265);
            label14.Name = "label14";
            label14.Size = new Size(116, 15);
            label14.TabIndex = 25;
            label14.Text = "Cantidad E con Tilde";
            // 
            // lblTildeI
            // 
            lblTildeI.AutoSize = true;
            lblTildeI.Location = new Point(607, 288);
            lblTildeI.Name = "lblTildeI";
            lblTildeI.Size = new Size(13, 15);
            lblTildeI.TabIndex = 28;
            lblTildeI.Text = "0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(443, 288);
            label16.Name = "label16";
            label16.Size = new Size(113, 15);
            label16.TabIndex = 27;
            label16.Text = "Cantidad I con Tilde";
            // 
            // lblTildeO
            // 
            lblTildeO.AutoSize = true;
            lblTildeO.Location = new Point(607, 311);
            lblTildeO.Name = "lblTildeO";
            lblTildeO.Size = new Size(13, 15);
            lblTildeO.TabIndex = 30;
            lblTildeO.Text = "0";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(443, 311);
            label18.Name = "label18";
            label18.Size = new Size(119, 15);
            label18.TabIndex = 29;
            label18.Text = "Cantidad O con Tilde";
            // 
            // lblTildeU
            // 
            lblTildeU.AutoSize = true;
            lblTildeU.Location = new Point(607, 334);
            lblTildeU.Name = "lblTildeU";
            lblTildeU.Size = new Size(13, 15);
            lblTildeU.TabIndex = 32;
            lblTildeU.Text = "0";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(443, 334);
            label20.Name = "label20";
            label20.Size = new Size(118, 15);
            label20.TabIndex = 31;
            label20.Text = "Cantidad U con Tilde";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 430);
            Controls.Add(lblTildeU);
            Controls.Add(label20);
            Controls.Add(lblTildeO);
            Controls.Add(label18);
            Controls.Add(lblTildeI);
            Controls.Add(label16);
            Controls.Add(lblTildeE);
            Controls.Add(label14);
            Controls.Add(lblTildeA);
            Controls.Add(label12);
            Controls.Add(lblPalabras);
            Controls.Add(label10);
            Controls.Add(lblEspeciales);
            Controls.Add(label11);
            Controls.Add(lblNumeros);
            Controls.Add(label9);
            Controls.Add(lblCaracteres);
            Controls.Add(label8);
            Controls.Add(btnLimpiar);
            Controls.Add(btnContar);
            Controls.Add(lblPuntuacion);
            Controls.Add(lblAcentos);
            Controls.Add(lblMinusculas);
            Controls.Add(lblMayusculas);
            Controls.Add(lblEspacios);
            Controls.Add(lblLetras);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTexto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTexto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblPuntuacion;
        private Label lblAcentos;
        private Label lblMinusculas;
        private Label lblMayusculas;
        private Label lblEspacios;
        private Label lblLetras;
        private Button btnContar;
        private Button btnLimpiar;
        private Label lblCaracteres;
        private Label label8;
        private Label lblNumeros;
        private Label label9;
        private Label lblEspeciales;
        private Label label11;
        private Label lblPalabras;
        private Label label10;
        private Label lblTildeA;
        private Label label12;
        private Label lblTildeE;
        private Label label14;
        private Label lblTildeI;
        private Label label16;
        private Label lblTildeO;
        private Label label18;
        private Label lblTildeU;
        private Label label20;
    }
}
