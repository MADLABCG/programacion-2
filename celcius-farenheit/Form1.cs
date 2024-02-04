namespace ConvertidorCelciusFarenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            iniciar();
        }

        private void iniciar()
        {
            lblGrados.Text = string.Empty;
            lblResultado.Text = string.Empty;
            txtTemperatura.Text = string.Empty;
            rbCelcius.Checked = true;
            rbFarenheit.Checked = false;
        }

        private decimal convertir_celcius(decimal farenheit)
        {
            //(32°F − 32) × 5/9 = 0°C
            //celcius = (farenheit - 32) * 5/9 = resultado;
            decimal resultado = (farenheit - 32) * 5 / 9;
            return resultado;
        }

        private decimal convertir_farenheit(decimal celcius)
        {
            //0°C × 9/5) + 32 = 32°F
            //farenheit = (celcius * 9/5) + 32
            decimal resultado = (celcius * 9 / 5) + 32;
            return resultado;
        }

        private string convertir_a_texto(decimal temperatura)
        {
            return String.Format("{0:0.##}", temperatura);
        }

        private string grados()
        {
            if (rbFarenheit.Checked)
            {
                return "F";
            }
            else
            {
                return "C";
            }
        }

        private void limpiar()
        {
            //Implementar borrado
        }

        private bool revision()
        {

            //Escribir logica de validacion
            //No puede quedarse en blanco donde dice temperatura actual y se debe de escribir obligatoriamente un numero
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(revision())
            {
                decimal temperatura_inicial = Convert.ToDecimal(txtTemperatura.Text);

                if (rbCelcius.Checked == true)
                {
                    lblGrados.Text = grados();
                    lblResultado.Text = convertir_a_texto(convertir_celcius(temperatura_inicial));
                }

                if (rbFarenheit.Checked == true)
                {
                    lblGrados.Text = grados();
                    lblResultado.Text = convertir_a_texto(convertir_farenheit(temperatura_inicial));
                }
            }
            
        }
    }
}