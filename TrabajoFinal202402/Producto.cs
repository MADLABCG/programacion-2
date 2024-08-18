using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal202402
{
    internal class Producto
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public Double Costo { get; set; }
        public Double Precio { get; set; }
        public int Cantidad { get; set; }

        public Producto()
        {
            //Vacio
        }

        public Producto(int id, string nombre, string modelo, string descripcion, Double costo, Double precio, int cantidad)
        {
            Id = id;
            Nombre = nombre;
            Modelo = modelo;
            Descripcion = descripcion;
            Costo = costo;
            Precio = precio;
            Cantidad = cantidad;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre} Modelo: {Modelo} Precio: {Precio} Cantidad: {Cantidad}";
        }
    }
}
