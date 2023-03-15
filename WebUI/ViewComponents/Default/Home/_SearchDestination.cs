using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default.Home
{
    public class _SearchDestination : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
