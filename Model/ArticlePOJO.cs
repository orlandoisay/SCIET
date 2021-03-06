﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Objeto POJO del artículo.
    /// </summary>
    /// <remarks>
    /// Permite manipular todos los atributos que componen un artículo a través de un solo objeto.
    /// </remarks>
    public class ArticlePOJO
    {

        public int IdArticle { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }

        public ArticlePOJO() { }

        public ArticlePOJO(int idArticle, string name, string description, string image) {
            IdArticle = idArticle;
            Name = name;
            Description = description;
            Image = image;
        }

        public ArticlePOJO(int idArticle, string name, string description, string image, int quantity)
        {
            IdArticle = idArticle;
            Name = name;
            Description = description;
            Image = image;
            Quantity = quantity;
        }

    }
}
