namespace LoteriaNombres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void sortear()
        {             
                string[] jugadores = getJugadores();
                if (validarJugadores(jugadores)) {
                    Random r = new Random();
                    int indice = r.Next(0, jugadores.Length);
                    lblGanador.Text = jugadores[indice];
                } 
        }

        private string[] getJugadores()
        {
            char[] limitadores = { ',', '.', ':', '\t', '\n' };
            string[] jugadores = txtNombres.Text.Split(limitadores);
            return jugadores;
        }

        private bool validarJugadores(string[] arreglo)
        {
            if (arreglo.Length < 4)
            {
                MessageBox.Show("Jugadores Insuficientes para el sorteo");
                return false;
            }
            return true;
        }

        private void btnSorteo_Click(object sender, EventArgs e)
        {
            sortear();
        }
    }
}
