using System.Windows.Forms;

namespace ProgramaPreguntas
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            Color boton = Color.FromArgb(250, 249, 217);
            Color azul = Color.FromArgb(13, 0, 255);

            lblRespuesta.Text = string.Empty;
            lblRespuesta.ForeColor = azul;
            this.Text = "Formulario Nombre";
            btnAceptar.ForeColor = azul;
            btnAceptar.BackColor = boton;
        }

        private string saludo()
        {
            string saludo = "Hola, mi nombre es: \n";
            string nombre = txtNombre.Text;
            return saludo + nombre;
        }

        private bool verificar()
        {
            if (txtNombre.Text.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void saludar()
        {
            if (verificar())
            {
                lblRespuesta.Text = saludo();
            } else
            {
                MessageBox.Show("Debe de escribir un nombre al menos");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            saludar();
        }
    }
}
