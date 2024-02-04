using System.Reflection.Metadata.Ecma335;

namespace JuegoDados
{
    public partial class Form1 : Form
    {

        int dado1, dado2;

        public Form1()
        {
            InitializeComponent();
            cleanup();
        }

        private void cleanup()
        {
            dado1 = 0;
            dado2 = 0;
            lDado1.Text = string.Empty;
            lDado2.Text = string.Empty;
            lMensaje.Text = string.Empty;
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            
            String mensaje = null;
            Random random = new Random();
            dado1 = random.Next(1, 7);
            dado2 = random.Next(1, 7);
            if (dado1 == dado2)
            {
                mensaje = "Sacaste dobles!!";
            }

            lDado1.Text = dado1.ToString();
            lDado2.Text = dado2.ToString();
            lMensaje.Text = mensaje;
            getImages();

        }

        private void getImages()
        {
            dado1_images();
            dado2_images();
        }

        private void dado1_images()
        {
            if(dado1 == 1 )
            {
                pbDado1.Image = Image.FromFile("dice1.png");
            }
            if (dado1 == 2)
            {
                pbDado1.Image = Image.FromFile("dice2.png");
            }
            if (dado1 == 3)
            {
                pbDado1.Image = Image.FromFile("dice3.png");
            }
            if (dado1 == 4)
            {
                pbDado1.Image = Image.FromFile("dice4.png");
            }
            if (dado1 == 5)
            {
                pbDado1.Image = Image.FromFile("dice5.png");
            }
            if (dado1 == 6)
            {
                pbDado1.Image = Image.FromFile("dice6.png");
            }
        }

        private void dado2_images()
        {
            if (dado2 == 1)
            {
                pbDado2.Image = Image.FromFile("dice1.png");
            }
            if (dado2 == 2)
            {
                pbDado2.Image = Image.FromFile("dice2.png");
            }
            if (dado2 == 3)
            {
                pbDado2.Image = Image.FromFile("dice3.png");
            }
            if (dado2 == 4)
            {
                pbDado2.Image = Image.FromFile("dice4.png");
            }
            if (dado2 == 5)
            {
                pbDado2.Image = Image.FromFile("dice5.png");
            }
            if (dado2 == 6)
            {
                pbDado2.Image = Image.FromFile("dice6.png");
            }

        }
    }
}