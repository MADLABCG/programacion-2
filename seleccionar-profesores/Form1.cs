namespace PrimerEjercicioP2
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            cbProfesores.SelectedIndex = 0;
            tbResultado.Text = string.Empty;
            tbComentarios.Text = string.Empty;
            rbProgramacion1.Checked = true;
            chkActivo.Checked = true;
            selectorAlmunos.Value = 6;

        }

        private void informacion()
        {
            string clase = "No Seleccionada";
            string profesor = cbProfesores.SelectedItem.ToString();
            string alumnos = selectorAlmunos.Value.ToString();
            string fecha = fechaClases.Value.ToString();
            string topico = tbComentarios.Text;

            if (rbProgramacion1.Checked == true)
            {
                clase = rbProgramacion1.Text;
            }
            if (rbProgramacion2.Checked == true)
            {
                clase = rbProgramacion2.Text;
            }
            if (rbProgramacion3.Checked == true)
            {
                clase = rbProgramacion3.Text;
            }

            string texto = "El Profesor(a) " + profesor + " de la case " + clase + ", tiene la cantidad de " + alumnos + " alumnos, en la docencia del dia "+ fecha + ", el tema de esta clase era: " + topico;

            tbResultado.Text = texto;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            informacion();
        }
    }
}