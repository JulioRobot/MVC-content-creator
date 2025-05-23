using contentCreator.Models;
using Microsoft.AspNetCore.Mvc;

namespace contentCreator.Controllers
{
    public class UserController: Controller
    {
        public IActionResult Create()
        { 
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }

            return View(model);
        }
    }
}
