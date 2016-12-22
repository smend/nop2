using System.Web.Mvc;
using System.Web.Routing;
using Nop.Web.Framework.Mvc.Routes;

namespace Nop.Plugin.DiscountRules.OnePlusOne
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.DiscountRules.OnePlusOne.Configure",
                 "Plugins/DiscountRulesOnePlusOne/Configure",
                 new { controller = "DiscountRulesOnePlusOne", action = "Configure" },
                 new[] { "Nop.Plugin.DiscountRules.OnePlusOne.Controllers" }
            );
            routes.MapRoute("Plugin.DiscountRules.OnePlusOne.ProductAddPopup",
                 "Plugins/DiscountRulesOnePlusOne/ProductAddPopup",
                 new { controller = "DiscountRulesOnePlusOne", action = "ProductAddPopup" },
                 new[] { "Nop.Plugin.DiscountRules.OnePlusOne.Controllers" }
            );
            routes.MapRoute("Plugin.DiscountRules.OnePlusOne.ProductAddPopupList",
                 "Plugins/DiscountRulesOnePlusOne/ProductAddPopupList",
                 new { controller = "DiscountRulesOnePlusOne", action = "ProductAddPopupList" },
                 new[] { "Nop.Plugin.DiscountRules.OnePlusOne.Controllers" }
            );
            routes.MapRoute("Plugin.DiscountRules.OnePlusOne.LoadProductFriendlyNames",
                 "Plugins/DiscountRulesOnePlusOne/LoadProductFriendlyNames",
                 new { controller = "DiscountRulesOnePlusOne", action = "LoadProductFriendlyNames" },
                 new[] { "Nop.Plugin.DiscountRules.OnePlusOne.Controllers" }
            );
        }
        public int Priority
        {
            get
            {
                return 0;
            }
        }
    }
}
