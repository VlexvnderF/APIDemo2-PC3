using System.ComponentModel.DataAnnotations.Schema;

namespace APIDemo2.Models
{
    public class Detail
    {
        public int DetailID { get; set; }


        public Invoice?  Invoice { get; set; }
        public int InvoiceID { get; set; }


        public int Cantidad { get; set; }

        public decimal Price { get; set; }

        public decimal SubTotal { get; set; }

  
    }
}
