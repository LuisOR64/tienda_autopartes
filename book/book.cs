using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    public class book
    {
        protected String title;
        protected float price;
        protected int page_number;
        protected autor autor_book;

        public book() {
            this.title = "";
            this.price = 0f;
            page_number = 0;
            autor_book = new autor();
        }
        public book(string title, float price, int page_number, autor autor_book)
        {
            this.title = title;
            this.price = price;
            this.page_number = page_number;
            this.autor_book = autor_book;
        }

        public book(string title, float price, int page_number, string autor_name = "", string autor_last_name = "", string autor_email = "", string autor_genero = "")
        {
            this.title = title;
            this.price = price;
            this.page_number = page_number;
            this.autor_book = new autor(autor_name, autor_last_name, autor_email, autor_genero);
        }

        public book(string title, string price, string page_number, autor autor_book)
        {
            this.title = title;
            this.price = float.Parse(price);
            this.page_number = int.Parse(page_number);
            this.autor_book = autor_book;
        }

        public book(string title, string price, string page_number, string autor_name = "", string autor_last_name = "", string autor_email = "", string autor_genero = "")
        {
            this.title = title;
            this.price = float.Parse(price);
            this.page_number = int.Parse(page_number);
            this.autor_book = new autor(autor_name, autor_last_name, autor_email, autor_genero);
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Page_number
        {
            get { return page_number; }
            set { page_number = value; }
        }

        public autor Autor_book { get => autor_book; set => autor_book = value; }

        public autor get_autor() {
            return autor_book;
        }
    }
}
