namespace ConvertidorCelciusFarenheit
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
            txtTemperatura = new TextBox();
            label1 = new Label();
            lblResultado = new Label();
            lblGrados = new Label();
            button1 = new Button();
            rbCelcius = new RadioButton();
            rbFarenheit = new RadioButton();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtTemperatura
            // 
            txtTemperatura.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtTemperatura.Location = new Point(12, 53);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.Size = new Size(168, 38);
            txtTemperatura.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 19);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 1;
            label1.Text = "Temperatura Actual";
            // 
            // lblResultado
            // 
            lblResultado.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.FromArgb(192, 0, 0);
            lblResultado.Location = new Point(19, 111);
            lblResultado.Name = "lblResultado";
            lblResultado.RightToLeft = RightToLeft.No;
            lblResultado.Size = new Size(158, 41);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado";
            lblResultado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGrados
            // 
            lblGrados.AutoSize = true;
            lblGrados.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrados.ForeColor = Color.FromArgb(192, 0, 0);
            lblGrados.Location = new Point(183, 111);
            lblGrados.Name = "lblGrados";
            lblGrados.Size = new Size(79, 41);
            lblGrados.TabIndex = 3;
            lblGrados.Text = "C | F";
            lblGrados.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(30, 172);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Convertir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rbCelcius
            // 
            rbCelcius.AutoSize = true;
            rbCelcius.Location = new Point(204, 33);
            rbCelcius.Name = "rbCelcius";
            rbCelcius.Size = new Size(75, 24);
            rbCelcius.TabIndex = 5;
            rbCelcius.TabStop = true;
            rbCelcius.Text = "Celsius";
            rbCelcius.UseVisualStyleBackColor = true;
            // 
            // rbFarenheit
            // 
            rbFarenheit.AutoSize = true;
            rbFarenheit.Location = new Point(204, 63);
            rbFarenheit.Name = "rbFarenheit";
            rbFarenheit.Size = new Size(90, 24);
            rbFarenheit.TabIndex = 6;
            rbFarenheit.TabStop = true;
            rbFarenheit.Text = "Farenheit";
            rbFarenheit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(130, 172);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 223);
            Controls.Add(button2);
            Controls.Add(rbFarenheit);
            Controls.Add(rbCelcius);
            Controls.Add(button1);
            Controls.Add(lblGrados);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Controls.Add(txtTemperatura);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTemperatura;
        private Label label1;
        private Label lblResultado;
        private Label lblGrados;
        private Button button1;
        private RadioButton rbCelcius;
        private RadioButton rbFarenheit;
        private Button button2;
    }
}