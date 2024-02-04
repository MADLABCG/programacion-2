namespace JuegoDados
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
            pbDado1 = new PictureBox();
            pbDado2 = new PictureBox();
            lDado1 = new Label();
            lDado2 = new Label();
            lMensaje = new Label();
            btnJugar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbDado1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDado2).BeginInit();
            SuspendLayout();
            // 
            // pbDado1
            // 
            pbDado1.Location = new Point(72, 37);
            pbDado1.Name = "pbDado1";
            pbDado1.Size = new Size(229, 219);
            pbDado1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDado1.TabIndex = 0;
            pbDado1.TabStop = false;
            // 
            // pbDado2
            // 
            pbDado2.Location = new Point(405, 37);
            pbDado2.Name = "pbDado2";
            pbDado2.Size = new Size(229, 219);
            pbDado2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDado2.TabIndex = 1;
            pbDado2.TabStop = false;
            // 
            // lDado1
            // 
            lDado1.AutoSize = true;
            lDado1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lDado1.Location = new Point(151, 259);
            lDado1.Name = "lDado1";
            lDado1.Size = new Size(76, 25);
            lDado1.TabIndex = 2;
            lDado1.Text = "Dado 1";
            // 
            // lDado2
            // 
            lDado2.AutoSize = true;
            lDado2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lDado2.Location = new Point(486, 259);
            lDado2.Name = "lDado2";
            lDado2.Size = new Size(76, 25);
            lDado2.TabIndex = 3;
            lDado2.Text = "Dado 2";
            // 
            // lMensaje
            // 
            lMensaje.AutoSize = true;
            lMensaje.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lMensaje.Location = new Point(72, 310);
            lMensaje.Name = "lMensaje";
            lMensaje.Size = new Size(85, 25);
            lMensaje.TabIndex = 4;
            lMensaje.Text = "Mensaje";
            // 
            // btnJugar
            // 
            btnJugar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnJugar.Location = new Point(72, 353);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(562, 56);
            btnJugar.TabIndex = 5;
            btnJugar.Text = "Jugar!!";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += btnJugar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 450);
            Controls.Add(btnJugar);
            Controls.Add(lMensaje);
            Controls.Add(lDado2);
            Controls.Add(lDado1);
            Controls.Add(pbDado2);
            Controls.Add(pbDado1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbDado1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDado2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbDado1;
        private PictureBox pbDado2;
        private Label lDado1;
        private Label lDado2;
        private Label lMensaje;
        private Button btnJugar;
    }
}