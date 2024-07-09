using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloj.modelo
{
    public class ClaseReloj
    {
        private DateTime fecha;
        private int horas;
        private int minutos;
        private int segundos;
        private string marca;
        private string tipo;
        private bool prendido;

        public ClaseReloj () { }

        public ClaseReloj (DateTime fecha)
        {
            this.fecha = fecha;
        }

        public ClaseReloj (int horas, int minutos, int segundos, string marca, string tipo, bool prendido)
        {
            this.horas = horas;
            this.minutos = minutos;
            this.segundos = segundos;
            this.marca = marca;
            this.tipo = tipo;
            this.prendido = prendido;
        }

        public int Horas { get => horas; set => horas = value; }
        public int Minutos { get => minutos; set => minutos = value; }
        public int Segundos { get => segundos; set => segundos = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public bool Prendido { get => prendido; set => prendido = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }



        public void adelantar(int horas)
        {
            if (this.horas + horas > 24)
            {
                this.horas = (this.horas + horas) - 24;
            }
            else
            {
                this.horas += horas;
            }
        }

        public void atrasar(int horas)
        {
            if (this.horas - horas > 24)
            {
                this.horas = (this.horas - horas) + 24;
            }
            else if(this.horas - horas < 0) 
            {
                this.horas += 23;
            }
            else
            {
                this.horas -= horas;
            }
        }
    }
}
