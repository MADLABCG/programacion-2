namespace Loteria1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSorteoP1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(nDesdeP1.Value.ToString());
            int numero2 = int.Parse(nHastaP1.Value.ToString());

            if(numero2 - numero1 < 99) {                 
                MessageBox.Show("El rango debe ser de al menos 100 números");
            } else {
                int resultado = new Random().Next(numero1, numero2);
                lblPremio1.Text = resultado.ToString();
            }
        }

        private void btnSorteoP2_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(nDesdeP2.Value.ToString());
            int numero2 = int.Parse(nHastaP2.Value.ToString());

            if (numero2 - numero1 < 99)
            {
                MessageBox.Show("El rango debe ser de al menos 100 números");
            }
            else
            {
                int resultado = new Random().Next(numero1, numero2);
                lblPremio2.Text = resultado.ToString();
            }
        }

        private void btnSorteoP3_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(nDesdeP3.Value.ToString());
            int numero2 = int.Parse(nHastaP3.Value.ToString());

            if (numero2 - numero1 < 99)
            {
                MessageBox.Show("El rango debe ser de al menos 100 números");
            }
            else
            {
                int resultado = new Random().Next(numero1, numero2);
                lblPremio3.Text = resultado.ToString();
            }
        }
    }
}
