using KatmanliBurger.Data.Abstracts;

namespace KatmanliBurger.Data.Concretes
{
    public class CustomerMessage:BaseEntity
    {
        public string CustomerName { get; set; }
        public string CustomerPhone{ get; set; }
        public string CustomerEmail { get; set; }
        public string Message { get; set; }
    }
}
