using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace people
{
    public class doblaje_actor: actor
    {
        protected string languaje;
        protected String tono_voz;
        protected List<string> personajes = new List<string>();

        protected string Languaje { get => languaje; set => languaje = value; }
        protected string Tono_voz { get => tono_voz; set => tono_voz = value; }

        public doblaje_actor() {
            this.name = "";
            this.last_name = "";
            this.genero = "";
            this.born_date = "";
            this.Sueldo = 0f;
            this.languaje = "";
            this.Tono_voz = "";
        }

        public doblaje_actor(string name, string last_name, string genero, string born_date, float sueldo, string languaje, string tono_voz)
        {
            this.name = name;
            this.last_name = last_name;
            this.genero = genero;
            this.born_date = born_date;
            this.Sueldo = sueldo;
            this.languaje = languaje;
            this.Tono_voz = tono_voz;           
        }

        public doblaje_actor(string name, string last_name, string genero, string born_date, float sueldo, string languaje, string tono_voz, bool i=true) : base(name, last_name, genero, born_date, sueldo)
        {
            this.languaje = languaje;
            this.Tono_voz = tono_voz;
        }
        public void doblar_movie() {
            Console.WriteLine("termine de doblar la pelicula");
        }

        public void calentar_voz() {
            Console.WriteLine("Preparando voz");
        }

        public void actuar() {
            this.act_on();
        }
    }
}
