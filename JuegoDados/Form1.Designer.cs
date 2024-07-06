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
            label1 = new Label();
            label2 = new Label();
            lblDado1 = new Label();
            lblDado2 = new Label();
            btnLanzarDados = new Button();
            lblDobles = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(451, 59);
            label1.Name = "label1";
            label1.Size = new Size(118, 41);
            label1.TabIndex = 1;
            label1.Text = "Dado 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(455, 204);
            label2.Name = "label2";
            label2.Size = new Size(118, 41);
            label2.TabIndex = 2;
            label2.Text = "Dado 2";
            // 
            // lblDado1
            // 
            lblDado1.AutoSize = true;
            lblDado1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDado1.Location = new Point(603, 52);
            lblDado1.Name = "lblDado1";
            lblDado1.Size = new Size(46, 54);
            lblDado1.TabIndex = 3;
            lblDado1.Text = "0";
            // 
            // lblDado2
            // 
            lblDado2.AutoSize = true;
            lblDado2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDado2.Location = new Point(603, 196);
            lblDado2.Name = "lblDado2";
            lblDado2.Size = new Size(46, 54);
            lblDado2.TabIndex = 4;
            lblDado2.Text = "0";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 429);
            Controls.Add(lblDobles);
            Controls.Add(btnLanzarDados);
            Controls.Add(lblDado2);
            Controls.Add(lblDado1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label lblDado1;
        private Label lblDado2;
        private Button btnLanzarDados;
        private Label lblDobles;
    }
}
