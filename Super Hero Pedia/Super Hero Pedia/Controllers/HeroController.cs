using Microsoft.AspNetCore.Mvc;
using Super_Hero_Pedia.Models;
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
        public IActionResult GetHeroes(int text=0)
        {
            if(text == 0)
                return View(_myRepository.GetHeros());
            else
            {
                return View(_myRepository.GetHeros().Where(m => m.UniverseId == text).ToList());
            }
        }



        public IActionResult HeroDetails(int Id, string view)
        {
            Heros result=_myRepository.GetHeros().Find(m=>m.Id==Id);
            if (result != null)
            {
                if(view==null)
                    return NotFound();
                else
                {
                    if (view.Equals("view"))
                        ViewBag.value = 1; //view
                    else
                        ViewBag.value = 0;  //Edit
                    return View(result);
                }
                
            }
            return NotFound();
        }

        public IActionResult test(int text)
        {
            int a = 10;
            return View("GetHeroes", (_myRepository.GetHeros().Where(m => m.UniverseId == 1).ToList()));
        }
    }
}
