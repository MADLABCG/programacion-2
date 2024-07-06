using Microsoft.VisualBasic.Logging;

namespace JuegoDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int dado1 = 0;
        int dado2 = 0;


        private void lanzarDado1()
        {
            Random rnd = new Random();
            dado1 = rnd.Next(1, 6);
        }

        private void lanzarDado2()
        {
            Random rnd = new Random();
            dado2 = rnd.Next(1, 7);
        }

        private void compararDados()
        {
            if (dado1 == dado2)
            {
                lblDobles.Text = "Lanzaste un Doble";
                lblDobles.ForeColor = Color.Red;
            }
            else
            {
                lblDobles.Text = "Sigue Lanzando";
                lblDobles.ForeColor = Color.Black;
            }
        }

        private void getImages()
        {
            dado1_images();
            dado2_images();
        }

        private void dado1_images()
        {
            if (dado1 == 1)
            {
                pbDado1.Image = Properties.Resources.dice1;
            }
            if (dado1 == 2)
            {
                pbDado1.Image = Properties.Resources.dice2;
            }
            if (dado1 == 3)
            {
                pbDado1.Image = Properties.Resources.dice3;
            }
            if (dado1 == 4)
            {
                pbDado1.Image = Properties.Resources.dice4;
            }
            if (dado1 == 5)
            {
                pbDado1.Image = Properties.Resources.dice5;
            }
            if (dado1 == 6)
            {
                pbDado1.Image = Properties.Resources.dice6;
            }
        }

        private void dado2_images()
        {
            if (dado2 == 1)
            {
                pbDado2.Image = Properties.Resources.dice1;
            }
            if (dado2 == 2)
            {
                pbDado2.Image = Properties.Resources.dice2;
            }
            if (dado2 == 3)
            {
                pbDado2.Image = Properties.Resources.dice3;
            }
            if (dado2 == 4)
            {
                pbDado2.Image = Properties.Resources.dice4;
            }
            if (dado2 == 5)
            {
                pbDado2.Image = Properties.Resources.dice5;
            }
            if (dado2 == 6)
            {
                pbDado2.Image = Properties.Resources.dice6;
            }

        }

        private void btnLanzarDados_Click(object sender, EventArgs e)
        {
            lanzarDado1();
            lanzarDado2();
            getImages();
            compararDados();
        }
    }
}
