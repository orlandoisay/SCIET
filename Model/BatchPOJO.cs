using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
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
