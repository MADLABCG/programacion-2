namespace ContadorCaracteres2025_02
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
            btnContar = new Button();
            btnLimpiar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblTildes = new Label();
            lblSignos = new Label();
            lblEspacios = new Label();
            lblLetras = new Label();
            lblNumeros = new Label();
            label6 = new Label();
            lblTotal = new Label();
            label7 = new Label();
            lblPalabras = new Label();
            SuspendLayout();
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(12, 12);
            txtTexto.Multiline = true;
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(776, 263);
            txtTexto.TabIndex = 0;
            // 
            // btnContar
            // 
            btnContar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnContar.Location = new Point(590, 395);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(96, 43);
            btnContar.TabIndex = 1;
            btnContar.Text = "Contar";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += btnContar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnLimpiar.Location = new Point(692, 395);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(96, 43);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(17, 299);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 3;
            label1.Text = "Tildes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(17, 331);
            label2.Name = "label2";
            label2.Size = new Size(153, 21);
            label2.TabIndex = 4;
            label2.Text = "Signos Puntuacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(17, 361);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 5;
            label3.Text = "Espacios";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(17, 395);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 6;
            label4.Text = "Letras";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(285, 361);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 7;
            label5.Text = "Total";
            // 
            // lblTildes
            // 
            lblTildes.AutoSize = true;
            lblTildes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTildes.ForeColor = Color.Red;
            lblTildes.Location = new Point(78, 299);
            lblTildes.Name = "lblTildes";
            lblTildes.Size = new Size(19, 21);
            lblTildes.TabIndex = 8;
            lblTildes.Text = "0";
            // 
            // lblSignos
            // 
            lblSignos.AutoSize = true;
            lblSignos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignos.ForeColor = Color.Red;
            lblSignos.Location = new Point(177, 331);
            lblSignos.Name = "lblSignos";
            lblSignos.Size = new Size(19, 21);
            lblSignos.TabIndex = 9;
            lblSignos.Text = "0";
            // 
            // lblEspacios
            // 
            lblEspacios.AutoSize = true;
            lblEspacios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEspacios.ForeColor = Color.Red;
            lblEspacios.Location = new Point(109, 361);
            lblEspacios.Name = "lblEspacios";
            lblEspacios.Size = new Size(19, 21);
            lblEspacios.TabIndex = 10;
            lblEspacios.Text = "0";
            // 
            // lblLetras
            // 
            lblLetras.AutoSize = true;
            lblLetras.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLetras.ForeColor = Color.Red;
            lblLetras.Location = new Point(78, 395);
            lblLetras.Name = "lblLetras";
            lblLetras.Size = new Size(19, 21);
            lblLetras.TabIndex = 11;
            lblLetras.Text = "0";
            // 
            // lblNumeros
            // 
            lblNumeros.AutoSize = true;
            lblNumeros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeros.ForeColor = Color.Red;
            lblNumeros.Location = new Point(371, 299);
            lblNumeros.Name = "lblNumeros";
            lblNumeros.Size = new Size(19, 21);
            lblNumeros.TabIndex = 12;
            lblNumeros.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(285, 299);
            label6.Name = "label6";
            label6.Size = new Size(80, 21);
            label6.TabIndex = 13;
            label6.Text = "Numeros";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Red;
            lblTotal.Location = new Point(339, 361);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(19, 21);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(285, 331);
            label7.Name = "label7";
            label7.Size = new Size(75, 21);
            label7.TabIndex = 16;
            label7.Text = "Palabras";
            // 
            // lblPalabras
            // 
            lblPalabras.AutoSize = true;
            lblPalabras.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPalabras.ForeColor = Color.Red;
            lblPalabras.Location = new Point(371, 331);
            lblPalabras.Name = "lblPalabras";
            lblPalabras.Size = new Size(19, 21);
            lblPalabras.TabIndex = 15;
            lblPalabras.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(lblPalabras);
            Controls.Add(lblTotal);
            Controls.Add(label6);
            Controls.Add(lblNumeros);
            Controls.Add(lblLetras);
            Controls.Add(lblEspacios);
            Controls.Add(lblSignos);
            Controls.Add(lblTildes);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnContar);
            Controls.Add(txtTexto);
            Name = "Form1";
            Text = "Contador de Caracteres";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTexto;
        private Button btnContar;
        private Button btnLimpiar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblTildes;
        private Label lblSignos;
        private Label lblEspacios;
        private Label lblLetras;
        private Label lblNumeros;
        private Label label6;
        private Label lblTotal;
        private Label label7;
        private Label lblPalabras;
    }
}
