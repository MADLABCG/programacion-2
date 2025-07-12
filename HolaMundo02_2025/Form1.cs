namespace HolaMundo02_2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            tbNombre.Text = string.Empty;
            tbNombre.Focus();
        }

        private void saludar()
        {
            string nombre = tbNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingrese su nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNombre.Focus();
                return;
            } else {
                string saludo = "Hola " + nombre + ", bienvenido a la programación en C# y .NET 9.0!";
                MessageBox.Show(saludo, "Saludo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            saludar();
        }
    }
}
