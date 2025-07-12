namespace SelectorColores3
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
            tbRed = new TrackBar();
            pColor = new Panel();
            tbGreen = new TrackBar();
            tbBlue = new TrackBar();
            lblRed = new Label();
            lblGreen = new Label();
            lblBlue = new Label();
            btnCopiar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCopiarRGB = new Button();
            ((System.ComponentModel.ISupportInitialize)tbRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbBlue).BeginInit();
            SuspendLayout();
            // 
            // tbRed
            // 
            tbRed.Location = new Point(12, 184);
            tbRed.Maximum = 255;
            tbRed.Name = "tbRed";
            tbRed.Size = new Size(467, 45);
            tbRed.TabIndex = 0;
            tbRed.Scroll += tbRed_Scroll;
            // 
            // pColor
            // 
            pColor.BackColor = Color.White;
            pColor.BorderStyle = BorderStyle.FixedSingle;
            pColor.Location = new Point(12, 12);
            pColor.Name = "pColor";
            pColor.Size = new Size(510, 144);
            pColor.TabIndex = 1;
            // 
            // tbGreen
            // 
            tbGreen.Location = new Point(12, 246);
            tbGreen.Maximum = 255;
            tbGreen.Name = "tbGreen";
            tbGreen.Size = new Size(467, 45);
            tbGreen.TabIndex = 2;
            tbGreen.Scroll += tbGreen_Scroll;
            // 
            // tbBlue
            // 
            tbBlue.Location = new Point(14, 312);
            tbBlue.Maximum = 255;
            tbBlue.Name = "tbBlue";
            tbBlue.Size = new Size(467, 45);
            tbBlue.TabIndex = 3;
            tbBlue.Scroll += tbBlue_Scroll;
            // 
            // lblRed
            // 
            lblRed.AutoSize = true;
            lblRed.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRed.Location = new Point(485, 184);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(37, 21);
            lblRed.TabIndex = 4;
            lblRed.Text = "000";
            // 
            // lblGreen
            // 
            lblGreen.AutoSize = true;
            lblGreen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGreen.Location = new Point(485, 246);
            lblGreen.Name = "lblGreen";
            lblGreen.Size = new Size(37, 21);
            lblGreen.TabIndex = 5;
            lblGreen.Text = "000";
            // 
            // lblBlue
            // 
            lblBlue.AutoSize = true;
            lblBlue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBlue.Location = new Point(485, 312);
            lblBlue.Name = "lblBlue";
            lblBlue.Size = new Size(37, 21);
            lblBlue.TabIndex = 6;
            lblBlue.Text = "000";
            // 
            // btnCopiar
            // 
            btnCopiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCopiar.Location = new Point(14, 363);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(176, 40);
            btnCopiar.TabIndex = 7;
            btnCopiar.Text = "Copiar HEX";
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 160);
            label1.Name = "label1";
            label1.Size = new Size(39, 21);
            label1.TabIndex = 8;
            label1.Text = "Red";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 222);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 9;
            label2.Text = "Green";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 288);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 10;
            label3.Text = "Blue";
            // 
            // btnCopiarRGB
            // 
            btnCopiarRGB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCopiarRGB.Location = new Point(303, 363);
            btnCopiarRGB.Name = "btnCopiarRGB";
            btnCopiarRGB.Size = new Size(176, 40);
            btnCopiarRGB.TabIndex = 11;
            btnCopiarRGB.Text = "Copiar RGB";
            btnCopiarRGB.UseVisualStyleBackColor = true;
            btnCopiarRGB.Click += btnCopiarRGB_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 425);
            Controls.Add(btnCopiarRGB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCopiar);
            Controls.Add(lblBlue);
            Controls.Add(lblGreen);
            Controls.Add(lblRed);
            Controls.Add(tbBlue);
            Controls.Add(tbGreen);
            Controls.Add(pColor);
            Controls.Add(tbRed);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tbRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar tbRed;
        private Panel pColor;
        private TrackBar tbGreen;
        private TrackBar tbBlue;
        private Label lblRed;
        private Label lblGreen;
        private Label lblBlue;
        private Button btnCopiar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCopiarRGB;
    }
}
