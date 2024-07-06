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
            lblDado1.Text = dado1.ToString();
        }

        private void lanzarDado2()
        {
            Random rnd = new Random();
            dado2 = rnd.Next(1, 7);
            lblDado2.Text = dado2.ToString();
            
            // Image i = Image.FromFile("dice2.png"); // read in image
            // lblDado2.Size = new Size(i.Width, i.Height); //set label to correct size
            // lblDado2.Image = i; // put image on label
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

        private void btnLanzarDados_Click(object sender, EventArgs e)
        {
            lanzarDado1();
            lanzarDado2();
            compararDados();
        }
    }
}
