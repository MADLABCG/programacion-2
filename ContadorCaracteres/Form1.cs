namespace ContadorCaracteres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int simbolo1;
        int simbolo2;
        int simbolo3;
        int simbolo4;
        int simbolo5;
        int simbolo6;
        int simbolo7;
        int simbolo8;
        int simbolo9;
        int tilde1;
        int tilde2;
        int tilde3;
        int tilde4;
        int tilde5;

        private void contar()
        {
            lblTotal.Text = contarTotal().ToString();
            lblLetras.Text = contarLetras().ToString();
            lblEspacios.Text = contarEspacios().ToString();
            lblPalabras.Text = contarPalabras().ToString();
            lblSimbolos.Text = contarSimbolos().ToString();
            lblTildes.Text = contarTildes().ToString();
            lblNumeros.Text = contarNumeros().ToString();
            contarSimbolosIndividuales();
            contarTildesIndividuales();
        }

        private int contarSimbolos()
        {
            string texto = txtParrafo.Text;
            int conteo = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (
                    texto[i] == '!' || 
                    texto[i] == ';' || 
                    texto[i] == ',' ||
                    texto[i] == ':' || 
                    texto[i] == '?' || 
                    texto[i] == '.' ||
                    texto[i] == '¡' ||
                    texto[i] == '¿' ||
                    texto[i] == '"'
                    )
                {
                    conteo++;
                }
            }
            return conteo;
        }

        private int contarTildes()
        {
            string texto = txtParrafo.Text;
            int conteo = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (
                    texto[i] == 'á' ||
                    texto[i] == 'é' ||
                    texto[i] == 'í' ||
                    texto[i] == 'ó' ||
                    texto[i] == 'ú'
                    )
                {
                    conteo++;
                }
            }
            return conteo;
        }

        private int contarLetras()
        {
            int total = txtParrafo.Text.Length;
            int espacios = txtParrafo.Text.Count(Char.IsWhiteSpace);
            int simbolos = contarSimbolos();
            int numeros = contarNumeros();
            int letras = total - (espacios + simbolos + numeros);
            return letras;
        }

        private int contarEspacios()
        {
            return txtParrafo.Text.Count(Char.IsWhiteSpace);
        }

        private int contarPalabras()
        {
            return txtParrafo.Text.Split().Length;
        }

        private int contarNumeros()
        {
            string texto = txtParrafo.Text;
            int conteo = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (
                    texto[i] == '1' ||
                    texto[i] == '2' ||
                    texto[i] == '3' ||
                    texto[i] == '4' ||
                    texto[i] == '5' ||
                    texto[i] == '6' ||
                    texto[i] == '7' ||
                    texto[i] == '8' ||
                    texto[i] == '9' ||
                    texto[i] == '0'
                    )
                {
                    conteo++;
                }
            }
            return conteo;
        }

        private int contarTotal()
        {
            return txtParrafo.Text.Length;
        }

        private void contarSimbolosIndividuales()
        {
            string texto = txtParrafo.Text;
            simbolo1 = 0;
            simbolo2 = 0;
            simbolo3 = 0;
            simbolo4 = 0;
            simbolo5 = 0;
            simbolo6 = 0;
            simbolo7 = 0;
            simbolo8 = 0;
            simbolo9 = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == '!') {
                    simbolo1 = simbolo1 + 1;
                }
                if (texto[i] == '¡')
                {
                    simbolo2 = simbolo2 + 1;
                }
                if (texto[i] == '?')
                {
                    simbolo3 = simbolo3 + 1;
                }
                if (texto[i] == '¿')
                {
                    simbolo4 = simbolo4 + 1;
                }
                if (texto[i] == ',')
                {
                    simbolo5 = simbolo5 + 1;
                }
                if (texto[i] == '.')
                {
                    simbolo6 = simbolo6 + 1;
                }
                if (texto[i] == ';')
                {
                    simbolo7 = simbolo7 + 1;
                }
                if (texto[i] == ':')
                {
                    simbolo8 = simbolo8 + 1;
                }
                if (texto[i] == '"')
                {
                    simbolo9 = simbolo9 + 1;
                }
            }
            lblSimbolo1.Text = simbolo1.ToString();
            lblSimbolo2.Text = simbolo2.ToString();
            lblSimbolo3.Text = simbolo3.ToString();
            lblSimbolo4.Text = simbolo4.ToString();
            lblSimbolo5.Text = simbolo5.ToString();
            lblSimbolo6.Text = simbolo6.ToString();
            lblSimbolo7.Text = simbolo7.ToString();
            lblSimbolo8.Text = simbolo8.ToString();
            lblSimbolo9.Text = simbolo9.ToString();
        }

        private void contarTildesIndividuales()
        {
            string texto = txtParrafo.Text;
            tilde1 = 0;
            tilde2 = 0;
            tilde3 = 0;
            tilde4 = 0;
            tilde5 = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == 'á') {
                    tilde1 = tilde1 + 1;
                }
                if (texto[i] == 'é')
                {
                    tilde2 = tilde2 + 1;
                }
                if (texto[i] == 'í')
                {
                    tilde3 = tilde3 + 1;
                }
                if (texto[i] == 'ó')
                {
                    tilde4 = tilde4 + 1;
                }
                if (texto[i] == 'ú')
                {
                    tilde5 = tilde5 + 1;
                }
            }

            lblTilde1.Text = tilde1.ToString();
            lblTilde2.Text = tilde2.ToString();
            lblTilde3.Text = tilde3.ToString();
            lblTilde4.Text = tilde4.ToString();
            lblTilde5.Text = tilde5.ToString();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            contar();
        }
    }
}
