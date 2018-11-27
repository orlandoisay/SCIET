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
        public string Date { get; set; }
        public string Customer { get; set; }
        public double Total { get; set; }
        //variables para reporte de Entradas y Salidas
        public int IdBatch { get; set; }
        public string DateBatch { get; set; }
        public string Reason { get; set; }
        public int QuantityBatch { get; set; }
        //variables para reportes de Inventarios
        public int IdArticle { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public double Price1 { get; set; }
        public double Price2 { get; set; }
        public double Price3 { get; set; }
        public double Price4 { get; set; }
        public double Cost { get; set; }
        public int QuantityArticle { get; set; }

        // Constructor para el reporte de Ventas y Costos
        public ReportPOJO(int IdSale, string Date, string Customer, double Total)
        {
            this.IdSale = IdSale;
            this.Date = Date;
            this.Customer = Customer;
            this.Total = Total;
        }

        // Constructor para reporte de Entradas y Salidas
        public ReportPOJO(int IdBatch, string DateBatch, string Reason, int QuantityBatch)
        {
            this.IdBatch = IdBatch;
            this.DateBatch = DateBatch;
            this.Reason = Reason;
            this.QuantityBatch = QuantityBatch;
        }

        // Constructor para reporte de Inventario
        public ReportPOJO(int IdArticle, string Name, string Color, string Size,
                            double Price1, double Price2, double Price3,  
                            double Price4, double Cost, int QuantityArticle)
        {
            this.IdArticle = IdArticle;
            this.Name = Name;
            this.Color = Color;
            this.Size = Size;
            this.Price1 = Price1;
            this.Price2 = Price2;
            this.Price3 = Price3;
            this.Price4 = Price4;
            this.Cost = Cost;
            this.QuantityArticle = QuantityArticle;
        }
    }
}
