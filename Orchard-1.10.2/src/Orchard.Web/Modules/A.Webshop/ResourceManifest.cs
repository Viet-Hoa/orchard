using Orchard.UI.Resources;

namespace A.Webshop
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {

            // Create and add a new manifest
            var manifest = builder.Add();

            // Define a "common" style sheet
            manifest.DefineStyle("A.Webshop.Common").SetUrl("common.css");

            // Define the "shoppingcart" style sheet
            manifest.DefineStyle("A.Webshop.ShoppingCart").SetUrl("shoppingcart.css").SetDependencies("A.Webshop.Common");

            // Define the "shoppingcartwidget" style sheet
            manifest.DefineStyle("A.Webshop.ShoppingCartWidget").SetUrl("shoppingcartwidget.css").SetDependencies("Webshop.Common");

            // Define Globalization resources
            manifest.DefineScript("Globalize").SetUrl("globalize.js").SetDependencies("jQuery");
            manifest.DefineScript("Globalize.Cultures").SetBasePath(manifest.BasePath + "scripts/cultures/").SetUrl("globalize.culture.js").SetCultures("en-US", "nl-NL").SetDependencies("Globalize", "jQuery");
            manifest.DefineScript("Globalize.SetCulture").SetUrl("~/A.Webshop/Resource/SetCultureScript").SetDependencies("Globalize.Cultures");


            // Define the "shoppingcart" script and set a dependencies
            manifest.DefineScript("A.Webshop.ShoppingCart").SetUrl("shoppingcart.js").SetDependencies("jQuery", "jQuery_LinqJs", "ko", "Globalize.SetCulture");
        }
    }
}