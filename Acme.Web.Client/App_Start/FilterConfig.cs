using System.Web;
using System.Web.Mvc;

namespace Acme.Web.Client
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            var authorizeAttribute = new AuthorizeAttribute()
            {
                Roles = "infovisionlabs\\sigmaflow"
            };
            filters.Add(authorizeAttribute);
        }
    }
}
