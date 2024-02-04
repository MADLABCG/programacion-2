using System.Globalization;

namespace Itbis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string articulo;
        private int cantidad;
        private decimal precio;
        private decimal subtotal;
        private decimal itbis;
        private decimal total;

        private void calcular()
        {
            articulo = txtArticulo.Text;
            cantidad = int.Parse(nCantidad.Text);
            precio = decimal.Parse(nPrecio.Text);
            subtotal = Math.Round(cantidad * precio, 2);
            itbis = Math.Round((subtotal * 18) / 100, 2);
            total = Math.Round(subtotal + itbis, 2);
        }

        private void mostrar()
        {
            lblArticulo.Text = articulo;
            lblCantidad.Text = cantidad.ToString();
            lblPrecio.Text = formatoDinero(precio);
            lblSubTotal.Text = formatoDinero(subtotal);
            lblItbis.Text = formatoDinero(itbis);
            lblTotal.Text = formatoDinero(total);
            
        }

        private string formatoDinero(decimal dinero)
        {
            return  string.Format(new CultureInfo("es-DO"), "{0:C2}", dinero);
        }

        private void btnCacular_Click(object sender, EventArgs e)
        {
            calcular();
            mostrar();
        }
    }
}
