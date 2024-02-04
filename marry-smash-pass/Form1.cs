namespace MarrySmashPass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            limpiar();
        }

        private void limpiar()
        {
            label1.Text = string.Empty;
            label2.Text = string.Empty;
            label3.Text = string.Empty;
            nombre1.Text = string.Empty;
            nombre2.Text = string.Empty;
            nombre3.Text = string.Empty;
        }

        private void jugar()
        {
            Random random = new Random();
            string[] resultados = { "Smash", "Pass", "Marry" };
            int resultado;

            if(validar() == true)
            {
                resultado = random.Next(0, resultados.Length);
                label1.Text = resultados[resultado];
                resultados = resultados.Where(val => val != resultados[resultado]).ToArray();

                resultado = random.Next(0, resultados.Length);
                label2.Text = resultados[resultado];
                resultados = resultados.Where(val => val != resultados[resultado]).ToArray();

                resultado = random.Next(0, resultados.Length);
                label3.Text = resultados[resultado];
                resultados = resultados.Where(val => val != resultados[resultado]).ToArray();
            };
        }

        private bool validar()
        {
            //Aporte Ysabel Belen Suazo
            bool validado = true;

            if(nombre1.Text.Length == 0)
            {
                MessageBox.Show("Nombre 1 no puede estar en blanco");
                validado = false;
            }
            if (nombre2.Text.Length == 0)
            {
                MessageBox.Show("Nombre 2 no puede estar en blanco");
                validado = false;
            }
            if (nombre3.Text.Length == 0)
            {
                MessageBox.Show("Nombre 3 no puede estar en blanco");
                validado = false;
            }
            return validado;
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            jugar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}