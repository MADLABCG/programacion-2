using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TrabajoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool asignado_numero1 = false;
        bool asignado_numero2 = false;
        bool asignado_operador = false;
        bool asignado_resultado = false;

        string temporal = string.Empty;
        decimal numero1;
        decimal numero2;
        string operador;

        private void borrar()
        {
            txtPantalla.Text = string.Empty;
            asignado_numero1 = false;
            asignado_numero2 = false;
            asignado_operador = false;
            asignado_resultado = false;
            temporal = string.Empty;
        }

        private void crearNumero(string numero)
        {
            temporal = temporal + numero;
            txtPantalla.Text = temporal;   
        }

        private void asignarOperador(string operador)
        {
            if (asignado_numero1)
            {
                if (!asignado_operador)
                {
                    this.operador = operador;
                    asignado_operador = true;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un número antes de seleccionar un operador");
            }

        }

        private bool asignarNumero(string numero)
        {
            bool flag = false;
            if(temporal != string.Empty)
            {
                if (!asignado_numero1)
                {
                    numero1 = Convert.ToDecimal(numero);
                    asignado_numero1 = true;
                    temporal = string.Empty;
                    flag = true;
                }
                else if (!asignado_numero2)
                {
                    if (asignado_operador && asignado_numero1)
                    {
                        numero2 = Convert.ToDecimal(numero);
                        asignado_numero2 = true;
                        temporal = string.Empty;
                        flag = true;
                    }
                    else
                    {
                        MessageBox.Show("No se puede proceder");
                    }

                }
            } else
            {
                MessageBox.Show("No se puede proceder");
            }
            return flag;
            
        }

        private void ejecutarOperacion()
        {
            if(asignado_resultado)
            {
                MessageBox.Show("No se puede proceder");
            } else
            {
                if (asignado_operador && asignado_numero1)
                {
                    if (temporal != string.Empty)
                    {
                        asignarNumero(temporal);

                        if (operador == "+")
                        {
                            txtPantalla.Text = (numero1 + numero2).ToString();
                        }
                        else if (operador == "-")
                        {
                            txtPantalla.Text = (numero1 - numero2).ToString();
                        }
                        else if (operador == "*")
                        {
                            txtPantalla.Text = (numero1 * numero2).ToString();
                        }
                        else if (operador == "/")
                        {
                            txtPantalla.Text = (numero1 / numero2).ToString();
                        }

                        asignado_resultado = true;

                    }
                    else
                    {
                        MessageBox.Show("No se puede proceder");
                    }

                }
                else
                {
                    MessageBox.Show("No se puede proceder");
                }
            }
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            crearNumero("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            crearNumero("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            crearNumero("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            crearNumero("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            crearNumero("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            crearNumero("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            crearNumero("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            crearNumero("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            crearNumero("9");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            crearNumero("0");
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            crearNumero(".");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            ejecutarOperacion();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if(asignarNumero(temporal))
            {
                asignarOperador("+");
            }
            
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (asignarNumero(temporal))
            {
                asignarOperador("-");
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (asignarNumero(temporal))
            {
                asignarOperador("*");
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (asignarNumero(temporal))
            {
                asignarOperador("/");
            }
        }
    }
}
