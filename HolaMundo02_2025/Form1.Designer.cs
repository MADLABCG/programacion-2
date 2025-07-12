namespace HolaMundo02_2025
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
            tbNombre = new TextBox();
            label1 = new Label();
            btnLimpiar = new Button();
            btnSaludar = new Button();
            SuspendLayout();
            // 
            // tbNombre
            // 
            tbNombre.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tbNombre.ForeColor = Color.Green;
            tbNombre.Location = new Point(49, 77);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(602, 41);
            tbNombre.TabIndex = 0;
            tbNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 24);
            label1.Name = "label1";
            label1.Size = new Size(443, 40);
            label1.TabIndex = 1;
            label1.Text = "Escriba su nombre completo";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(188, 144);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(116, 49);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSaludar
            // 
            btnSaludar.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaludar.Location = new Point(405, 144);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(116, 49);
            btnSaludar.TabIndex = 3;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 232);
            Controls.Add(btnSaludar);
            Controls.Add(btnLimpiar);
            Controls.Add(label1);
            Controls.Add(tbNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNombre;
        private Label label1;
        private Button btnLimpiar;
        private Button btnSaludar;
    }
}
