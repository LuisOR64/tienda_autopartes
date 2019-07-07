using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    public class autor
    {
        protected string name;
        protected string last_name;
        protected string email;
        protected string genero;

        //override sobrecarga de funciones una funcion
        public override string ToString()
        {
            return ("Name: " + name + "\nLast name: " + last_name + "\nEmail: " + email + "\nGenero: " + genero);

        }
        public autor() {
            name = "";
            last_name = "";
            email = "";
            genero = "";
        }

        public autor(string name="", string last_name="", string email="", string genero="")
        {
            this.name = name;
            this.last_name = last_name;
            this.email = email;
            this.genero = genero;
        }

        public void set_autor(string name = "", string last_name = "", string email = "", string genero = "")
        {
            this.name = name;
            this.last_name = last_name;
            this.email = email;
            this.genero = genero;
        }
        public string Name { get => name; set => name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Email { get => email; set => email = value; }
        public string Genero { get => genero; set => genero = value; }
    }
}
