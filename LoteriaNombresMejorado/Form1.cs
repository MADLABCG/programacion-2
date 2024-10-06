using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Drawing.Drawing2D;

namespace LoteriaNombresMejorado
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
            lblGanador.Text = string.Empty;
        }

        private string[] getJugadores()
        {
            char[] limites = { ',', '.', ':', '\t', '\n' };
            string[] jugadores = txtJugadores.Text.Split(limites);
            return jugadores;
        }

        private bool validarJugadores(string[] arreglo)
        {
            if(arreglo.Length < 2)
            {
                MessageBox.Show("Jugadores Insuficientes para el Sorteo");
                return false;
            } else
            {
                return true;
            }
        }

        private bool validarPremio(string premio)
        {
            if(premio.Length < 2)
            {
                MessageBox.Show("Por favor escriba el premio a sortear");
                return false;
            } else
            {
                return true;
            }
        }

        private void sortear()
        {
            string[] jugadores = getJugadores();
            string premio = txtPremio.Text;
            int indice = -1;
            if(validarJugadores(jugadores))
            {
                if(validarPremio(premio))
                {
                    Random r = new Random();
                    indice = r.Next(0, jugadores.Length);
                    lblGanador.Text = jugadores[indice];
                    removerJugador(jugadores[indice]);
                }
            }
        }

        private void removerJugador(string jugador)
        {
            ArrayList jugadores = new ArrayList(getJugadores());
            jugadores.RemoveAt(jugadores.IndexOf(jugador));
            txtJugadores.Text = String.Join(Environment.NewLine, jugadores.ToArray());
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            sortear();
        }
    }
}
