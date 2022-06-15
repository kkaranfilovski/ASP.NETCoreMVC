using System.Web;
using System.Web.Mvc;

namespace SEDC.DotnetFullFrameWork.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
