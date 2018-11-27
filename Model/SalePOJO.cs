using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SalePOJO
    {
        public int IdSale { get; set; }
        public string Date { get; set; }
        public string TypeSale { get; set; }
        public double Total { get; set; }
        public string Estatus { get; set; }
        public string Prenda { get; set; }

        public SalePOJO(int idSale, string date, string typeSale, double total, string estatus) {
            IdSale = idSale;
            Date = date;
            TypeSale = typeSale;
            Total = total;
            Estatus = estatus;
            Prenda = "Ver";
        }

    }
}
