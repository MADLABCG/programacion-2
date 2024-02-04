namespace PrimerEjercicioP2
{
    partial class Formulario1
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
            btnAceptar = new Button();
            chkActivo = new CheckBox();
            cbProfesores = new ComboBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            selectorAlmunos = new NumericUpDown();
            rbProgramacion1 = new RadioButton();
            rbProgramacion2 = new RadioButton();
            rbProgramacion3 = new RadioButton();
            tbComentarios = new TextBox();
            gbClases = new GroupBox();
            fechaClases = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            tbResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)selectorAlmunos).BeginInit();
            gbClases.SuspendLayout();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(334, 325);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(230, 108);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(89, 19);
            chkActivo.TabIndex = 1;
            chkActivo.Text = "Esta Activo?";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // cbProfesores
            // 
            cbProfesores.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProfesores.FormattingEnabled = true;
            cbProfesores.Items.AddRange(new object[] { "Altagracia Crecencio", "Carlos Jose Arias", "Elias Castillo", "Evany Polanco", "Ivan Firestone", "Jose Perez", "Lorendy Reyes", "Maria Castillo", "Pedro Rodriguez" });
            cbProfesores.Location = new Point(230, 70);
            cbProfesores.Name = "cbProfesores";
            cbProfesores.Size = new Size(245, 23);
            cbProfesores.Sorted = true;
            cbProfesores.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 43);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 3;
            label1.Text = "Seleccione el Profesor";
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(770, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // selectorAlmunos
            // 
            selectorAlmunos.Location = new Point(554, 70);
            selectorAlmunos.Name = "selectorAlmunos";
            selectorAlmunos.Size = new Size(120, 23);
            selectorAlmunos.TabIndex = 5;
            // 
            // rbProgramacion1
            // 
            rbProgramacion1.AutoSize = true;
            rbProgramacion1.Location = new Point(6, 22);
            rbProgramacion1.Name = "rbProgramacion1";
            rbProgramacion1.Size = new Size(109, 19);
            rbProgramacion1.TabIndex = 6;
            rbProgramacion1.TabStop = true;
            rbProgramacion1.Text = "Programacion 1";
            rbProgramacion1.UseVisualStyleBackColor = true;
            // 
            // rbProgramacion2
            // 
            rbProgramacion2.AutoSize = true;
            rbProgramacion2.Location = new Point(6, 47);
            rbProgramacion2.Name = "rbProgramacion2";
            rbProgramacion2.Size = new Size(109, 19);
            rbProgramacion2.TabIndex = 7;
            rbProgramacion2.TabStop = true;
            rbProgramacion2.Text = "Programacion 2";
            rbProgramacion2.UseVisualStyleBackColor = true;
            // 
            // rbProgramacion3
            // 
            rbProgramacion3.AutoSize = true;
            rbProgramacion3.Location = new Point(6, 73);
            rbProgramacion3.Name = "rbProgramacion3";
            rbProgramacion3.Size = new Size(109, 19);
            rbProgramacion3.TabIndex = 8;
            rbProgramacion3.TabStop = true;
            rbProgramacion3.Text = "Programacion 3";
            rbProgramacion3.UseVisualStyleBackColor = true;
            // 
            // tbComentarios
            // 
            tbComentarios.Location = new Point(12, 187);
            tbComentarios.Multiline = true;
            tbComentarios.Name = "tbComentarios";
            tbComentarios.Size = new Size(742, 132);
            tbComentarios.TabIndex = 9;
            tbComentarios.Text = "asdfsfdgsdfgsdgsdfgs";
            // 
            // gbClases
            // 
            gbClases.Controls.Add(rbProgramacion1);
            gbClases.Controls.Add(rbProgramacion2);
            gbClases.Controls.Add(rbProgramacion3);
            gbClases.Location = new Point(12, 27);
            gbClases.Name = "gbClases";
            gbClases.Size = new Size(200, 100);
            gbClases.TabIndex = 10;
            gbClases.TabStop = false;
            gbClases.Text = "Seleccione la Clase";
            // 
            // fechaClases
            // 
            fechaClases.Location = new Point(554, 130);
            fechaClases.Name = "fechaClases";
            fechaClases.Size = new Size(200, 23);
            fechaClases.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(552, 43);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 12;
            label2.Text = "Cantidad de Alumnos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(552, 108);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 13;
            label3.Text = "Fecha de Clases";
            // 
            // tbResultado
            // 
            tbResultado.Enabled = false;
            tbResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tbResultado.Location = new Point(12, 364);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(742, 132);
            tbResultado.TabIndex = 14;
            tbResultado.Text = "asdfasdfasdfadsfasdf";
            // 
            // Formulario1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 541);
            Controls.Add(tbResultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(fechaClases);
            Controls.Add(gbClases);
            Controls.Add(tbComentarios);
            Controls.Add(selectorAlmunos);
            Controls.Add(label1);
            Controls.Add(cbProfesores);
            Controls.Add(chkActivo);
            Controls.Add(btnAceptar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Formulario1";
            Text = "Ejercicio 1 - Programacion 2";
            ((System.ComponentModel.ISupportInitialize)selectorAlmunos).EndInit();
            gbClases.ResumeLayout(false);
            gbClases.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private CheckBox chkActivo;
        private ComboBox cbProfesores;
        private Label label1;
        private MenuStrip menuStrip1;
        private NumericUpDown selectorAlmunos;
        private RadioButton rbProgramacion1;
        private RadioButton rbProgramacion2;
        private RadioButton rbProgramacion3;
        private TextBox tbComentarios;
        private GroupBox gbClases;
        private DateTimePicker fechaClases;
        private Label label2;
        private Label label3;
        private TextBox tbResultado;
    }
}