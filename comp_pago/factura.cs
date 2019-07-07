using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp_pago
{
    public  class factura : comprobante
    {
        protected string ruc;
        protected float igv;
        protected float total;
        public factura() {
            code = "";
            raz_social = "";
            direction = "";
            date = "";
            products = new List<produc>();
            sub_price = 0f;
            ruc = "";
            igv = 0f;
            total = 0f;
        }

        public factura(string code = "", string raz_social = "", string direction = "", string date = "", string ruc="", float igv=0f) {
            this.code = code;
            this.raz_social = raz_social;
            this.direction = direction;
            this.date = date;
            products = new List<produc>();
            sub_price = 0f;
            this.ruc = ruc;
            this.igv = igv;
            total = 0f;
        }

        public factura(string code = "", string raz_social = "", string direction = "", string date = "", string ruc = "", string igv = "") {
            this.code = code;
            this.raz_social = raz_social;
            this.direction = direction;
            this.date = date;
            products = new List<produc>();
            sub_price = 0f;
            this.ruc = ruc;
            this.igv = float.Parse(igv);
            total = 0f;
        }

        public factura(string code = "", string raz_social = "", string direction = "", string date = "", string ruc = "", float igv = 0f, List<produc> products = null)
        {
            this.code = code;
            this.raz_social = raz_social;
            this.direction = direction;
            this.date = date;
            this.products = products;
            sub_price = 0f;
            this.ruc = ruc;
            this.igv = igv;
            total = 0f;
        }

        public factura(string code = "", string raz_social = "", string direction = "", string date = "", string ruc = "", string igv = "", List<produc> products = null)
        {
            this.code = code;
            this.raz_social = raz_social;
            this.direction = direction;
            this.date = date;
            this.products = products;
            sub_price = 0f;
            this.ruc = ruc;
            this.igv = float.Parse(igv);
            total = 0f;
        }

        public void set_ruc(string ruc) {
            this.ruc = ruc;
        }

        public void set_igv(float igv) {
            this.igv = igv;
        }

        public void set_igv(string igv) {
            this.igv = float.Parse(igv);
        }

        public string get_ruc() {
            return ruc;
        }

        public float get_igv() {
            return igv;
        }

        public string get_igv(string temp="") {
            return "" + igv + "";
        }

        public void calculate_total_price() {
            total = 0f;
            calculate_sub_price();
            total = total + (sub_price * (igv/100)) + sub_price;
        }
    }
}
