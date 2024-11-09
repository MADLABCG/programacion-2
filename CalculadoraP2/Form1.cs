namespace CalculadoraP2
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
        string? temporal;
        string? operador;
        double? resultado;

        private void setPantalla(string texto)
        {
            if (pantalla == null)
            {
                pantalla = texto;
            }
            else
            {
                pantalla = pantalla + System.Environment.NewLine + texto;
            }

            txtResultado.Text = pantalla;
        }

        private void clearPantalla()
        {
            pantalla = null;
            txtResultado.Text = string.Empty;
        }

        private void clearVariables()
        {
            numero1 = null;
            numero2 = null;
            operador = null;
            temporal = null;
            pantalla = null;
        }

        private void resolver()
        {
            if (operador != null && numero1 != null && numero2 != null)
            {

                switch(operador) {
                    case "sumar":
                        resultado = numero1 + numero2;
                        setPantalla("= " + resultado.ToString());
                        clearVariables();
                        break;
                    case "restar":
                        resultado = numero1 - numero2;
                        setPantalla("= " +resultado.ToString());
                        clearVariables();
                        break;
                    default:
                        break;
                }
                
            }
        }

        private void ejecutar()
        {
            if (temporal != null)
            {
                if (numero1 == null)
                {
                    try
                    {
                        numero1 = Double.Parse(temporal);
                    }
                    catch
                    {
                        numero1 = 0;
                    }
                    setPantalla(numero1.ToString());
                    temporal = null;
                }
                else
                {
                    if (numero2 == null)
                    {
                        try
                        {
                            numero2 = Double.Parse(temporal);
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

        private string boton1()
        {
            return "1";
        }

        private string boton2()
        {
            return "2";
        }

        private string boton3()
        {
            return "3";
        }

        private string boton4()
        {
            return "4";
        }

        private string boton5()
        {
            return "5";
        }

        private string boton6()
        {
            return "6";
        }

        private string boton7()
        {
            return "7";
        }

        private string boton8()
        {
            return "8";
        }

        private string boton9()
        {
            return "9";
        }

        private string boton0()
        {
            return "0";
        }

        private string botonPunto()
        {
            return ".";
        }

        private string botonSumar()
        {
            return "sumar";
        }

        private string botonRestar()
        {
            return "restar";
        }

        private string botonMultiplicar()
        {
            return "multiplicar";
        }

        private string botonDividir()
        {
            return "dividir";
        }

        private string botonItbis()
        {
            return "itbis";
        }

        private string botonModulo()
        {
            return "modulo";
        }

        private string botonInverso()
        {
            return "inverso";
        }

        private string botonCuadrado()
        {
            return "cuadrado";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            temporal = temporal + boton1();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            temporal = temporal + boton2();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            temporal = temporal + boton3();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            temporal = temporal + boton4();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            temporal = temporal + boton5();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            temporal = temporal + boton6();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            temporal = temporal + boton7();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            temporal = temporal + boton8();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            temporal = temporal + boton9();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            temporal = temporal + boton0();
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            temporal = temporal + botonPunto();
        }

        private void btnC_Click(object sender, EventArgs e)
        {

        }

        private void btnCA_Click(object sender, EventArgs e)
        {
            clearPantalla();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            ejecutar();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            operador = botonSumar();
            setPantalla("+");
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            operador = botonRestar();
            setPantalla("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = botonMultiplicar();
            setPantalla("*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operador = botonDividir();
            setPantalla("/");
        }

        private void btnItbis_Click(object sender, EventArgs e)
        {
            operador = botonItbis();
            setPantalla(botonItbis());
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            operador = botonModulo();
            setPantalla(botonModulo());
        }

        private void btnInverso_Click(object sender, EventArgs e)
        {
            operador = botonInverso();
            setPantalla(botonInverso());
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            operador = botonCuadrado();
            setPantalla(botonCuadrado());
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            resolver();
        }
    }
}
