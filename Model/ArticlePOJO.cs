using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class ArticlePOJO
    {

        public int IdArticle { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Image { get; set; }

        public ArticlePOJO() { }

        public ArticlePOJO(int idArticle, String name, String description, String image) {
            IdArticle = idArticle;
            Name = name;
            Description = description;
            Image = image;
        }

    }
}
