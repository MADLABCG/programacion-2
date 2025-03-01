namespace Estadisticas
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
            lblMediana.Text = string.Empty;
            lblMedia.Text = string.Empty;
            lblModa.Text = string.Empty;
            lblDesviacion.Text = string.Empty;
            lblVarianza.Text = string.Empty;
            txtNumeros.Text = string.Empty;
        }

        private void calcular()
        {
            double[] numeros = ObtenerNumeros();

            double mediana = CalcularMediana(numeros);
            double media = CalcularMedia(numeros);
            double moda = CalcularModa(numeros);
            double desviacion = CalcularDesviacion(numeros);
            double varianza = CalcularVarianza(numeros);

            lblMediana.Text = Math.Round(mediana, 2).ToString();
            lblMedia.Text = Math.Round(media, 2).ToString();
            lblModa.Text = Math.Round(moda, 2).ToString();
            lblDesviacion.Text = Math.Round(desviacion, 2).ToString();
            lblVarianza.Text = Math.Round(varianza, 2).ToString();
        }

        private double CalcularMediana(double[] numeros)
        {
            var ordenados = numeros.OrderBy(n => n).ToArray();
            int mitad = ordenados.Length / 2;
            if (ordenados.Length % 2 == 0)
            {
                return (ordenados[mitad - 1] + ordenados[mitad]) / 2;
            }
            return ordenados[mitad];
        }

        private double CalcularModa(double[] numeros)
        {
            var agrupados = numeros.GroupBy(n => n).OrderByDescending(g => g.Count());
            return agrupados.First().Key;
        }

        private double CalcularMedia(double[] numeros)
        {
            return numeros.Average();
        }

        private double CalcularVarianza(double[] numeros)
        {
            return numeros.Select(x => Math.Pow(x - CalcularMedia(numeros), 2)).Average();
        }

        private double CalcularDesviacion(double[] numeros)
        {
            return Math.Sqrt(CalcularVarianza(numeros));
        }

        private double[] ObtenerNumeros()
        {
            char[] delimitadores = { ',', '.', ':', '\t', '\n' };
            return txtNumeros.Text.Split(delimitadores).Select(n => double.Parse(n)).ToArray();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcular();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            inicializar();
        }
    }
}
