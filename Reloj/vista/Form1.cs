using Reloj.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reloj
{
    public partial class Form1 : Form
    {
        ClaseReloj reloj = new ClaseReloj();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prender();
        }

        private void prender()
        {
            reloj.Fecha = DateTime.Now;

            reloj.Horas = reloj.Fecha.Hour;
            reloj.Minutos = reloj.Fecha.Minute;
            reloj.Segundos = reloj.Fecha.Second;

            txtHoras.Text = reloj.Horas.ToString();
            txtMinutos.Text = reloj.Minutos.ToString();
            txtSegundos.Text = reloj.Segundos.ToString();
        }

        private void btnPrender_Click(object sender, EventArgs e)
        {
            prender();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            apagar();
        }

        public void apagar()
        {
            txtHoras.Text = "";
            txtMinutos.Text = "";
            txtSegundos.Text = "";
        }

        private void btnAtrasar_Click(object sender, EventArgs e)
        {
            atrasar();
        }

        public void atrasar()
        {
            int horas = int.Parse(txtHoras.Text);
            reloj.atrasar(horas);
            txtHoras.Text = reloj.Horas.ToString();
        }

        private void btnAdelantar_Click(object sender, EventArgs e)
        {
            adelantar();
        }

        public void adelantar()
        {
            int horas = int.Parse(txtHoras.Text);
            reloj.adelantar(horas);
            txtHoras.Text = reloj.Horas.ToString();
        }
    }
}
