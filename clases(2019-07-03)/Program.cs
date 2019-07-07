using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using people;
using book;
using comp_pago;

namespace clases_2019_07_03_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            actor person = new actor();
            doblaje_actor person_2 = new doblaje_actor();

            actor temp = new doblaje_actor();

            book.autor temp2 = new autor();

            Console.WriteLine(temp2.ToString());

            temp2.set_autor("kimi", "kanon", "email_autor", "femenino");

            book.book temp3 = new book.book("kimi","200.5","200",temp2);

            Console.WriteLine("Name: " + temp3.get_autor().Name);

            //listas

            List<string> string_list = new List<string>();
            string_list.Add("neko");
            string_list.Add("pochi");

            //List.AddRange(x); donde x es otra lista, sive para añadir una lista a otra
            foreach (var item in string_list) {
                Console.WriteLine(item);
            }

            Console.WriteLine("La lista tiene: " + string_list.Count + " elementos");
            */

            factura temp = new factura();
            

            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
