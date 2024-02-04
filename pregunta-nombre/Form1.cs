namespace _20240120___P2___PrimerPrograma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            respuesta.BackColor = Color.Yellow; 
            lblrespuesta.Font = new Font("Arial", 20, FontStyle.Bold);
            lblrespuesta.Text = "Mi nombre es: " + txtPregunta.Text;
        }
    }
}
