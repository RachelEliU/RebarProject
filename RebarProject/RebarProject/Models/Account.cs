namespace RebarProject.Models
{
    public class Account
    {
        public Guid Id { get; set; }
        public List<Order> Orders { get; set; }= new List<Order>();
        public double sum {  get; set; }
    }
}
