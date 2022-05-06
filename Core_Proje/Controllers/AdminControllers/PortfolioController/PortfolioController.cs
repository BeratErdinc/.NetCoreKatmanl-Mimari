using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers.AdminControllers.PortfolioController
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager( new EfPortfolio());
        public IActionResult Index()
        {
            var values = portfolioManager.TGetList();
            return View(values);
        }
    }
}
