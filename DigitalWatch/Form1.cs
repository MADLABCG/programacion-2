using System;
using System.Globalization;
using System.Windows.Forms;

namespace DigitalWatch
{
    public partial class Form1 : Form
    {

        System.Windows.Forms.Timer timer;
        System.Windows.Forms.Timer alarma;

        public Form1()
        {
            InitializeComponent();
            InicializarReloj();
            InitializeTimer();
            InitializeAlarma();
        }

        private void InicializarReloj()
        {
            lblAlarma.Text = " ";
            rbAM.Checked = true;
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void InitializeAlarma()
        {
            alarma = new System.Windows.Forms.Timer();
            alarma.Interval = 1000; // 1 second
            alarma.Tick += Alarma_Tick;
            alarma.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblFecha.Text = DateTime.Now.ToString("dddd dd MMMM", CultureInfo.CreateSpecificCulture("es-US"));
        }

        private void Alarma_Tick(object sender, EventArgs e)
        {
            if (cbAlarma.Checked == true)
            {
                int horas = int.Parse(nHoras.Value.ToString());
                int minutos = int.Parse(nMinutos.Value.ToString());
                string hora_actual = DateTime.Now.ToString("h:mm tt");
                string hora_alarma = horas.ToString() + ":" + minutos.ToString() + " " + getAmPm();
                if (hora_actual == hora_alarma)
                {
                    lblAlarma.Text = "Alarma";
                }
            }

        }

        private string getAmPm()
        {

            if (rbAM.Checked)
            {
                return "AM";
            }
            if (rbPM.Checked)
            {
                return "PM";
            }
            return "";
        }
    
    }

}
