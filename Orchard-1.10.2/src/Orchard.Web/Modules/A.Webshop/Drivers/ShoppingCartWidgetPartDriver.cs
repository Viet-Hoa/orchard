using Orchard.ContentManagement.Drivers;
using A.Webshop.Models;
using A.Webshop.Services;

namespace A.Webshop.Drivers
{
    public class ShoppingCartWidgetPartDriver : ContentPartDriver<ShoppingCartWidgetPart> {
        private readonly IShoppingCart _shoppingCart;

        public ShoppingCartWidgetPartDriver(IShoppingCart shoppingCart) {
            _shoppingCart = shoppingCart;
        }

        protected override DriverResult Display(ShoppingCartWidgetPart part, string displayType, dynamic shapeHelper) {
            return ContentShape("Parts_ShoppingCartWidget", () => shapeHelper.Parts_ShoppingCartWidget(
                ItemCount: _shoppingCart.ItemCount(),
                TotalAmount: _shoppingCart.Total()
            ));
        }
    }
}