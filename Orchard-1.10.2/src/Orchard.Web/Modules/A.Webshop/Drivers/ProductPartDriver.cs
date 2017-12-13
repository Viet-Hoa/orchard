using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using A.Webshop.Models;

namespace A.Webshop.Drivers
{
    public class ProductPartDriver : ContentPartDriver<ProductPart> {

        protected override string Prefix {
            get { return "Product"; }
        }

        protected override DriverResult Editor(ProductPart part, dynamic shapeHelper) {
            return ContentShape("Parts_Product_Edit", () => shapeHelper
                .EditorTemplate(TemplateName: "Parts/Product", Model: part, Prefix: Prefix));
        }

        protected override DriverResult Editor(ProductPart part, IUpdateModel updater, dynamic shapeHelper) {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }

    }
}