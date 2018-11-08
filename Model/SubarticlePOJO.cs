using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SubarticlePOJO
    {

        public string IdSubarticle { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public double Cost { get; set; }
        public double Price1 { get; set; }
        public double Price2 { get; set; }
        public double Price3 { get; set; }
        public double Price4 { get; set; }
        public int Quantity { get; set; }
        public int IdArticle { get; set; }

        public SubarticlePOJO() { }

        public SubarticlePOJO(string idSubarticle, string size, string color, double cost, double price1,
            double price2, double price3, double price4, int quantity, int idArticle)
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
