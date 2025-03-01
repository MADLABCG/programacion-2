using System.Collections;

namespace LoteriaP2_2025_T1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            txtJugadores.Text = string.Empty;
            lblGanador.Text = string.Empty;
            lblIndice.Text = string.Empty;
            txtGanadores.Text = string.Empty;
        }

        private string[] getJugadores()
        {
            char[] delimitadores = { ',', '.', ':', '\t', '\n' };
            string[] jugadores = txtJugadores.Text.Split(delimitadores);
            return jugadores;
        }

        private string[] getGanadores()
        {
            char[] delimitadores = { ',', '.', ':', '\t', '\n' };
            string[] jugadores = txtGanadores.Text.Split(delimitadores);
            return jugadores;
        }

        private void btnSorteo_Click(object sender, EventArgs e)
        {
            string[] jugadores = getJugadores();
            if (jugadores.Length < 3)
            {
                MessageBox.Show("Jugadores Insuficientes para proceder, se necesitan al menos 3");
            }
            else
            {
                Random random = new Random();
                int ganador;
                ganador = random.Next(0, jugadores.Length);
                lblGanador.Text = jugadores[ganador];
                lblIndice.Text = ganador.ToString();
                removerGanador(jugadores[ganador]);
            }
        }

        private void removerGanador(string ganador)
        {
            ArrayList jugadores = new ArrayList(getJugadores());
            jugadores.RemoveAt(jugadores.IndexOf(ganador));
            txtJugadores.Text = String.Join(Environment.NewLine, jugadores.ToArray());
            agregarGanador(ganador);
        }

        private void agregarGanador(string ganador)
        {
            ArrayList ganadores = new ArrayList(getGanadores());
            ganadores.Add(ganador);
            txtGanadores.Text = String.Join(Environment.NewLine, ganadores.ToArray());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            inicializar();
        }
    }
}
