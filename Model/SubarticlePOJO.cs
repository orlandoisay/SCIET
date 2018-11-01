using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class SubarticlePOJO
    {

        public int IdSubarticle { get; set; }
        public String Size { get; set; }
        public String Color { get; set; }
        public decimal Cost { get; set; }
        public decimal Price1 { get; set; }
        public decimal Price2 { get; set; }
        public decimal Price3 { get; set; }
        public decimal Price4 { get; set; }
        public int Quantity { get; set; }
        public int IdArticle { get; set; }

        public SubarticlePOJO() { }

        public SubarticlePOJO(int idSubarticle, String size, String color, decimal cost, decimal price1,
            decimal price2, decimal price3, decimal price4, int quantity, int idArticle)
        {
            IdSubarticle = idSubarticle;
            Size = size;
            Color = color;
            Cost = cost;
            Price1 = price1;
            Price2 = price2;
            Price3 = price3;
            Price4 = price4;
            Quantity = quantity;
            IdArticle = idArticle;
        }

    }
}
