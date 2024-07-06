namespace Loteria1
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
            btnSorteoP1 = new Button();
            nHastaP1 = new NumericUpDown();
            nDesdeP1 = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            lblPremio1 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnSorteoP3 = new Button();
            nHastaP3 = new NumericUpDown();
            lblPremio3 = new Label();
            nDesdeP3 = new NumericUpDown();
            label8 = new Label();
            label3 = new Label();
            label9 = new Label();
            panel3 = new Panel();
            btnSorteoP2 = new Button();
            nHastaP2 = new NumericUpDown();
            lblPremio2 = new Label();
            nDesdeP2 = new NumericUpDown();
            label6 = new Label();
            label2 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nHastaP1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nDesdeP1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nHastaP3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nDesdeP3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nHastaP2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nDesdeP2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnSorteoP1);
            panel1.Controls.Add(nHastaP1);
            panel1.Controls.Add(nDesdeP1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblPremio1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(27, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 402);
            panel1.TabIndex = 0;
            // 
            // btnSorteoP1
            // 
            btnSorteoP1.Location = new Point(19, 296);
            btnSorteoP1.Name = "btnSorteoP1";
            btnSorteoP1.Size = new Size(193, 89);
            btnSorteoP1.TabIndex = 8;
            btnSorteoP1.Text = "Sorteo Premio 1";
            btnSorteoP1.UseVisualStyleBackColor = true;
            btnSorteoP1.Click += btnSorteoP1_Click;
            // 
            // nHastaP1
            // 
            nHastaP1.Location = new Point(78, 220);
            nHastaP1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nHastaP1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nHastaP1.Name = "nHastaP1";
            nHastaP1.Size = new Size(134, 27);
            nHastaP1.TabIndex = 7;
            nHastaP1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nDesdeP1
            // 
            nDesdeP1.Location = new Point(78, 188);
            nDesdeP1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nDesdeP1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nDesdeP1.Name = "nDesdeP1";
            nDesdeP1.Size = new Size(134, 27);
            nDesdeP1.TabIndex = 6;
            nDesdeP1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 223);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 5;
            label5.Text = "Hasta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 190);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 4;
            label4.Text = "Desde";
            // 
            // lblPremio1
            // 
            lblPremio1.AutoSize = true;
            lblPremio1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPremio1.Location = new Point(78, 105);
            lblPremio1.Name = "lblPremio1";
            lblPremio1.Size = new Size(70, 31);
            lblPremio1.TabIndex = 1;
            lblPremio1.Text = "####";
            lblPremio1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 12);
            label1.Name = "label1";
            label1.Size = new Size(169, 31);
            label1.TabIndex = 0;
            label1.Text = "Primer Premio";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnSorteoP3);
            panel2.Controls.Add(nHastaP3);
            panel2.Controls.Add(lblPremio3);
            panel2.Controls.Add(nDesdeP3);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(541, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 402);
            panel2.TabIndex = 1;
            // 
            // btnSorteoP3
            // 
            btnSorteoP3.Location = new Point(14, 296);
            btnSorteoP3.Name = "btnSorteoP3";
            btnSorteoP3.Size = new Size(193, 89);
            btnSorteoP3.TabIndex = 12;
            btnSorteoP3.Text = "Sorteo Premio 3";
            btnSorteoP3.UseVisualStyleBackColor = true;
            btnSorteoP3.Click += btnSorteoP3_Click;
            // 
            // nHastaP3
            // 
            nHastaP3.Location = new Point(73, 215);
            nHastaP3.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nHastaP3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nHastaP3.Name = "nHastaP3";
            nHastaP3.Size = new Size(134, 27);
            nHastaP3.TabIndex = 15;
            nHastaP3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblPremio3
            // 
            lblPremio3.AutoSize = true;
            lblPremio3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPremio3.Location = new Point(84, 105);
            lblPremio3.Name = "lblPremio3";
            lblPremio3.Size = new Size(70, 31);
            lblPremio3.TabIndex = 3;
            lblPremio3.Text = "####";
            lblPremio3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nDesdeP3
            // 
            nDesdeP3.Location = new Point(73, 183);
            nDesdeP3.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nDesdeP3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nDesdeP3.Name = "nDesdeP3";
            nDesdeP3.Size = new Size(134, 27);
            nDesdeP3.TabIndex = 14;
            nDesdeP3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 218);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 13;
            label8.Text = "Hasta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 11);
            label3.Name = "label3";
            label3.Size = new Size(161, 31);
            label3.TabIndex = 2;
            label3.Text = "Tercer Premio";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 185);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 12;
            label9.Text = "Desde";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnSorteoP2);
            panel3.Controls.Add(nHastaP2);
            panel3.Controls.Add(lblPremio2);
            panel3.Controls.Add(nDesdeP2);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(290, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(229, 402);
            panel3.TabIndex = 2;
            // 
            // btnSorteoP2
            // 
            btnSorteoP2.Location = new Point(18, 296);
            btnSorteoP2.Name = "btnSorteoP2";
            btnSorteoP2.Size = new Size(193, 89);
            btnSorteoP2.TabIndex = 9;
            btnSorteoP2.Text = "Sorteo Premio 2";
            btnSorteoP2.UseVisualStyleBackColor = true;
            btnSorteoP2.Click += btnSorteoP2_Click;
            // 
            // nHastaP2
            // 
            nHastaP2.Location = new Point(75, 215);
            nHastaP2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nHastaP2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nHastaP2.Name = "nHastaP2";
            nHastaP2.Size = new Size(134, 27);
            nHastaP2.TabIndex = 11;
            nHastaP2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblPremio2
            // 
            lblPremio2.AutoSize = true;
            lblPremio2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPremio2.Location = new Point(75, 105);
            lblPremio2.Name = "lblPremio2";
            lblPremio2.Size = new Size(70, 31);
            lblPremio2.TabIndex = 2;
            lblPremio2.Text = "####";
            lblPremio2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nDesdeP2
            // 
            nDesdeP2.Location = new Point(75, 183);
            nDesdeP2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nDesdeP2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nDesdeP2.Name = "nDesdeP2";
            nDesdeP2.Size = new Size(134, 27);
            nDesdeP2.TabIndex = 10;
            nDesdeP2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 218);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 9;
            label6.Text = "Hasta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 9);
            label2.Name = "label2";
            label2.Size = new Size(192, 31);
            label2.TabIndex = 1;
            label2.Text = "Segundo Premio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 185);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 8;
            label7.Text = "Desde";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 450);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nHastaP1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nDesdeP1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nHastaP3).EndInit();
            ((System.ComponentModel.ISupportInitialize)nDesdeP3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nHastaP2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nDesdeP2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private Label lblPremio1;
        private Label lblPremio3;
        private Label lblPremio2;
        private NumericUpDown nHastaP2;
        private NumericUpDown nDesdeP2;
        private Label label6;
        private Label label7;
        private NumericUpDown nHastaP1;
        private NumericUpDown nDesdeP1;
        private Label label5;
        private Label label4;
        private NumericUpDown nHastaP3;
        private NumericUpDown nDesdeP3;
        private Label label8;
        private Label label9;
        private Button btnSorteoP1;
        private Button btnSorteoP3;
        private Button btnSorteoP2;
    }
}
