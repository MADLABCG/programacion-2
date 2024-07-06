namespace PrimerPrograma2024_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string alumno()
        {
            return "El Alumno: " + txtNombre.Text + " Matricula: " + txtMatricula.Text;
        }
        
        
        

        private bool validar()
        {
            if (txtMatricula.Text.Length <= 0)
            {
                MessageBox.Show("Debe de Indicar la matricula del alumno");
                return false;
            }

            if (txtNombre.Text.Length <= 0)
            {
                MessageBox.Show("Debe de Indicar el nombre del alumno");
                return false;
            }

            return true;
        }

        private void btnAsistir_Click(object sender, EventArgs e)
        {
            if (validar() == true)
            {
                MessageBox.Show(alumno() + " Asisto a la clase");
            }
        }
    }
}
