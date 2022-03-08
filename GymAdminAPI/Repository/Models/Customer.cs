using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class Customer
    {
        public int CustomerID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public DateTime LastModifiedAt { set; get; }
        [ForeignKey("User")]
        public int LastModifiedBy { set; get; }

        public User User { set; get; }
    }
}
