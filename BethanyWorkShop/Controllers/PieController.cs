using Microsoft.AspNetCore.Mvc;
using BethanyWorkShop.Models;

namespace BethanyWorkShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository pieRepostior ;
        public PieController(IPieRepository pieRepostior)
        {
            this.pieRepostior = pieRepostior;
        }
        public ViewResult List()
        {
            var pies = pieRepostior.AllPies;
            return View(pies);
        }
    }
}
