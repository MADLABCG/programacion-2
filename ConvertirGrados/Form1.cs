namespace ConvertirGrados
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
            rbFarenheit.Checked = true;
            rbCelsius.Checked = false;
            setBounders();
            nValor.Value = 0;
            setFromTo();
            lblGrados.Text = string.Empty;
        }

        private void setBounders()
        {
            if (rbCelsius.Checked)
            {
                nValor.Minimum = -460;
                nValor.Maximum = 1832;
            }
            else if (rbFarenheit.Checked)
            {
                nValor.Minimum = -274;
                nValor.Maximum = 1000;
            }
        }

        private void setFromTo()
        {
            if (rbCelsius.Checked)
            {
                lblGradosDesde.Text = "Farenheit";
                lblGradosHasta.Text = "Celsius";
            }
            else if (rbFarenheit.Checked)
            {
                lblGradosDesde.Text = "Celsius";
                lblGradosHasta.Text = "Farenheit";
            }

        }

        private void convertidor()
        {
            if(rbCelsius.Checked)
            {
                //(32°F − 32) × 5/9 = 0°C
                //celcius = (farenheit - 32) * 5/9 = resultado;
                decimal resultado = (nValor.Value - 32) * 5 / 9;
                lblGrados.Text = resultado.ToString("N2") + " °C";
            }
            else if (rbFarenheit.Checked)
            {
                //0°C × 9/5) + 32 = 32°F
                //farenheit = (celcius * 9/5) + 32
                decimal resultado = (nValor.Value * 9 / 5) + 32;
                lblGrados.Text = resultado.ToString("N2") + " °F";
            }
        }


        private void btnConvertir_Click(object sender, EventArgs e)
        {
            convertidor();
        }

        private void rbFarenheit_CheckedChanged(object sender, EventArgs e)
        {
            setFromTo();
        }

        private void rbCelsius_CheckedChanged(object sender, EventArgs e)
        {
            setFromTo();
        }
    }
}

//Bajo
//- 273.15 C
//- 459.67 F

//Alta
//1000 C
//1832 F
