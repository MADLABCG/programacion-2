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
            pictureBox1 = new PictureBox();
            btnLanzarDados = new Button();
            lblDobles = new Label();
            pbDado1 = new PictureBox();
            pbDado2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDado1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDado2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_dados;
            pictureBox1.Location = new Point(22, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(397, 275);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnLanzarDados
            // 
            btnLanzarDados.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLanzarDados.ForeColor = Color.MidnightBlue;
            btnLanzarDados.Location = new Point(603, 324);
            btnLanzarDados.Name = "btnLanzarDados";
            btnLanzarDados.Size = new Size(332, 83);
            btnLanzarDados.TabIndex = 5;
            btnLanzarDados.Text = "Lanzar los Dados";
            btnLanzarDados.UseVisualStyleBackColor = true;
            btnLanzarDados.Click += btnLanzarDados_Click;
            // 
            // lblDobles
            // 
            lblDobles.AutoSize = true;
            lblDobles.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDobles.ForeColor = Color.Red;
            lblDobles.Location = new Point(464, 277);
            lblDobles.Name = "lblDobles";
            lblDobles.Size = new Size(0, 38);
            lblDobles.TabIndex = 6;
            // 
            // pbDado1
            // 
            pbDado1.Location = new Point(451, 59);
            pbDado1.Name = "pbDado1";
            pbDado1.Size = new Size(74, 69);
            pbDado1.TabIndex = 7;
            pbDado1.TabStop = false;
            // 
            // pbDado2
            // 
            pbDado2.Location = new Point(540, 59);
            pbDado2.Name = "pbDado2";
            pbDado2.Size = new Size(69, 69);
            pbDado2.TabIndex = 8;
            pbDado2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 429);
            Controls.Add(pbDado2);
            Controls.Add(pbDado1);
            Controls.Add(lblDobles);
            Controls.Add(btnLanzarDados);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDado1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDado2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnLanzarDados;
        private Label lblDobles;
        private PictureBox pbDado1;
        private PictureBox pbDado2;
    }
}
