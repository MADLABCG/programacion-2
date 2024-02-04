namespace _20240120___P2___PrimerPrograma
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
            btnEjecutar = new Button();
            txtPregunta = new TextBox();
            lblpregunta = new Label();
            pregunta = new Panel();
            respuesta = new Panel();
            lblrespuesta = new Label();
            pregunta.SuspendLayout();
            respuesta.SuspendLayout();
            SuspendLayout();
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(299, 71);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(94, 29);
            btnEjecutar.TabIndex = 0;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // txtPregunta
            // 
            txtPregunta.Location = new Point(154, 12);
            txtPregunta.Name = "txtPregunta";
            txtPregunta.Size = new Size(580, 27);
            txtPregunta.TabIndex = 1;
            // 
            // lblpregunta
            // 
            lblpregunta.AutoSize = true;
            lblpregunta.Location = new Point(12, 15);
            lblpregunta.Name = "lblpregunta";
            lblpregunta.Size = new Size(143, 20);
            lblpregunta.TabIndex = 2;
            lblpregunta.Text = "Cual es tu nombre ?:";
            // 
            // pregunta
            // 
            pregunta.BackColor = SystemColors.GradientActiveCaption;
            pregunta.BorderStyle = BorderStyle.Fixed3D;
            pregunta.Controls.Add(lblpregunta);
            pregunta.Controls.Add(btnEjecutar);
            pregunta.Controls.Add(txtPregunta);
            pregunta.Location = new Point(29, 30);
            pregunta.Name = "pregunta";
            pregunta.Size = new Size(747, 125);
            pregunta.TabIndex = 3;
            // 
            // respuesta
            // 
            respuesta.BackColor = Color.Aquamarine;
            respuesta.BorderStyle = BorderStyle.FixedSingle;
            respuesta.Controls.Add(lblrespuesta);
            respuesta.Location = new Point(29, 173);
            respuesta.Name = "respuesta";
            respuesta.Size = new Size(747, 125);
            respuesta.TabIndex = 4;
            // 
            // lblrespuesta
            // 
            lblrespuesta.AutoSize = true;
            lblrespuesta.Location = new Point(12, 52);
            lblrespuesta.Name = "lblrespuesta";
            lblrespuesta.Size = new Size(76, 20);
            lblrespuesta.TabIndex = 0;
            lblrespuesta.Text = "Respuesta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 324);
            Controls.Add(respuesta);
            Controls.Add(pregunta);
            Name = "Form1";
            Text = "Form1";
            pregunta.ResumeLayout(false);
            pregunta.PerformLayout();
            respuesta.ResumeLayout(false);
            respuesta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEjecutar;
        private TextBox txtPregunta;
        private Label lblpregunta;
        private Panel pregunta;
        private Panel respuesta;
        private Label lblrespuesta;
    }
}
