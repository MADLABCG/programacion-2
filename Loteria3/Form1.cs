namespace Loteria3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSorteo_Click(object sender, EventArgs e)
        {
           //Thread th = new Thread(setNumero);
            //th.Start();
            setNumero();
        }


 

        private void setNumero()
        {
            lblResultado.Text = "";
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int numero = r.Next(1, 100);
                Thread.Sleep(100);
                lblResultado.Text = numero.ToString();
            }
            
        }
    }
}
