namespace PrimerPrograma2024_02
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
            btnAsistir = new Button();
            label1 = new Label();
            txtMatricula = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnAsistir
            // 
            btnAsistir.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAsistir.Location = new Point(233, 194);
            btnAsistir.Name = "btnAsistir";
            btnAsistir.Size = new Size(137, 61);
            btnAsistir.TabIndex = 0;
            btnAsistir.Text = "Asistir";
            btnAsistir.UseVisualStyleBackColor = true;
            btnAsistir.Click += btnAsistir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 74);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Matricula";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(143, 71);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(377, 27);
            txtMatricula.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(143, 123);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(377, 27);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 126);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 284);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(txtMatricula);
            Controls.Add(label1);
            Controls.Add(btnAsistir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        
    }
}
