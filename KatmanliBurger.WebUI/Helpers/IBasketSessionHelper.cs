using KatmanliBurger.Data.DomainModels;

namespace KatmanliBurger.WebUI.Helpers
{
    public interface IBasketSessionHelper
    {
        Basket GetBasket(string key);
        void SetBasket(string key, Basket basket);
        void Clear();
    }
}
