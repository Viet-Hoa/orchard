using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard;
using Orchard.ContentManagement;
using A.Webshop.Models;

namespace A.Webshop.Services
{
    public class ShoppingCart : IShoppingCart {
        private readonly IWorkContextAccessor _workContextAccessor;
        private readonly IContentManager _contentManager;
        public IEnumerable<ShoppingCartItem> Items { get { return ItemsInternal.AsReadOnly(); } }

        private HttpContextBase HttpContext {
            get { return _workContextAccessor.GetContext().HttpContext; }
        }

        private List<ShoppingCartItem> ItemsInternal {
            get {
                var items = (List<ShoppingCartItem>)HttpContext.Session["ShoppingCart"];

                if (items == null) {
                    items = new List<ShoppingCartItem>();
                    HttpContext.Session["ShoppingCart"] = items;
                }

                return items;
            }
        }

        public ShoppingCart(IWorkContextAccessor workContextAccessor, IContentManager contentManager)
        {
            _workContextAccessor = workContextAccessor;
            _contentManager = contentManager;
        }

        public void Add(int productId, int quantity = 1) {
            var item = Items.SingleOrDefault(x => x.ProductId == productId);

            if (item == null) {
                item = new ShoppingCartItem(productId, quantity);
                ItemsInternal.Add(item);
            }
            else {
                item.Quantity += quantity;
            }
        }

        public void Remove(int productId) {
            var item = Items.SingleOrDefault(x => x.ProductId == productId);

            if (item == null)
                return;

            ItemsInternal.Remove(item);
        }

        public ProductPart GetProduct(int productId) {
            return _contentManager.Get<ProductPart>(productId);
        }

        public void UpdateItems() {
            ItemsInternal.RemoveAll(x => x.Quantity == 0);
        }

        public decimal Subtotal() {
            return Items.Select(x => GetProduct(x.ProductId).UnitPrice * x.Quantity).Sum();
        }

        public decimal Vat() {
            return Subtotal() * .19m;
        }

        public decimal Total() {
            return Subtotal() + Vat();
        }

        public int ItemCount() {
            return Items.Sum(x => x.Quantity);
        }

        private void Clear() {
            ItemsInternal.Clear();
            UpdateItems();
        }

    }
}