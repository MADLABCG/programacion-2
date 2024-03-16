using System;

public class Articulo
{
    public Articulo()
    {
    }

    int id;
    string nombre;
    Double precio;

    public int idArticulo
    {
        get { return id; }
        set { id = value; }
    }
    public string nombreArticulo
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public Double precioArticulo
    {
        get { return precio; }
        set { precio = value; }
    }
}
