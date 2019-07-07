using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp_pago
{
    public class boleta : comprobante
    {
        protected string dni;
        protected float total;

        public boleta()
        {
            code = "";
            raz_social = "";
            direction = "";
            date = "";
            products = new List<produc>();
            sub_price = 0f;
            total = 0f;
        }

        public boleta(string code = "", string raz_social = "", string direction = "", string date = "")
        {
            this.code = code;
            this.raz_social = raz_social;
            this.direction = direction;
            this.date = date;
            products = new List<produc>();
            sub_price = 0f;
            total = 0f;
        }

        public boleta(string code = "", string raz_social = "", string direction = "", string date = "", List<produc> products = null)
        {
            this.code = code;
            this.raz_social = raz_social;
            this.direction = direction;
            this.date = date;
            this.products = products;
            sub_price = 0f;
            total = 0f;
        }

        public string get_dni() {
            return dni;
        }

        public void set_dni(string dni) {
            this.dni = dni;
        }

        public void calculate_total_price()
        {
            total = 0f;
            calculate_sub_price();
            total = sub_price;
        }
    }
}
