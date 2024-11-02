namespace SelectorColores
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
            pColor = new Panel();
            lblColor = new Label();
            btbEjecutar = new Button();
            tbRojo = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbVerde = new TrackBar();
            tbAzul = new TrackBar();
            cbPersonalizado = new CheckBox();
            lblRojo = new Label();
            lblVerde = new Label();
            lblAzul = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            nudRojo = new NumericUpDown();
            nudVerde = new NumericUpDown();
            nudAzul = new NumericUpDown();
            label7 = new Label();
            nudTransparencia = new NumericUpDown();
            tbTransparencia = new TrackBar();
            lblTransparencia = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)tbRojo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbVerde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAzul).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRojo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudVerde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAzul).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTransparencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbTransparencia).BeginInit();
            SuspendLayout();
            // 
            // pColor
            // 
            pColor.BackColor = Color.Yellow;
            pColor.Location = new Point(54, 31);
            pColor.Name = "pColor";
            pColor.Size = new Size(432, 254);
            pColor.TabIndex = 0;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColor.Location = new Point(54, 288);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(117, 50);
            lblColor.TabIndex = 1;
            lblColor.Text = "Color";
            // 
            // btbEjecutar
            // 
            btbEjecutar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btbEjecutar.Location = new Point(158, 410);
            btbEjecutar.Name = "btbEjecutar";
            btbEjecutar.Size = new Size(346, 44);
            btbEjecutar.TabIndex = 10;
            btbEjecutar.Text = "Cambiar Color";
            btbEjecutar.UseVisualStyleBackColor = true;
            btbEjecutar.Click += btbEjecutar_Click;
            // 
            // tbRojo
            // 
            tbRojo.Location = new Point(504, 73);
            tbRojo.Maximum = 255;
            tbRojo.Name = "tbRojo";
            tbRojo.Size = new Size(139, 45);
            tbRojo.TabIndex = 11;
            tbRojo.Scroll += tbRojo_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(504, 55);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 12;
            label1.Text = "Rojo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(504, 121);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 13;
            label2.Text = "Verde";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(509, 187);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 14;
            label3.Text = "Azul";
            // 
            // tbVerde
            // 
            tbVerde.Location = new Point(504, 139);
            tbVerde.Maximum = 255;
            tbVerde.Name = "tbVerde";
            tbVerde.Size = new Size(139, 45);
            tbVerde.TabIndex = 15;
            tbVerde.Scroll += tbVerde_Scroll;
            // 
            // tbAzul
            // 
            tbAzul.Location = new Point(504, 205);
            tbAzul.Maximum = 255;
            tbAzul.Name = "tbAzul";
            tbAzul.Size = new Size(139, 45);
            tbAzul.TabIndex = 16;
            tbAzul.Scroll += tbAzul_Scroll;
            // 
            // cbPersonalizado
            // 
            cbPersonalizado.AutoSize = true;
            cbPersonalizado.Location = new Point(509, 33);
            cbPersonalizado.Name = "cbPersonalizado";
            cbPersonalizado.Size = new Size(99, 19);
            cbPersonalizado.TabIndex = 17;
            cbPersonalizado.Text = "Personalizado";
            cbPersonalizado.UseVisualStyleBackColor = true;
            // 
            // lblRojo
            // 
            lblRojo.AutoSize = true;
            lblRojo.Location = new Point(541, 55);
            lblRojo.Name = "lblRojo";
            lblRojo.Size = new Size(13, 15);
            lblRojo.TabIndex = 18;
            lblRojo.Text = "0";
            // 
            // lblVerde
            // 
            lblVerde.AutoSize = true;
            lblVerde.Location = new Point(541, 121);
            lblVerde.Name = "lblVerde";
            lblVerde.Size = new Size(13, 15);
            lblVerde.TabIndex = 19;
            lblVerde.Text = "0";
            // 
            // lblAzul
            // 
            lblAzul.AutoSize = true;
            lblAzul.Location = new Point(540, 187);
            lblAzul.Name = "lblAzul";
            lblAzul.Size = new Size(13, 15);
            lblAzul.TabIndex = 20;
            lblAzul.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 363);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 21;
            label4.Text = "Rojo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(193, 363);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 22;
            label5.Text = "Verde";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(334, 363);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 23;
            label6.Text = "Azul";
            // 
            // nudRojo
            // 
            nudRojo.Location = new Point(102, 361);
            nudRojo.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudRojo.Name = "nudRojo";
            nudRojo.Size = new Size(69, 23);
            nudRojo.TabIndex = 24;
            nudRojo.ValueChanged += nudRojo_ValueChanged;
            // 
            // nudVerde
            // 
            nudVerde.Location = new Point(235, 361);
            nudVerde.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudVerde.Name = "nudVerde";
            nudVerde.Size = new Size(76, 23);
            nudVerde.TabIndex = 25;
            nudVerde.ValueChanged += nudVerde_ValueChanged;
            // 
            // nudAzul
            // 
            nudAzul.Location = new Point(370, 361);
            nudAzul.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudAzul.Name = "nudAzul";
            nudAzul.Size = new Size(83, 23);
            nudAzul.TabIndex = 26;
            nudAzul.ValueChanged += nudAzul_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(475, 363);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 27;
            label7.Text = "Transparencia";
            // 
            // nudTransparencia
            // 
            nudTransparencia.Location = new Point(560, 361);
            nudTransparencia.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudTransparencia.Name = "nudTransparencia";
            nudTransparencia.Size = new Size(83, 23);
            nudTransparencia.TabIndex = 28;
            nudTransparencia.ValueChanged += nudTransparencia_ValueChanged;
            // 
            // tbTransparencia
            // 
            tbTransparencia.Location = new Point(509, 273);
            tbTransparencia.Maximum = 255;
            tbTransparencia.Name = "tbTransparencia";
            tbTransparencia.Size = new Size(139, 45);
            tbTransparencia.TabIndex = 29;
            tbTransparencia.Scroll += tbTransparencia_Scroll;
            // 
            // lblTransparencia
            // 
            lblTransparencia.AutoSize = true;
            lblTransparencia.Location = new Point(595, 253);
            lblTransparencia.Name = "lblTransparencia";
            lblTransparencia.Size = new Size(13, 15);
            lblTransparencia.TabIndex = 31;
            lblTransparencia.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(510, 253);
            label9.Name = "label9";
            label9.Size = new Size(79, 15);
            label9.TabIndex = 30;
            label9.Text = "Transparencia";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 471);
            Controls.Add(lblTransparencia);
            Controls.Add(label9);
            Controls.Add(tbTransparencia);
            Controls.Add(nudTransparencia);
            Controls.Add(label7);
            Controls.Add(nudAzul);
            Controls.Add(nudVerde);
            Controls.Add(nudRojo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblAzul);
            Controls.Add(lblVerde);
            Controls.Add(lblRojo);
            Controls.Add(cbPersonalizado);
            Controls.Add(tbAzul);
            Controls.Add(tbVerde);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbRojo);
            Controls.Add(btbEjecutar);
            Controls.Add(lblColor);
            Controls.Add(pColor);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tbRojo).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbVerde).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAzul).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRojo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudVerde).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAzul).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTransparencia).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbTransparencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pColor;
        private Label lblColor;
        private Button btbEjecutar;
        private TrackBar tbRojo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TrackBar tbVerde;
        private TrackBar tbAzul;
        private CheckBox cbPersonalizado;
        private Label lblRojo;
        private Label lblVerde;
        private Label lblAzul;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown nudRojo;
        private NumericUpDown nudVerde;
        private NumericUpDown nudAzul;
        private Label label7;
        private NumericUpDown nudTransparencia;
        private TrackBar tbTransparencia;
        private Label lblTransparencia;
        private Label label9;
    }
}
