using LeaveManagementSystem.web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Student of MVC MASTERI",
                DateOfBird = new DateTime(2001, 04, 23)
                    
            };
            return View(data);
        }
    }
}
