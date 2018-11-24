using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Objeto POJO del lote (es una entrada o salida de un conjunto de artículos).
    /// </summary>
    /// <remarks>
    /// Permite manipular todos los atributos que componen un lote a través de un solo objeto.
    /// </remarks>
    public class BatchPOJO
    {

        public int IdBatch { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public int Quantity { get; set; }

        public BatchPOJO() { }

        public BatchPOJO(int idBatch, DateTime date, string reason, int quantity)
        {
            IdBatch = idBatch;
            Date = date;
            Reason = reason;
            Quantity = quantity;
        }

    }
}
