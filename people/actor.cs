using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace people
{
    public class actor
    {
        //ctrl + . para usar prop, tambien se puede usar propfull
        protected string name;
        protected string last_name;
        protected string genero;
        protected string born_date;
        protected float sueldo;

        private string kimi;

        public string kimi_S_G
        {
            get { return kimi; }
            set { kimi = value; }
        }


        public float Sueldo { get => sueldo; set => sueldo = value; }
        public string Name { get => name; set => name = value; }
        public actor() {
            this.name = "";
            this.last_name = "";
            this.genero = "";
            this.born_date = "";
            this.Sueldo = 0f;
        }

        public actor(string name, string last_name, string genero, string born_date, float sueldo)
        {
            this.name = name;
            this.last_name = last_name;
            this.genero = genero;
            this.born_date = born_date;
            this.Sueldo = sueldo;
        }

        public void act_on() {
            Console.WriteLine("la actuacion fue iniciada");
        }

        public void set_name(string name) {
            this.name = name;
        }

        public void set_last_name(string last_name)
        {
            this.last_name = last_name;
        }

        public void set_genero(string genero)
        {
            this.genero = genero;
        }

        public void set_born_date(string born_date)
        {
            this.born_date = born_date;
        }

        public void set_sueldo(string sueldo)
        {
            try
            {
                this.Sueldo = float.Parse(sueldo);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public void set_sueldo(float sueldo)
        {
            this.Sueldo = sueldo;
        }

        public string get_name()
        {
            return this.name;
        }

        public string get_last_name()
        {
            return this.last_name;
        }

        public string get_genero()
        {
            return this.genero;
        }

        public string get_born_date()
        {
            return this.born_date;
        }

        public string get_sueldo()
        {
            return "" + this.Sueldo + "";  
        }

        public float get_sueldo(float temp=0f)
        {
            return this.Sueldo;
        }
    }
}
