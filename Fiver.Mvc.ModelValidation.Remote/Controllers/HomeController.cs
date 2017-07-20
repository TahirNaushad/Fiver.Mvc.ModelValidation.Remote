using Microsoft.AspNetCore.Mvc;
using Fiver.Mvc.ModelValidation.Remote.Models.Home;
using Newtonsoft.Json;

namespace Fiver.Mvc.ModelValidation.Remote.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(EmployeeInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var json = JsonConvert.SerializeObject(model);
            return Content(json);
        }

        public IActionResult ValidateEmployeeNo(string employeeNo)
        {
            if (employeeNo == "007")
                return Json(data: "007 is already assigned to James Bond!");

            return Json(data: true);
        }
    }
}
