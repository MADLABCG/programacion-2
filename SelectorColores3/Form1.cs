namespace SelectorColores3
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
            tbRed.Value = 0;
            tbGreen.Value = 0;
            tbBlue.Value = 0;
            actualizarColor();
            actualizarContadores();
        }

        private void actualizarColor()
        {
            int red = tbRed.Value;
            int green = tbGreen.Value;
            int blue = tbBlue.Value;
            pColor.BackColor = Color.FromArgb(red, green, blue);
        }

        private void actualizarContadores()
        {
            lblRed.Text = tbRed.Value.ToString();
            lblGreen.Text = tbGreen.Value.ToString();
            lblBlue.Text = tbBlue.Value.ToString();
        }

        private void tbRed_Scroll(object sender, EventArgs e)
        {
            actualizarColor();
            actualizarContadores();
        }

        private void tbGreen_Scroll(object sender, EventArgs e)
        {
            actualizarColor();
            actualizarContadores();
        }

        private void tbBlue_Scroll(object sender, EventArgs e)
        {
            actualizarColor();
            actualizarContadores();
        }

        private void btnCopiarRGB_Click(object sender, EventArgs e)
        {
            string colorRGB = "rgb("
                + tbRed.Value.ToString() + "," 
                + tbGreen.Value.ToString() + "," 
                + tbBlue.Value.ToString() + 
                ")";
            Clipboard.SetText(colorRGB);
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            string colorHex = RgbToHex(tbRed.Value, tbGreen.Value, tbBlue.Value);
            Clipboard.SetText(colorHex);
        }

        public static string RgbToHex(int r, int g, int b)
        {
            return string.Format("#{0:X2}{1:X2}{2:X2}", r, g, b);
        }
    }
}
