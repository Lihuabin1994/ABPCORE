using Microsoft.AspNetCore.Antiforgery;
using VueCore.Controllers;

namespace VueCore.Web.Host.Controllers
{
    public class AntiForgeryController : VueCoreControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
