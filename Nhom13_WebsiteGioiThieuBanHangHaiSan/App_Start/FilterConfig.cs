using System.Web;
using System.Web.Mvc;

namespace Nhom13_WebsiteGioiThieuBanHangHaiSan
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
