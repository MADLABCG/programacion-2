namespace CalculadoraSimple012025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inicializar();
        }

        double resultado = 0;

        private void inicializar()
        {
            nNumero1.Value = 0;
            nNumero2.Value = 0;
            lblResultado.Text = string.Empty;
            rbSumar.Checked = true;
            resultado = 0;
        }

        private void sumar(double n1, double n2)
        {
            resultado = n1 + n2;
            lblResultado.Text = Math.Round(resultado, 2).ToString();
        }

        private void restar(double n1, double n2)
        {
            resultado = n1 - n2;
            lblResultado.Text = Math.Round(resultado, 2).ToString();
        }

        private void multiplicar(double n1, double n2)
        {
            resultado = n1 * n2;
            lblResultado.Text = Math.Round(resultado, 2).ToString();
        }

        private void dividir(double n1, double n2)
        {
            if (n2 == 0)
            {
                lblResultado.Text = "Error ...";
            }
            else
            {
                resultado = n1 / n2;
                lblResultado.Text = Math.Round(resultado, 2).ToString();
            }
        }

        private void modulo(double n1, double n2)
        {
            if (n2 == 0)
            {
                lblResultado.Text = "Error ...";
            }
            else
            {
                resultado = n1 % n2;
                lblResultado.Text = Math.Round(resultado, 2).ToString();
            }
        }

        private void ejecutar()
        {
            if(rbSumar.Checked == true)
            {
                sumar((double)nNumero1.Value, (double)nNumero2.Value);
            }
            else if (rbRestar.Checked == true)
            {
                restar((double)nNumero1.Value, (double)nNumero2.Value);
            }
            else if (rbMultiplicar.Checked == true)
            {
                multiplicar((double)nNumero1.Value, (double)nNumero2.Value);
            }
            else if (rbDividir.Checked == true)
            {
                dividir((double)nNumero1.Value, (double)nNumero2.Value);
            }
            else if (rbModulo.Checked == true)
            {
                modulo((double)nNumero1.Value, (double)nNumero2.Value);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            inicializar();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            ejecutar();
        }
    }
}
