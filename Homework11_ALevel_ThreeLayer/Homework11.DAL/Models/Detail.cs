namespace Homework11.DAL.Models
{
    public class Detail
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string DetailName { get; set; }
        public Car Car { get; set; }
        public int Cost { get; set; }
    }
}
