using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp_pago
{
    public class comprobante
    {
        protected string code;
        protected string raz_social;
        protected string direction;
        protected string date;
        protected List<produc> products;
        protected float sub_price;

        public comprobante() {
            code = "";
            raz_social = "";
            direction = "";
            date = "";
            products = new List<produc>();
            sub_price = 0f;
        }

        public comprobante(string code="", string raz_social="", string direction="", string date="") {
            this.code = code;
            this.raz_social = raz_social;
            this.direction = direction;
            this.date = date;
            products = new List<produc>();
            sub_price = 0f;
        }

        public comprobante(string code = "", string raz_social = "", string direction = "", string date = "", List<produc> products = null)
        {
            this.code = code;
            this.raz_social = raz_social;
            this.direction = direction; 
            this.date = date;
            this.products = products;
            sub_price = 0f;
        }
        public void set_all_parameters(string code = "", string raz_social = "", string direction = "", string date = "")
        {
            this.code = code;
            this.raz_social = raz_social;
            this.direction = direction;
            this.date = date;
        }

        public void set_all_parameters(string code = "", string raz_social = "", string direction = "", string date = "", List<produc> products = null)
        {
            this.code = code;
            this.raz_social = raz_social;
            this.direction = direction;
            this.date = date;
            this.products = products;
        }

        public void set_products(List<produc> products) {
            this.products = products;
        }
        public void set_code(string code) {
            this.code = code;
        }
        public void set_raz_social(string raz_social)
        {
            this.raz_social = raz_social;
        }
        public void set_direction(string direction)
        {
            this.direction = direction;
        }
        public void set_date(string date)
        {
            this.date = date;
        }
        public string get_code()
        {
            return code;
        }
        public string get_raz_social()
        {
            return raz_social;
        }
        public string get_direction()
        {
            return direction;
        }
        public string get_date()
        {
            return date;
        }

        public List<produc> get_products() {
            return products;
        }

        public produc make_product() {
            return new produc();
        }

        public produc make_product(string code = "", string name = "", int cant = 0, float price = 0f) {
            return new produc(code, name, cant, price);
        }

        public produc make_product(string code = "", string name = "", string cant = "", string price = "")
        {
            return new produc(code, name, cant, price);
        }

        public void add_product(produc product) {
            products.Add(product);
        }

        public void remove_product(produc product) {
            products.Remove(product);
        }

        public void remove_product_by_code(string code) {
            for(int a=0; a<products.Count; ++a){
                if ((products[a].get_code()).Equals(code)==true){
                    products.RemoveAt(a);
                    --a;
                }
            }
        }

        public produc search_product_by_code(string code)
        {
            for (int a = 0; a < products.Count; ++a)
            {
                if ((products[a].get_code()).Equals(code) == true)
                {
                    products[a].calculate_total_price();
                    return products[a];
                    //break;
                }
            }
            return null;
        }

        public void print_all_products() {
            foreach (var item in products) {
                item.print();
            }
        }

        public void calculate_sub_price() {
            sub_price = 0f;
            foreach (var item in products)
            {
                item.calculate_total_price();
                sub_price = sub_price + item.get_total_price();
            }
        }
    }
}
