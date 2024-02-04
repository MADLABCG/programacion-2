namespace Loteria
{
    public partial class Form1 : Form
    {
        int sorteos;


        public Form1()
        {
            InitializeComponent();
            limpiar();
            sorteos = 0;
        }

        private void limpiar()
        {
            lblGanador.Text = string.Empty;
            lblPremio.Text = string.Empty;
            txtParticipantes.Text = string.Empty;
            txtPremios.Text = string.Empty;
        }

        private void jugar()
        {
            Random random = new Random();
            string[] participantes = convertirArregloParticipantes();
            string[] premios = convertirArregloPremios();
            int ganador;
            int premio;
            int jugadores;

            if (validarParticipantes(participantes) == true)
            {
                if (validarPremios(premios) == true)
                {
                    premio = random.Next(0, premios.Length);
                    lblPremio.Text = premios[premio];

                    ganador = random.Next(0, participantes.Length);
                    lblGanador.Text = participantes[ganador];

                    jugadores = participantes.Length;

                    sorteos++;
                    lblSorteos.Text = sorteos.ToString();
                    lblJugadores.Text = jugadores.ToString();

                }

            };
        }

        private string[] convertirArregloParticipantes()
        {
            char[] delimiterChars = { ',', '.', ':', '\t', '\n' };
            string[] participantes = txtParticipantes.Text.Split(delimiterChars);
            return participantes;
        }

        private string[] convertirArregloPremios()
        {
            char[] delimiterChars = { ',', '.', ':', '\t', '\n' };
            string[] participantes = txtPremios.Text.Split(delimiterChars);
            return participantes;
        }

        private bool validarParticipantes(string[] tempo)
        {
            bool validado = true;

            if (tempo.Length < 3)
            {
                MessageBox.Show("Participantes Insuficientes para el sorteo");
                validado = false;
            }
            return validado;
        }

        private bool validarPremios(string[] tempo)
        {
            bool validado = true;

            if (tempo[0] == "")
            {
                validado = false;
                MessageBox.Show("Premios Insuficientes para el sorteo");

                return validado;
            }

            if (tempo[0] == " ")
            {
                validado = false;
                MessageBox.Show("Premios Insuficientes para el sorteo");

                return validado;
            }

            if (tempo.Length >= 1)
            {
                return validado;
            }
            else
            {
                validado = false;
                MessageBox.Show("Premios Insuficientes para el sorteo");

                return validado;
            }



        }

        private void btnSorteo_Click(object sender, EventArgs e)
        {
            jugar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}