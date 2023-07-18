namespace Store.Models
{
    public class Description
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Processor { get; set; }
        public string Camera { get; set; }
        public string Battery { get; set; }
        
        
        public int PhoneId { get; set; }
        public Phone Phone { get; set; }
    }
}