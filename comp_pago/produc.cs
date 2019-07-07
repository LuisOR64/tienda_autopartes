using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp_pago
{
    public class produc
    {
        protected string code;
        protected string name;
        protected int cant;
        protected float price;
        protected float total_price;
        public produc() {
            code = "";
            name = "";
            cant = 0;
            price = 0f;
            total_price = 0f;
        }

        public produc(string code="", string name="", int cant=0, float price=0f)
        {
            this.code = code;
            this.name = name;
            this.cant = cant;
            this.price = price;
            total_price = 0f;
        }

        public produc(string code = "", string name = "", string cant = "", string price = "")
        {
            try
            {
                this.code = code;
                this.name = name;
                this.cant = int.Parse(cant);
                this.price = float.Parse(price);
                total_price = 0f;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public void set_all_atribs(string code = "", string name = "", int cant = 0, float price = 0f)
        {
            this.code = code;
            this.name = name;
            this.cant = cant;
            this.price = price;
        }

        public void set_all_atribs(string code = "", string name = "", string cant = "", string price = "")
        {
            try
            {
                this.code = code;
                this.name = name;
                this.cant = int.Parse(cant);
                this.price = float.Parse(price);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public void set_code(string code="") {
            this.code = code;
        }

        public void set_name(string name="") {
            this.name = name;
        }

        public void set_cant(int cant=0) {
            this.cant = cant;
        }

        public void set_price(float price=0f) {
            this.price = price;
        }

        public string get_code()
        {
            return code;
        }

        public string get_name()
        {
            return name;
        }

        public int get_cant()
        {
            return cant;
        }

        public float set_price()
        {
            return price;
        }

        public string get_cant(string temp="") {
            return "" + cant + "";
        }

        public string get_price(string temp = "")
        {
            return "" + price + "";
        }

        public float get_total_price()
        {
            return total_price;
        }

        public string get_total_price(string temp="") {
            return "" + total_price + "";
        }

        public void print() {

            calculate_total_price();
            Console.WriteLine("Code: " + code + "\nName: " + name + "\nCant: " + cant + "\nPrice: " + price + "\nTotal price: " + total_price);
        }

        public override string ToString()
        {
            return ("Code: " + code + "\nName: " + name + "\nCant: " + cant + "\nPrice: " + price).ToString();
        }

        public void calculate_total_price() {
            total_price = cant * price;
        }
    }
}
