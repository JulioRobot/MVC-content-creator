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
          
            Console.WriteLine("user model name " + model.Name);
            Console.WriteLine("user model email " + model.Email);

            return View(model);
        }

        []
    }
}
