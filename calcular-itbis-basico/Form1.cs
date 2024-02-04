namespace _20240127___P2___Calculo_ITBIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String articulo = txtArticulo.Text;
            int cantidad = int.Parse(nmCantidad.Text);
            decimal precio = decimal.Parse(nmPrecio.Text);
            

            decimal subtotal = Math.Round(cantidad * precio, 2);
            decimal itbis = Math.Round((subtotal * 18)/100, 2);
            decimal total = Math.Round(subtotal + itbis, 2);

            lblResultado.Text = "Articulo: " + articulo +
               Environment.NewLine + "Cantidad: " + cantidad +
               Environment.NewLine + "Precio: " + precio +
               Environment.NewLine + "SubTotal " + subtotal +
               Environment.NewLine + "ITBIS: " + itbis +
               Environment.NewLine + "Total: " + total;
        }
    }
}
