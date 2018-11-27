using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SaleArticleDetail
    {
        public String Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }

        public SaleArticleDetail(String name, int quantity, double price, double total) {
            Name = name;
            Quantity = quantity;
            Price = price;
            Total = total;
        }

    }
}
