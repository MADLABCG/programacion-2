namespace MarrySmashPass
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
            nombre1 = new TextBox();
            nombre2 = new TextBox();
            nombre3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnJugar = new Button();
            btnLimpiar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // nombre1
            // 
            nombre1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nombre1.Location = new Point(34, 114);
            nombre1.Name = "nombre1";
            nombre1.Size = new Size(271, 33);
            nombre1.TabIndex = 0;
            // 
            // nombre2
            // 
            nombre2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nombre2.Location = new Point(34, 173);
            nombre2.Name = "nombre2";
            nombre2.Size = new Size(271, 33);
            nombre2.TabIndex = 1;
            // 
            // nombre3
            // 
            nombre3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nombre3.Location = new Point(34, 244);
            nombre3.Name = "nombre3";
            nombre3.Size = new Size(271, 33);
            nombre3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(311, 117);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(311, 176);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(311, 247);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // btnJugar
            // 
            btnJugar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnJugar.Location = new Point(34, 318);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(106, 53);
            btnJugar.TabIndex = 6;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += btnJugar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(199, 318);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(106, 53);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(34, 57);
            label4.Name = "label4";
            label4.Size = new Size(365, 25);
            label4.TabIndex = 8;
            label4.Text = "Dame 3 nombres.... y te dire como te ira";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 450);
            Controls.Add(label4);
            Controls.Add(btnLimpiar);
            Controls.Add(btnJugar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nombre3);
            Controls.Add(nombre2);
            Controls.Add(nombre1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombre1;
        private TextBox nombre2;
        private TextBox nombre3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnJugar;
        private Button btnLimpiar;
        private Label label4;
    }
}