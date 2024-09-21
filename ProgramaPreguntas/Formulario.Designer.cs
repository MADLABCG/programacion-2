namespace ProgramaPreguntas
{
    partial class Formulario
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
            txtNombre = new TextBox();
            btnAceptar = new Button();
            lblRespuesta = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 271);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 34);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 6;
            label1.Text = "Cual es tu nombre?";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(219, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(344, 29);
            txtNombre.TabIndex = 7;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe Script", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.Red;
            btnAceptar.Location = new Point(322, 238);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(124, 45);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRespuesta.Location = new Point(219, 136);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(234, 31);
            lblRespuesta.TabIndex = 9;
            lblRespuesta.Text = "Aqui va respuesta";
            // 
            // Formulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 295);
            Controls.Add(lblRespuesta);
            Controls.Add(btnAceptar);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Formulario";
            Text = "Formulario Nombre";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtNombre;
        private Button btnAceptar;
        private Label lblRespuesta;
    }
}
