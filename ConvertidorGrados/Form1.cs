namespace ConvertidorGrados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbCelcius.Checked = true;
        }
        const int CONSTANTE_GRADOS = 32;

        private void convertirCelcius()
        {
            //(32°F − 32) × 5/9 = 0°C
            const Double CONSTANTE_CELCIUS = 0.555555555555556; // 5/9
            int farenheit = int.Parse(nGrados.Text);
            Double resultado;

            resultado = Math.Round((farenheit - CONSTANTE_GRADOS) * CONSTANTE_CELCIUS, 0);

            lblResultado.Text = resultado.ToString();
            lblUnidad.Text = "C";
        }

        private void convertirFarenheit()
        {
            //(0°C × 9/5) + 32 = 32°F
            const Double CONSTANTE_FARENHEIT = 1.8; // 9/5
            int celcius = int.Parse(nGrados.Text);
            Double resultado;

            resultado = Math.Round((celcius * CONSTANTE_FARENHEIT) + CONSTANTE_GRADOS, 0);
            lblResultado.Text = resultado.ToString();
            lblUnidad.Text = "F";
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (rbCelcius.Checked)
            {
                convertirCelcius();
            }

            if (rbFarenheit.Checked)
            {
                convertirFarenheit();
            }
        }
    }
}
