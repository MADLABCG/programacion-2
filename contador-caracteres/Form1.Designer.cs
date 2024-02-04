namespace ContadorCaracteres
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
            txtFrase = new TextBox();
            label1 = new Label();
            btnContar = new Button();
            btnLimpiar = new Button();
            label2 = new Label();
            label3 = new Label();
            lblCaracteres = new Label();
            lblEspacios = new Label();
            SuspendLayout();
            // 
            // txtFrase
            // 
            txtFrase.Location = new Point(147, 41);
            txtFrase.Name = "txtFrase";
            txtFrase.Size = new Size(579, 27);
            txtFrase.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 47);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 1;
            label1.Text = "Palabra o Frase :";
            // 
            // btnContar
            // 
            btnContar.Location = new Point(404, 91);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(94, 29);
            btnContar.TabIndex = 2;
            btnContar.Text = "Contar";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += btnContar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(285, 91);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(106, 170);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 4;
            label2.Text = "Cantidad Caracteres: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(53, 205);
            label3.Name = "label3";
            label3.Size = new Size(210, 20);
            label3.TabIndex = 5;
            label3.Text = "Cantidad Espacios en Blanco:";
            // 
            // lblCaracteres
            // 
            lblCaracteres.AutoSize = true;
            lblCaracteres.Location = new Point(261, 170);
            lblCaracteres.Name = "lblCaracteres";
            lblCaracteres.Size = new Size(17, 20);
            lblCaracteres.TabIndex = 6;
            lblCaracteres.Text = "0";
            // 
            // lblEspacios
            // 
            lblEspacios.AutoSize = true;
            lblEspacios.Location = new Point(261, 205);
            lblEspacios.Name = "lblEspacios";
            lblEspacios.Size = new Size(17, 20);
            lblEspacios.TabIndex = 7;
            lblEspacios.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 283);
            Controls.Add(lblEspacios);
            Controls.Add(lblCaracteres);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLimpiar);
            Controls.Add(btnContar);
            Controls.Add(label1);
            Controls.Add(txtFrase);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFrase;
        private Label label1;
        private Button btnContar;
        private Button btnLimpiar;
        private Label label2;
        private Label label3;
        private Label lblCaracteres;
        private Label lblEspacios;
    }
}