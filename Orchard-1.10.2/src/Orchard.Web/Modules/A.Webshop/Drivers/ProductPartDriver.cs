using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using A.Webshop.Models;

namespace A.Webshop.Drivers
{
    public class ProductPartDriver : ContentPartDriver<ProductPart> {

        protected override string Prefix {
            get { return "Product"; }
        }

        protected override DriverResult Display(ProductPart part, string displayType, dynamic shapeHelper)
        {
            // To return more than 1 shape, use the Combined method to create a "CombinedResult" object.
            return Combined(

                // Shape 1: Parts_Product
                ContentShape("Parts_Product", () => shapeHelper.Parts_Product(
                    Price: part.UnitPrice,
                    Sku: part.Sku
                )),

                // Shape 2: Parts_Product_AddButton
                ContentShape("Parts_Product_AddButton", () => shapeHelper.Parts_Product_AddButton(

                    // Set a property on the shape called ProductId and set it to the content ID
                    ProductId: part.Id
                ))
            );
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