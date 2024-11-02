using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace SelectorColores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inicializar();
        }

        Color amarillo = Color.FromArgb(255, 255, 0);
        Color negro = Color.FromArgb(0, 0, 0);
        Color rojo = Color.FromArgb(255, 0, 0);
        Color naranja = Color.FromArgb(255, 153, 51);
        Color morado = Color.FromArgb(102, 0, 204);
        Color verde = Color.FromArgb(51, 102, 0);
        Color azul = Color.FromArgb(0, 0, 255);
        Color rosado = Color.FromArgb(255, 0, 255);


        private void inicializar()
        {
            Color blanco = Color.FromArgb(255, 255, 255);
            lblColor.Text = "Blanco";
            pColor.BackColor = blanco;

        }

        private void cambiarColor(Color color, string nombre)
        {
            pColor.BackColor = color;
            lblColor.Text = nombre;
        }

        private void cambiarColorPersonalizado()
        {
            if (cbPersonalizado.Checked) {
                Color personalizado = Color.FromArgb(tbRojo.Value, tbVerde.Value, tbAzul.Value);
                cambiarColor(personalizado, "RGB("+tbRojo.Value+","+tbVerde.Value+","+tbAzul.Value+")");
            }
        }

        private void cambioColor()
        {
            if (cbPersonalizado.Checked)
            {
                cambiarColorPersonalizado();
            } else
            {
                selector();
            }

        }

        private void selector()
        {
            
            if (rbAmarillo.Checked)
            {
                cambiarColor(amarillo, "Amarillo");
            }
            if (rbNegro.Checked)
            {
                cambiarColor(negro, "Negro");
            }
            if (rbRojo.Checked)
            {
                cambiarColor(rojo, "Rojo");
            }
            if (rbNaranja.Checked)
            {
                cambiarColor(naranja, "Naranja");
            }
            if (rbVerde.Checked)
            {
                cambiarColor(verde, "Verde");
            }
            if (rbMorado.Checked)
            {
                cambiarColor(morado, "Morado");
            }
            if (rbAzul.Checked)
            {
                cambiarColor(azul, "Azul");
            }
            if (rbRosado.Checked)
            {
                cambiarColor(rosado, "Rosado");
            }
        }

        private void btbEjecutar_Click(object sender, EventArgs e)
        {
            cambioColor();
        }

        private void tbRojo_Scroll(object sender, EventArgs e)
        {
            lblRojo.Text = tbRojo.Value.ToString();
            cambiarColorPersonalizado();
        }

        private void tbVerde_Scroll(object sender, EventArgs e)
        {
            lblVerde.Text = tbVerde.Value.ToString();
            cambiarColorPersonalizado();
        }

        private void tbAzul_Scroll(object sender, EventArgs e)
        {
            lblAzul.Text = tbAzul.Value.ToString();
            cambiarColorPersonalizado();
        }
    }
}
