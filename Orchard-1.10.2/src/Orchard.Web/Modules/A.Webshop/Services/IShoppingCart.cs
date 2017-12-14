using System.Collections.Generic;
using Orchard;
using A.Webshop.Models;

namespace A.Webshop.Services
{
    public interface IShoppingCart : IDependency {
        IEnumerable<ShoppingCartItem> Items { get; }
        void Add(int productId, int quantity = 1);
        void Remove(int productId);
        ProductPart GetProduct(int productId);
        IEnumerable<ProductQuantity> GetProducts();
        decimal Subtotal();
        decimal Vat();
        decimal Total();
        int ItemCount();
        void UpdateItems();
        void Clear();
        void AddRange(IEnumerable<ShoppingCartItem> items);
    }
}