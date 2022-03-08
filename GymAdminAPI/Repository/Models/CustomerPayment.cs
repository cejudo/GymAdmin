using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class CustomerPayment
    {
        public int CustomerPaymentID { set; get; }
        public int CustomerID { set; get; }
        public int? PaymentID { set; get; }
        [ForeignKey("User")]
        public int? CreatedBy { set; get; }
        public DateTime PaymentDate { set; get; }

        public Customer Customer { set; get; }
        public Payment Payment { set; get; }
        public User User { set; get; }
    }
}
