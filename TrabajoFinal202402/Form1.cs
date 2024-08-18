using System.Globalization;

namespace TrabajoFinal202402
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inicializarLista();
        }

        int idProducto = 0;
        int cantidadProductos = 0;
        int totalInventario = 0;
        Double costoTotalInventario = 0;
        Double proyeccionVentaTotalInventario = 0;
        Double gananciaProyectada = 0;

        private string formatoDinero(Double dinero)
        {
            return string.Format(new CultureInfo("es-DO"), "{0:C2}", dinero);
        }

        private void inicializarLista()
        {
            tablaDatos.View = View.Details;
            tablaDatos.Columns.Add("Id", 40);
            tablaDatos.Columns.Add("Nombre", 210);
            tablaDatos.Columns.Add("Cantidad", 100);
            tablaDatos.Columns.Add("Precio", 100);
        }

        private void limpiarCampos()
        {   
            txtNombre.Text = "";
            txtModelo.Text = "";
            txtDescripcion.Text = "";
            nCosto.Text = "1";
            nPrecio.Text = "1";
            nCantidad.Text = "0";
        }

        private Boolean validarCampos()
        {
            if (txtNombre.Text == "" || txtModelo.Text == "" || txtDescripcion.Text == "" || nCosto.Value == 0 || nPrecio.Value == 0 || nCantidad.Value == 0)
            {
                MessageBox.Show("Todos los Campos son Obligatorios");
                return false;
            }
            return true;
        }

        private void crearProducto()
        {
            if(validarCampos())
            {
                try
                {
                    string nombre = txtNombre.Text;
                    string modelo = txtModelo.Text;
                    string descripcion = txtDescripcion.Text;
                    Double costo = Convert.ToDouble(nCosto.Text);
                    Double precio = Convert.ToDouble(nPrecio.Text);
                    int cantidad = (int)nCantidad.Value;

                    Producto producto = new Producto();
                    producto.Id = idProducto + 1;
                    producto.Nombre = nombre;
                    producto.Modelo = modelo;
                    producto.Descripcion = descripcion;
                    producto.Costo = costo;
                    producto.Precio = precio;
                    producto.Cantidad = cantidad;

                    idProducto = producto.Id;

                    ListViewItem productos = new ListViewItem();
                    productos.Text = producto.Id.ToString();
                    productos.SubItems.Add(producto.Nombre);
                    productos.SubItems.Add(producto.Cantidad.ToString());
                    productos.SubItems.Add(formatoDinero(producto.Precio));
                    tablaDatos.Items.Add(productos);

                    estadisticas(producto);

                    limpiarCampos();
                
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha Ocurrido un Error Creando el Producto");
                }
            }
            
        }

        private void estadisticas(Producto producto) {

            if (producto == null)
            {
                MessageBox.Show("Producto no es valido");
            } else
            {
                cantidadProductos = cantidadProductos + 1;
                totalInventario = totalInventario + producto.Cantidad;
                costoTotalInventario = costoTotalInventario + (producto.Costo * producto.Cantidad);
                proyeccionVentaTotalInventario = proyeccionVentaTotalInventario + (producto.Precio * producto.Cantidad);
                gananciaProyectada = proyeccionVentaTotalInventario - costoTotalInventario;

                lblCantidadProductos.Text = cantidadProductos.ToString();
                lblTotalProductosInventario.Text = totalInventario.ToString();
                lblCostoTotalInventario.Text = formatoDinero(costoTotalInventario);
                lblProyeccionVentaTotal.Text = formatoDinero(proyeccionVentaTotalInventario);
                lblGananciaProyectada.Text = formatoDinero(gananciaProyectada);
            }

        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            crearProducto();
        }
    }
}
