using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class Payment
    {
        public int PaymentID { set; get; }
        public string Description { set; get; }
        public double Amount { set; get; }
        public DateTime LastModifiedAt { set; get; }
        [ForeignKey("User")]
        public int LastModifiedBy { set; get; }

        public User User { set; get; }
    }
}
