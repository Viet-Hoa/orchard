//using System;
//using System.Collections.Generic;
//using Orchard.ContentManagement;
//using Orchard.ContentManagement.MetaData;
//using Orchard.Localization;
//using Orchard.Projections.Descriptors.Filter;
//using A.Webshop.Models;
//using IFilterProvider = Orchard.Projections.Services.IFilterProvider;

//namespace A.Webshop.Filters {
//    public class ContentPartsFilter : IFilterProvider {
//        private readonly IContentDefinitionManager _contentDefinitionManager;

//        public Localizer T { get; set; }

//        public ContentPartsFilter(IContentDefinitionManager contentDefinitionManager) {
//            _contentDefinitionManager = contentDefinitionManager;
//            T = NullLocalizer.Instance;
//        }

//        public void Describe(DescribeFilterContext describe) {
//            describe.For("Content", T("Content"), T("Content"))
//                .Element("ContentParts", T("Content Parts"), T("Specific content parts"),
//                    ApplyFilter,
//                    DisplayFilter,
//                    "ContentPartsFilter"
//                );
//        }

//        public void ApplyFilter(FilterContext context) {
//            context.Query = context.Query.Join(x => x.ContentPartRecord(typeof (ProductPartRecord)));
//            var contentPartsString = Convert.ToString(context.State.ContentParts);
//            if (!String.IsNullOrEmpty(contentPartsString)) {
//                var contentParts = contentPartsString.Split(new[]{','}, StringSplitOptions.RemoveEmptyEntries);

//                foreach (var contentPart in contentParts)
//                {
//                    _contentDefinitionManager.GetPartDefinition(contentPart).
//                }
//                context.Query = context.Query.Join(x => x.ContentPartRecord(typeof (ProductPartRecord)));
//            }
//        }

//        public LocalizedString DisplayFilter(FilterContext context) {
//            string contentParts = context.State.ContentParts;

//            if (String.IsNullOrEmpty(contentParts)) {
//                return T("Any content item");
//            }

//            return T("Content with part {0}", contentParts);
//        }
//    }
//}