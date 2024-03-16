using System.Globalization;

namespace Ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inicializarLista();
        }

        int idArticulo = 0;
        int cantidadArticulos = 0;
        Double totalVentas = 0;

        private void inicializarLista()
        {
            lstArticulos.View = View.Details;
            lstArticulos.Columns.Add("Id", 40);
            lstArticulos.Columns.Add("Nombre", 170);
            lstArticulos.Columns.Add("Precio", 100);
        }

        private string formatoDinero(Double dinero)
        {
            return string.Format(new CultureInfo("es-DO"), "{0:C2}", dinero);
        }


        private void registroArticulo()
        {
            //Creamos Objeto Articulo
            Articulo articulo = new Articulo();
            articulo.idArticulo = idArticulo + 1;
            articulo.nombreArticulo = txtNombreArticulo.Text;
            articulo.precioArticulo = Convert.ToDouble(nPrecioArticulo.Text);

            //Creamos un objeto ListViewItem
            ListViewItem articulo_lista = new ListViewItem();
            articulo_lista.Text = articulo.idArticulo.ToString();
            articulo_lista.SubItems.Add(articulo.nombreArticulo);
            articulo_lista.SubItems.Add(formatoDinero(articulo.precioArticulo));
            lstArticulos.Items.Add(articulo_lista);
            
            idArticulo = articulo.idArticulo;

            estadisticas(articulo);
        }

        private void estadisticas(Articulo art)
        {
            cantidadArticulos = cantidadArticulos + 1;
            totalVentas = totalVentas + art.precioArticulo;

            lblArticulosVendido.Text = cantidadArticulos.ToString();
            lblTotalVentas.Text = formatoDinero(totalVentas);
        }

        private void btnRegistrarVentas_Click(object sender, EventArgs e)
        {
            registroArticulo();
        }
    }
}
