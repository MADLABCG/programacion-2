namespace ContadorCaracteres2
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
            txtTexto.Text = string.Empty;
            txtTexto.Focus();
            lblLetras.Text = "0";
            lblEspacios.Text = "0";
            lblMayusculas.Text = "0";
            lblMinusculas.Text = "0";
            lblAcentos.Text = "0";
            lblPuntuacion.Text = "0";
            lblCaracteres.Text = "0";
            lblEspeciales.Text = "0";
            lblNumeros.Text = "0";
            lblPalabras.Text = "0";
            lblTildeA.Text = "0";
            lblTildeE.Text = "0";
            lblTildeI.Text = "0";
            lblTildeO.Text = "0";
            lblTildeU.Text = "0";
        }


        private void btnContar_Click(object sender, EventArgs e)
        {
            int caracteres = 0;
            int letras = 0;
            int espacios = 0;
            int mayusculas = 0;
            int minusculas = 0;
            int acentos = 0;
            int puntuacion = 0;
            int especiales = 0;
            int numeros = 0;
            int palabras = 0;
            int tildeA = 0;
            int tildeE = 0;
            int tildeI = 0;
            int tildeO = 0;
            int tildeU = 0;

            string texto = txtTexto.Text;

            caracteres = texto.Length;
            espacios = texto.Count(Char.IsWhiteSpace);
            mayusculas = texto.Count(Char.IsUpper);
            minusculas = texto.Count(Char.IsLower);
            acentos = contarAcentos(texto);
            puntuacion = contarPuntuacion(texto);
            especiales = contarEspaciales(texto);
            numeros = texto.Count(Char.IsDigit);
            letras = (texto.Length - espacios - puntuacion - numeros);
            palabras = contarPalabras(texto);
            tildeA = contarTildeA(texto);
            tildeE = contarTildeE(texto);
            tildeI = contarTildeI(texto);
            tildeO = contarTildeO(texto);
            tildeU = contarTildeU(texto);

            lblCaracteres.Text = caracteres.ToString();
            lblLetras.Text = letras.ToString();
            lblEspacios.Text = espacios.ToString();
            lblMayusculas.Text = mayusculas.ToString();
            lblMinusculas.Text = minusculas.ToString();
            lblAcentos.Text = acentos.ToString();
            lblPuntuacion.Text = puntuacion.ToString();
            lblEspeciales.Text = especiales.ToString();
            lblNumeros.Text = numeros.ToString();
            lblPalabras.Text = palabras.ToString();
            lblTildeA.Text = tildeA.ToString();
            lblTildeE.Text = tildeE.ToString();
            lblTildeI.Text = tildeI.ToString();
            lblTildeO.Text = tildeO.ToString();
            lblTildeU.Text = tildeU.ToString();
        }

        private int contarAcentos(string texto)
        {
            int acentos = 0;
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
                    c == 'Ú'
                    )
                {
                    acentos++;
                }
            }
            return acentos;
        }

        private int contarTildeA(string texto)
        {
            int acentos = 0;
            foreach (char c in texto)
            {
                if (
                    c == 'á' ||
                    c == 'Á' 
                    )
                {
                    acentos++;
                }
            }
            return acentos;
        }

        private int contarTildeE(string texto)
        {
            int acentos = 0;
            foreach (char c in texto)
            {
                if (
                    c == 'é' ||
                    c == 'É'
                    )
                {
                    acentos++;
                }
            }
            return acentos;
        }

        private int contarTildeI(string texto)
        {
            int acentos = 0;
            foreach (char c in texto)
            {
                if (
                    c == 'í' ||
                    c == 'Í'
                    )
                {
                    acentos++;
                }
            }
            return acentos;
        }

        private int contarTildeO(string texto)
        {
            int acentos = 0;
            foreach (char c in texto)
            {
                if (
                    c == 'ó' ||
                    c == 'Ó'
                    )
                {
                    acentos++;
                }
            }
            return acentos;
        }

        private int contarTildeU(string texto)
        {
            int acentos = 0;
            foreach (char c in texto)
            {
                if (
                    c == 'ú' ||
                    c == 'Ú'
                    )
                {
                    acentos++;
                }
            }
            return acentos;
        }

        private int contarPalabras(string texto)
        {
            int palabras = 0;
            palabras = texto.Split(' ').Length;
            return palabras;
        }

        private int contarEspaciales(string texto)
        {
            int acentos = 0;
            foreach (char c in texto)
            {
                if (
                    c == 'ñ' ||
                    c == 'Ñ'
                    )
                {
                    acentos++;
                }
            }
            return acentos;
        }

        private int contarPuntuacion(string texto)
        {
            int puntuacion = 0;
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
                    c == '\''
                    )
                {
                    puntuacion++;
                }
            }
            return puntuacion;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            inicializar();
        }
    }
}
