namespace Loteria2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            limpiar();
        }

        private void limpiar()
        {
            txtJugadores.Text = string.Empty;
            txtPremio.Text = string.Empty;
            lblGanador.Text = string.Empty;
            lblPremio.Text = string.Empty;
            lblInfo.Text = string.Empty;
        }

        private void previoSorteo()
        {
            lblGanador.Text = string.Empty;
            lblPremio.Text = string.Empty;
            lblInfo.Text = string.Empty;
            
        }

        private void sorteo()
        {
            Random random = new Random();
            string[] jugadores = getJugadores();
            string premio = txtPremio.Text;
            int ganador;
            

            if (validarJugadores(jugadores) == true)
            {
                if(validarPremio(premio) == true)
                {
                    previoSorteo();
                    System.Threading.Thread.Sleep(3000);
                    ganador = random.Next(0, jugadores.Length);
                    lblGanador.Text = jugadores[ganador];
                    lblInfo.Text = "ha ganado";
                    lblPremio.Text = premio;
                }
            };
        }

        private string[] getJugadores()
        {
            char[] limitadores = { ',', '.', ':', '\t', '\n' };
            string[] jugadores = txtJugadores.Text.Split(limitadores);
            return jugadores;
        }

        private bool validarJugadores(string[] arreglo)
        {
            bool validado = true;

            if (arreglo.Length < 4)
            {
                MessageBox.Show("Jugadores Insuficientes para el sorteo");
                validado = false;
            }
            return validado;
        }

        private bool validarPremio(string premio)
        {
            bool validado = true;

            if (premio.Length <= 0)
            {
                MessageBox.Show("No hay un premio definido para el sorteo");
                validado = false;
            }
            return validado;
        }



        private void btnSorteo_Click(object sender, EventArgs e)
        {
            sorteo();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
