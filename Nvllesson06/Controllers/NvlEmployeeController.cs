using Microsoft.AspNetCore.Mvc;
using Nvllesson06.Models;

namespace Nvllesson06.Controllers
{
    public class NvlEmployeeController : Controller
    {
        private static List<NvlEmployee> nvlListEmployee = new List<NvlEmployee>()
        {
            new NvlEmployee { NvlId = 1, NvlName = "Nguyễn Văn Lượng", NvlBirthDay = new DateTime(2005, 9 ,8), NvlEmail = "luonghn2005@gmail.com", NvlPhone = "0964729904", NvlSalary = 12000000, NvlStatus = true},
            new NvlEmployee { NvlId = 2, NvlName = "Trần Thị B", NvlBirthDay = new DateTime(1992, 5 ,15), NvlEmail = "b@example.com", NvlPhone = "0912233445", NvlSalary = 15000000, NvlStatus = true},
            new NvlEmployee { NvlId = 3, NvlName = "Lê Văn C", NvlBirthDay = new DateTime(1988, 9 ,20), NvlEmail = "c@example.com", NvlPhone = "0922123456", NvlSalary = 11000000, NvlStatus = false},
            new NvlEmployee { NvlId = 4, NvlName = "Phạm Thị B", NvlBirthDay = new DateTime(1995, 10 ,3), NvlEmail = "d@example.com", NvlPhone = "0933445566", NvlSalary = 10000000, NvlStatus = true},
            new NvlEmployee { NvlId = 5, NvlName = "Đỗ Văn E", NvlBirthDay = new DateTime(1991, 7 ,25), NvlEmail = "e@example.com", NvlPhone = "0944567890", NvlSalary = 13000000, NvlStatus = false}
        };
        public IActionResult NvlIndex()
        { 
            return View(nvlListEmployee);
        }

        //Action Get: /NvlEmployee/NvlCreate

        public IActionResult NvlCreate()
        {
            return View();
        }
        public IActionResult NvlCreateSubmit(NvlEmployee model)
        {
            if (ModelState.IsValid)
            {
                int newId = nvlListEmployee.Any() ? nvlListEmployee.Max(e => e.NvlId) + 1 : 1;
                model.NvlId = newId;
                nvlListEmployee.Add(model);
                return RedirectToAction("NvlIndex");
            }
            return View(model);
        }
    
    }
}
