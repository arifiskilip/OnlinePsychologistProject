using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default.Home
{
    public class _References : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
