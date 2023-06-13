namespace APIDemo2.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }
        public int NumberInvoice { get; set; }
        public DateTime DateInvoice { get; set; }

        public bool IsDeleted { get; set; }



        public List<Detail> Details { get; set; }

        public Customer? Customer { get; set; }
        

    }
}
