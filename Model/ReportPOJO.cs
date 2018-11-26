using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ReportPOJO
    {

        // Declaración de variables para los cuatro tipos de reporte
        // variables para reportes de Ventas y Costos
        public int IdSale { get; set; }
        public DateTime Date { get; set; }
        public string Customer { get; set; }
        public double Total { get; set; }
        //variables para reporte de Entradas y Salidas
        public int IdBatch { get; set; }
        public DateTime DateBatch { get; set; }
        public string Reason { get; set; }
        public int QuantityBatch { get; set; }
        //variables para reportes de Inventarios
        public int IdArticle { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public double Cost { get; set; }
        public int QuantityArticle { get; set; }

        // Constructor para el reporte de Ventas y Costos
        public ReportPOJO(int IdSale, DateTime Date, string Customer, double Total)
        {
            this.IdSale = IdSale;
            this.Date = Date;
            this.Customer = Customer;
            this.Total = Total;
        }

        // Constructor para reporte de Entradas y Salidas
        public ReportPOJO(int IdBatch, DateTime DateBatch, string Reason, int QuantityBatch)
        {
            this.IdBatch = IdBatch;
            this.DateBatch = DateBatch;
            this.Reason = Reason;
            this.QuantityBatch = QuantityBatch;
        }

        // Constructor para reporte de Inventario
        public ReportPOJO(int IdArticle, string Name, string Color, string Size,
                            double Price, double Cost, int QuantityArticle)
        {
            this.IdArticle = IdArticle;
            this.Name = Name;
            this.Color = Color;
            this.Size = Size;
            this.Price = Price;
            this.Cost = Cost;
            this.QuantityArticle = QuantityArticle;
        }
    }
}
