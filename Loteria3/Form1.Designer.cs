namespace Loteria3
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
            lblResultado = new Label();
            btnSorteo = new Button();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(127, 66);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(119, 54);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "####";
            // 
            // btnSorteo
            // 
            btnSorteo.Location = new Point(12, 139);
            btnSorteo.Name = "btnSorteo";
            btnSorteo.Size = new Size(362, 87);
            btnSorteo.TabIndex = 1;
            btnSorteo.Text = "Sortear";
            btnSorteo.UseVisualStyleBackColor = true;
            btnSorteo.Click += btnSorteo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 245);
            Controls.Add(btnSorteo);
            Controls.Add(lblResultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private Button btnSorteo;
    }
}
