namespace Caculadora2025_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string? pantalla;
        double? numero1;
        double? numero2;
        double? resultado;
        string? operador;
        string? temporal;

        private void clear()
        {
            pantalla = null;
            numero1 = null;
            numero2 = null;
            resultado = null;
            operador = null;
            temporal = null;
            txtPantalla.Text = string.Empty;
        }


        private void setPantalla(string valor)
        {
            if (pantalla == null)
            {
                pantalla = valor;
            }
            else { 
                pantalla = pantalla + System.Environment.NewLine + valor;
            }
            txtPantalla.Text = pantalla;
        }

        private void setNumeros()
        {
            if (temporal != null) {

                if (numero1 == null)
                {
                    try
                    {
                        numero1 = Convert.ToDouble(temporal);
                    }
                    catch
                    {
                        numero1 = 0;
                    }
                    setPantalla(numero1.ToString());
                    temporal = null;
                }
                else {
                    if (numero2 == null) {
                        try
                        {
                            numero2 = Convert.ToDouble(temporal);
                        }
                        catch
                        {
                            numero2 = 0;
                        }
                        setPantalla(numero2.ToString());
                        temporal = null;
                    }
                }
            
            }
        }


        private void resolver()
        { 
            if(numero1 != null && numero2 != null && operador != null)
            {
                switch (operador)
                {
                    case "sumar":
                        resultado = numero1 + numero2;
                        break;
                    case "restar":
                        resultado = numero1 - numero2;
                        break;
                    case "multiplicar":
                        resultado = numero1 * numero2;
                        break;
                    case "dividir":
                        if (numero2 == 0)
                        {
                            MessageBox.Show("No se puede dividir por cero.");
                            return;
                        }
                        resultado = numero1 / numero2;
                        break;
                }
                setPantalla("= " + resultado.ToString());
            }
        }


        private void btnSumar_Click(object sender, EventArgs e)
        {
            operador = "sumar";
            setPantalla("+");
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            operador = "restar";
            setPantalla("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = "multiplicar";
            setPantalla("*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operador = "dividir";
            setPantalla("/");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            temporal = temporal + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            temporal = temporal + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            temporal = temporal + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            temporal = temporal + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            temporal = temporal + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            temporal = temporal + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            temporal = temporal + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            temporal = temporal + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            temporal = temporal + "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            temporal = temporal + ".";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            temporal = temporal + "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            setNumeros();
            resolver();
        }
    }
}
