using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default.Home
{
    public class _Options : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
