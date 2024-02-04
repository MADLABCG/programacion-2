using System;

namespace ContadorCaracteres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contar()
        {
            if(validar())
            {
                int espacios = txtFrase.Text.Count(Char.IsWhiteSpace);
                int caracteres = txtFrase.Text.Length - espacios;

                lblCaracteres.Text = caracteres.ToString();
                lblEspacios.Text = espacios.ToString();
            }
        }
        
        private bool validar()
        {
            bool flag = true;
            if(txtFrase.Text.Length <= 0)
            {
                flag = false;
                MessageBox.Show("No hay nada que contar");
            }
            return flag;
        }

        private void limpiar()
        {
            txtFrase.Text = string.Empty;
            lblCaracteres.Text = "0";
            lblEspacios.Text = "0";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            contar();
        }
    }
}