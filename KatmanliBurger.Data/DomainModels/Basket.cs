namespace KatmanliBurger.Data.DomainModels
{
    public class Basket
    {
        public Basket()
        {
            BasketLines=new HashSet<BasketLine>();
        }
        public ICollection<BasketLine> BasketLines { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
