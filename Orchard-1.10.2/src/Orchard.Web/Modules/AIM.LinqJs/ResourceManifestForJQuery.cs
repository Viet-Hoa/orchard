using Orchard.Environment.Extensions;
using Orchard.UI.Resources;

namespace AIM.LinqJs
{
	[OrchardFeature("AIM.LinqJs.jQuery")]
	public class ResourceManifestForJQuery : IResourceManifestProvider
	{
		public void BuildManifests(ResourceManifestBuilder builder)
		{
			var manifest = builder.Add();

			manifest.DefineScript("jQuery_LinqJs").SetUrl("jquery.linq.min.js", "jquery.linq.js").SetVersion("2.2.0.2").SetDependencies("jQuery");
			manifest.DefineScript("LinqJs_Binding_jQuery").SetUrl("bindings/linq.jquery.js").SetVersion("2.2.0.2").SetDependencies("jQuery", "LinqJs");
		}
	}
}