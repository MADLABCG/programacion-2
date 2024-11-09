namespace CalculadoraP2
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
            txtResultado = new TextBox();
            btnSumar = new Button();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnCuadrado = new Button();
            btnInverso = new Button();
            btnModulo = new Button();
            btnItbis = new Button();
            panel1 = new Panel();
            btnIgual = new Button();
            btnCA = new Button();
            btnEnter = new Button();
            btnC = new Button();
            btn0 = new Button();
            btnPunto = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.LightGreen;
            txtResultado.Enabled = false;
            txtResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(21, 15);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.RightToLeft = RightToLeft.No;
            txtResultado.Size = new Size(318, 149);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSumar
            // 
            btnSumar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnSumar.Location = new Point(21, 170);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(75, 45);
            btnSumar.TabIndex = 1;
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnRestar
            // 
            btnRestar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRestar.Location = new Point(102, 170);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(75, 45);
            btnRestar.TabIndex = 2;
            btnRestar.Text = "-";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnMultiplicar.Location = new Point(183, 170);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 45);
            btnMultiplicar.TabIndex = 3;
            btnMultiplicar.Text = "*";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnDividir.Location = new Point(264, 170);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 45);
            btnDividir.TabIndex = 4;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnCuadrado
            // 
            btnCuadrado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCuadrado.Location = new Point(264, 221);
            btnCuadrado.Name = "btnCuadrado";
            btnCuadrado.Size = new Size(75, 45);
            btnCuadrado.TabIndex = 8;
            btnCuadrado.Text = "Cuadrado";
            btnCuadrado.UseVisualStyleBackColor = true;
            btnCuadrado.Click += btnCuadrado_Click;
            // 
            // btnInverso
            // 
            btnInverso.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnInverso.Location = new Point(183, 221);
            btnInverso.Name = "btnInverso";
            btnInverso.Size = new Size(75, 45);
            btnInverso.TabIndex = 7;
            btnInverso.Text = "Inverso";
            btnInverso.UseVisualStyleBackColor = true;
            btnInverso.Click += btnInverso_Click;
            // 
            // btnModulo
            // 
            btnModulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnModulo.Location = new Point(102, 221);
            btnModulo.Name = "btnModulo";
            btnModulo.Size = new Size(75, 45);
            btnModulo.TabIndex = 6;
            btnModulo.Text = "Modulo";
            btnModulo.UseVisualStyleBackColor = true;
            btnModulo.Click += btnModulo_Click;
            // 
            // btnItbis
            // 
            btnItbis.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnItbis.Location = new Point(21, 221);
            btnItbis.Name = "btnItbis";
            btnItbis.Size = new Size(75, 45);
            btnItbis.TabIndex = 5;
            btnItbis.Text = "ITBIS";
            btnItbis.UseVisualStyleBackColor = true;
            btnItbis.Click += btnItbis_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnIgual);
            panel1.Controls.Add(btnCA);
            panel1.Controls.Add(btnEnter);
            panel1.Controls.Add(btnC);
            panel1.Controls.Add(btn0);
            panel1.Controls.Add(btnPunto);
            panel1.Controls.Add(btn9);
            panel1.Controls.Add(btn8);
            panel1.Controls.Add(btn7);
            panel1.Controls.Add(btn6);
            panel1.Controls.Add(btn5);
            panel1.Controls.Add(btn4);
            panel1.Controls.Add(btn3);
            panel1.Controls.Add(btn2);
            panel1.Controls.Add(btn1);
            panel1.Location = new Point(12, 272);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 278);
            panel1.TabIndex = 10;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIgual.Location = new Point(251, 135);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(75, 60);
            btnIgual.TabIndex = 14;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnCA
            // 
            btnCA.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCA.Location = new Point(251, 201);
            btnCA.Name = "btnCA";
            btnCA.Size = new Size(75, 60);
            btnCA.TabIndex = 13;
            btnCA.Text = "CA";
            btnCA.UseVisualStyleBackColor = true;
            btnCA.Click += btnCA_Click;
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEnter.Location = new Point(251, 3);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(75, 126);
            btnEnter.TabIndex = 12;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnC.Location = new Point(170, 201);
            btnC.Name = "btnC";
            btnC.Size = new Size(75, 60);
            btnC.TabIndex = 11;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn0.Location = new Point(89, 201);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 60);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnPunto
            // 
            btnPunto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPunto.Location = new Point(8, 201);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(75, 60);
            btnPunto.TabIndex = 9;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn9.Location = new Point(170, 135);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 60);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn8.Location = new Point(89, 135);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 60);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn7.Location = new Point(8, 135);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 60);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn6.Location = new Point(170, 69);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 60);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn5.Location = new Point(89, 69);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 60);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn4.Location = new Point(8, 69);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 60);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn3.Location = new Point(170, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 60);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn2.Location = new Point(89, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 60);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn1.Location = new Point(8, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 60);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 565);
            Controls.Add(panel1);
            Controls.Add(btnCuadrado);
            Controls.Add(btnInverso);
            Controls.Add(btnModulo);
            Controls.Add(btnItbis);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(txtResultado);
            Name = "Form1";
            Text = "Calculadora";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnCuadrado;
        private Button btnInverso;
        private Button btnModulo;
        private Button btnItbis;
        private Panel panel1;
        private Button btnC;
        private Button btn0;
        private Button btnPunto;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnCA;
        private Button btnEnter;
        private Button btnIgual;
    }
}
