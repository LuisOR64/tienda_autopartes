using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp_pago
{
    public class nota_credito: comprobante
    {
        protected string ruc;
        protected float igv;
        protected string motive;
        protected string state;
        protected float total;
    }
}
