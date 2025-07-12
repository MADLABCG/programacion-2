namespace ContadorCaracteres2025_02
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
            lblTildes.Text = "0";
            lblSignos.Text = "0";
            lblEspacios.Text = "0";
            lblLetras.Text = "0";
            lblNumeros.Text = "0";
            lblTotal.Text = "0";
            lblPalabras.Text = "0";
        }

        private void limpiar()
        {
            inicializar();
            txtTexto.Text = string.Empty;
        }

        private void contar()
        { 
            string parrafos = txtTexto.Text;
            int tildes = contarTildes(parrafos);
            int signos = contarSignosPuntuacion(parrafos);
            int espacios = parrafos.Count(char.IsWhiteSpace);
            int numeros = parrafos.Count(char.IsDigit);
            int palabras = contarPalabras(parrafos);
            int letras = (parrafos.Length - tildes - espacios - numeros);
            int total = parrafos.Length;

            lblTildes.Text = tildes.ToString();
            lblSignos.Text = signos.ToString();
            lblEspacios.Text = espacios.ToString();
            lblNumeros.Text = numeros.ToString();
            lblLetras.Text = letras.ToString();
            lblPalabras.Text = palabras.ToString();
            lblTotal.Text = total.ToString();
        }

        private int contarTildes(string texto)
        {
            int contador = 0;
            foreach (char c in texto)
            {
                if (
                    c == 'á' || 
                    c == 'é' || 
                    c == 'í' || 
                    c == 'ó' || 
                    c == 'ú' ||
                    c == 'Á' || 
                    c == 'É' || 
                    c == 'Í' || 
                    c == 'Ó' || 
                    c == 'Ú')
                {
                    contador++;
                }
            }
            return contador;
        }

        private int contarSignosPuntuacion(string texto)
        {
            int contador = 0;
            foreach (char c in texto)
            {
                if (
                    c == '.' ||
                    c == ',' ||
                    c == ';' ||
                    c == ':' ||
                    c == '!' ||
                    c == '?' ||
                    c == '¿' ||
                    c == '(' ||
                    c == ')' ||
                    c == '[' ||
                    c == ']' ||
                    c == '{' ||
                    c == '}' ||
                    c == '"' ||
                    c == '\'')
                {
                    contador++;
                }
            }
            return contador;
        }

        private int contarPalabras(string texto)
        {
            int palabras = 0;
            palabras = texto.Split(' ').Length;
            return palabras;
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            contar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
