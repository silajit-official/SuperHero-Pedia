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
        public IActionResult GetHeroes()
        {
            return View(_myRepository.GetHeros());
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
    }
}
