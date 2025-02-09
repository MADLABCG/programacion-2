using System.Globalization;

namespace CalculadoraP2_Simple
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            tbResultado.Text = string.Empty;
            rbSumar.Checked = true;
            lblNumero1.Text = "Sumando 1";
            lblNumero2.Text = "Sumando 2";
            lblExplicacion.Text = "Se sumara el numero 1 y el numero 2";
            tbResultado.Enabled = false;
            lblVersion.Text = "V 1.0.01b";
        }

        private void limpiar()
        {
            rbSumar.Checked = true;
            nNumero1.Value = 0;
            nNumero2.Value = 0;
            tbResultado.Text = string.Empty;
            radioButtons();

        }

        private string formatoNumero(Decimal numero)
        {
            return string.Format("{0:N2}", numero);
        }

        private void ejecutar()
        {
            decimal resultado = 0;
            if (rbSumar.Checked)
            {
                resultado = nNumero1.Value + nNumero2.Value;
                tbResultado.Text = formatoNumero(resultado);
            }
            if (rbRestar.Checked)
            {
                resultado = nNumero1.Value - nNumero2.Value;
                tbResultado.Text = formatoNumero(resultado);
            }
            if (rbMultiplicar.Checked)
            {
                resultado = nNumero1.Value * nNumero2.Value;
                tbResultado.Text = formatoNumero(resultado);
            }
            if (rbDividir.Checked)
            {
                if(nNumero2.Value <= 0)
                {
                    MessageBox.Show("Es imposible la division entre 0, tiende al infinito");
                } else
                {
                    resultado = nNumero1.Value / nNumero2.Value;
                    tbResultado.Text = formatoNumero(resultado);
                }
                
            }
            if (rbCuadrado.Checked)
            {
                resultado = (decimal) Math.Pow((double) nNumero1.Value, 2);
                tbResultado.Text = formatoNumero(resultado);
            }

            if (rbCubo.Checked)
            {
                resultado = (decimal)Math.Pow((double)nNumero1.Value, 3);
                tbResultado.Text = formatoNumero(resultado);
            }
            if (rbItbis.Checked)
            {
                resultado = nNumero1.Value * (decimal) 0.18;
                tbResultado.Text = formatoNumero(resultado);
            }
        }

        private void radioButtons()
        {
            if (rbSumar.Checked)
            {
                nNumero1.Enabled = true;
                nNumero2.Enabled = true;
                nNumero1.Visible = true;
                nNumero2.Visible = true;
                lblNumero1.Visible = true;
                lblNumero2.Visible = true;
                lblNumero1.Text = "Sumando 1";
                lblNumero2.Text = "Sumando 2";
                lblExplicacion.Text = "Se sumara el sumando 1 y el sumando 2";
            }
            if (rbRestar.Checked)
            {
                nNumero1.Enabled = true;
                nNumero2.Enabled = true;
                nNumero1.Visible = true;
                nNumero2.Visible = true;
                lblNumero1.Visible = true;
                lblNumero2.Visible = true;
                lblNumero1.Text = "Minuendo";
                lblNumero2.Text = "Sustraendo";
                lblExplicacion.Text = "Al minuendo se le restara el sustraendo";
            }
            if (rbMultiplicar.Checked)
            {
                nNumero1.Enabled = true;
                nNumero2.Enabled = true;
                nNumero1.Visible = true;
                nNumero2.Visible = true;
                lblNumero1.Visible = true;
                lblNumero2.Visible = true;
                lblNumero1.Text = "Multiplicando";
                lblNumero2.Text = "Multiplicador";
                lblExplicacion.Text = "Se multiplicara el multiplicando por el multiplicador";
            }
            if (rbDividir.Checked)
            {
                nNumero1.Enabled = true;
                nNumero2.Enabled = true;
                nNumero1.Visible = true;
                nNumero2.Visible = true;
                lblNumero1.Visible = true;
                lblNumero2.Visible = true;
                lblNumero1.Text = "Dividendo";
                lblNumero2.Text = "Divisor";
                lblExplicacion.Text = "Se dividira el dividendo entre el divisor";
            }
            if (rbCuadrado.Checked)
            {
                nNumero1.Enabled = true;
                nNumero2.Enabled = false;
                nNumero1.Visible = true;
                nNumero2.Visible = false;
                lblNumero1.Visible = true;
                lblNumero2.Visible = false;
                lblNumero1.Text = "Numero 1";
                lblNumero2.Text = " ";
                lblExplicacion.Text = "Se elevara al cuadrado el numero 1";
            }

            if (rbCubo.Checked)
            {
                nNumero1.Enabled = true;
                nNumero2.Enabled = false;
                nNumero1.Visible = true;
                nNumero2.Visible = false;
                lblNumero1.Visible = true;
                lblNumero2.Visible = false;
                lblNumero1.Text = "Numero 1";
                lblNumero2.Text = " ";
                lblExplicacion.Text = "Se elevara al cubo el numero 1";
            }
            if (rbItbis.Checked)
            {
                nNumero1.Enabled = true;
                nNumero2.Enabled = false;
                nNumero1.Visible = true;
                nNumero2.Visible = false;
                lblNumero1.Visible = true;
                lblNumero2.Visible = false;
                lblNumero1.Text = "Precio";
                lblNumero2.Text = " ";
                lblExplicacion.Text = "Se calculara el itbis al precio dado";
            }
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            ejecutar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void rbSumar_CheckedChanged(object sender, EventArgs e)
        {
            radioButtons();
        }

        private void rbRestar_CheckedChanged(object sender, EventArgs e)
        {
            radioButtons();
        }

        private void rbMultiplicar_CheckedChanged(object sender, EventArgs e)
        {
            radioButtons();
        }

        private void rbDividir_CheckedChanged(object sender, EventArgs e)
        {
            radioButtons();
        }

        private void rbCuadrado_CheckedChanged(object sender, EventArgs e)
        {
            radioButtons();
        }

        private void rbCubo_CheckedChanged(object sender, EventArgs e)
        {
            radioButtons();
        }

        private void rbItbis_CheckedChanged(object sender, EventArgs e)
        {
            radioButtons();
        }
    }
}
