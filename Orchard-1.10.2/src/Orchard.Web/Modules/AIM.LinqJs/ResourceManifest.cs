using Orchard.UI.Resources;

namespace AIM.LinqJs
{
	public class ResourceManifest : IResourceManifestProvider
	{
		public void BuildManifests(ResourceManifestBuilder builder)
		{
			var manifest = builder.Add();

			manifest.DefineScript("LinqJs").SetUrl("linq.min.js", "linq.js").SetVersion("2.2.0.2");
			manifest.DefineScript("LinqJs_Binding_Rx").SetUrl("bindings/linq.rx.js").SetVersion("2.2.0.2");
		}
	}
}
