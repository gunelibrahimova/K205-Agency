namespace K205Agency.Models
{
    public class Portfolio :Base
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
        public string PhotoURL { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
