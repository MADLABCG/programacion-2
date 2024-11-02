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


        private void inicializar()
        {
            Color blanco = Color.FromArgb(255, 255, 255);
            lblColor.Text = "Blanco";
            pColor.BackColor = blanco;
            tbTransparencia.Value = 255;
            nudTransparencia.Value = 255;
            lblTransparencia.Text = "255";

        }

        private void cambiarColor(Color color, string nombre)
        {
            pColor.BackColor = color;
            lblColor.Text = nombre;
        }

        private void cambiarColorPersonalizado()
        {
            if (cbPersonalizado.Checked)
            {
                Color personalizado = Color.FromArgb(tbTransparencia.Value, tbRojo.Value, tbVerde.Value, tbAzul.Value);
                string nombre = "RGB(" + tbTransparencia.Value + "," + tbRojo.Value + "," + tbVerde.Value + "," + tbAzul.Value + ")";
                cambiarColor(personalizado, nombre);
            }
        }

        private void cambioColor()
        {
            if (cbPersonalizado.Checked)
            {
                cambiarColorPersonalizado();
            }
            else
            {
                cambiarColorManual();
            }

        }

        private void cambiarColorManual()
        {
            int rojo = int.Parse(nudRojo.Value.ToString());
            int verde = int.Parse(nudVerde.Value.ToString());
            int azul = int.Parse(nudAzul.Value.ToString());
            int transparencia = int.Parse(nudTransparencia.Value.ToString());

            Color personalizado = Color.FromArgb(transparencia, rojo, verde, azul);
            string nombre = "RGB(" + transparencia + "," + rojo + "," + verde + "," + azul + ")";
            cambiarColor(personalizado,nombre);
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

        private void tbTransparencia_Scroll(object sender, EventArgs e)
        {
            lblTransparencia.Text = tbTransparencia.Value.ToString();
            cambiarColorPersonalizado();
        }

        private void nudRojo_ValueChanged(object sender, EventArgs e)
        {
            cambioColor();
        }

        private void nudVerde_ValueChanged(object sender, EventArgs e)
        {
            cambioColor();
        }

        private void nudAzul_ValueChanged(object sender, EventArgs e)
        {
            cambioColor();
        }

        private void nudTransparencia_ValueChanged(object sender, EventArgs e)
        {
            cambioColor();
        }
    }
}
