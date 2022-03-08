namespace Repository.Models
{
    public class Visit
    {
        public int VisitID { set; get; }
        public int CustomerID { set; get; }
        public DateTime VisitDate { set; get; }

        public Customer Customer { set; get; }
    }
}
