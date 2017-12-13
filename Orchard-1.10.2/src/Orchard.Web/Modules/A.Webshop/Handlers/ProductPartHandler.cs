using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using A.Webshop.Models;

namespace A.Webshop.Handlers
{
    public class ProductPartHandler : ContentHandler
    {
        public ProductPartHandler(IRepository<ProductPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}