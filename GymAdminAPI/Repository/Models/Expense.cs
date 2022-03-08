using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class Expense
    {
        public int ExpenseID { set; get; }
        public string Description { set; get; }
        public double Amount { set; get; }
        public DateTime ExpenseDate { set; get; }
        public DateTime CreatedAt { set; get; }
        [ForeignKey("User")]
        public int CreatedBy { set; get; }

        public User User { set; get; }
    }
}
