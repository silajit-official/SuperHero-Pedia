using Microsoft.AspNetCore.Mvc;
using Super_Hero_Pedia.Repository;

namespace Super_Hero_Pedia.Controllers
{
    public class HeroController : Controller
    {
        IMyRepository _myRepository = null;
        public HeroController(IMyRepository myRepository)
        {
            _myRepository=myRepository;
        }
        public IActionResult GetHeroes()
        {
            return View(_myRepository.GetHeros());
        }
    }
}
