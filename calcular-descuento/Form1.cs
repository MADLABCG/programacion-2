using System.Globalization;

namespace Descuento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string formatoDinero(decimal dinero)
        {
            return string.Format(new CultureInfo("es-DO"), "{0:C2}", dinero);
        }


        private void calcular()
        {
            if(validar() == true)
            {
                lblArticulo.Text = txtArticulo.Text;
                lblPrecio.Text = formatoDinero(decimal.Parse(nPrecio.Text));
                lblPorcentaje.Text = nPorcentaje.Text + " %";
                lblDescuento.Text = formatoDinero(calcularDescuento());
                lblPrecioFinal.Text = formatoDinero(calcularPrecioFinal());
            }
        }

        private decimal calcularDescuento()
        {
            decimal precio = decimal.Parse(nPrecio.Text);
            decimal porcentaje = decimal.Parse(nPorcentaje.Text);
            decimal descuento = precio * (porcentaje / 100);
            return descuento;
        }

        private decimal calcularPrecioFinal()
        {
            return decimal.Parse(nPrecio.Text) - calcularDescuento();
        }

        private Boolean validar()
        {
            Boolean flag = true;

            if(flag == true)
            {
                if (txtArticulo.Text.Length <= 0)
                {
                    flag = false;
                    MessageBox.Show("Debe de Definir un articulo");
                }
            }

            if (flag == true)
            {
                if (decimal.Parse(nPrecio.Text) <= 0)
                {
                    flag = false;
                    MessageBox.Show("El Precio debe de ser mayor a cero");
                }
            }

            if (flag == true)
            {
                if (decimal.Parse(nPorcentaje.Text) <= 0)
                {
                    flag = false;
                    MessageBox.Show("El Porcentaje debe de ser mayor a cero");
                }
            }
            return flag;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcular();
        }
    }
}
