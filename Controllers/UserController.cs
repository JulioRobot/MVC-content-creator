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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public void TestCreate(string name, string email)
        {
            Console.WriteLine("user model name " + name);
            Console.WriteLine("user model email " + email);

            
        }
    }
}
