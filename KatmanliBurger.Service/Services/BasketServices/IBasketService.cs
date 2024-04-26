using KatmanliBurger.Data.Concretes;
using KatmanliBurger.Data.DomainModels;

namespace KatmanliBurger.Service.Services.BasketServices
{
    public interface IBasketService
    {
        void AddToBasket(Basket basket, ByProduct? product, Menu? menu, Burger? burger);
        void RemoveFromBasket(Basket basket, int? productId, int? menuId, int? burgerId, int? removeAll);

        ICollection<BasketLine> GetList(Basket basket);
    }
}
