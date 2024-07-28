namespace DigitalWatch
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
            panel1 = new Panel();
            lblFecha = new Label();
            lblReloj = new Label();
            panel2 = new Panel();
            rbPM = new RadioButton();
            rbAM = new RadioButton();
            cbAlarma = new CheckBox();
            nMinutos = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            nHoras = new NumericUpDown();
            lblAlarma = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nMinutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nHoras).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblReloj);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 222);
            panel1.TabIndex = 0;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(15, 142);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(121, 50);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            lblFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReloj
            // 
            lblReloj.AutoSize = true;
            lblReloj.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReloj.Location = new Point(15, 42);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(137, 62);
            lblReloj.TabIndex = 0;
            lblReloj.Text = "Reloj";
            lblReloj.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(rbPM);
            panel2.Controls.Add(rbAM);
            panel2.Controls.Add(cbAlarma);
            panel2.Controls.Add(nMinutos);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(nHoras);
            panel2.Location = new Point(12, 240);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 154);
            panel2.TabIndex = 1;
            // 
            // rbPM
            // 
            rbPM.AutoSize = true;
            rbPM.Location = new Point(286, 25);
            rbPM.Name = "rbPM";
            rbPM.Size = new Size(51, 24);
            rbPM.TabIndex = 7;
            rbPM.TabStop = true;
            rbPM.Text = "PM";
            rbPM.UseVisualStyleBackColor = true;
            // 
            // rbAM
            // 
            rbAM.AutoSize = true;
            rbAM.Location = new Point(218, 25);
            rbAM.Name = "rbAM";
            rbAM.Size = new Size(53, 24);
            rbAM.TabIndex = 6;
            rbAM.TabStop = true;
            rbAM.Text = "AM";
            rbAM.UseVisualStyleBackColor = true;
            // 
            // cbAlarma
            // 
            cbAlarma.AutoSize = true;
            cbAlarma.Location = new Point(180, 99);
            cbAlarma.Name = "cbAlarma";
            cbAlarma.Size = new Size(144, 24);
            cbAlarma.TabIndex = 4;
            cbAlarma.Text = "Encender Alarma";
            cbAlarma.UseVisualStyleBackColor = true;
            // 
            // nMinutos
            // 
            nMinutos.Location = new Point(94, 58);
            nMinutos.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nMinutos.Name = "nMinutos";
            nMinutos.Size = new Size(68, 27);
            nMinutos.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 65);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Minutos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 32);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 1;
            label1.Text = "Hora";
            // 
            // nHoras
            // 
            nHoras.Location = new Point(94, 25);
            nHoras.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nHoras.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nHoras.Name = "nHoras";
            nHoras.Size = new Size(68, 27);
            nHoras.TabIndex = 0;
            nHoras.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblAlarma
            // 
            lblAlarma.AutoSize = true;
            lblAlarma.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlarma.ForeColor = Color.Firebrick;
            lblAlarma.Location = new Point(453, 74);
            lblAlarma.Name = "lblAlarma";
            lblAlarma.Size = new Size(315, 106);
            lblAlarma.TabIndex = 2;
            lblAlarma.Text = "Alarma";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 424);
            Controls.Add(lblAlarma);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nMinutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nHoras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblReloj;
        private Panel panel2;
        private Label lblFecha;
        private NumericUpDown nMinutos;
        private Label label2;
        private Label label1;
        private NumericUpDown nHoras;
        private Label lblAlarma;
        private CheckBox cbAlarma;
        private RadioButton rbPM;
        private RadioButton rbAM;
    }
}
