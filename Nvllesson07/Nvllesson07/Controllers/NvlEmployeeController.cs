using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nvllesson07.Models;
using NvlLesson07.Models;

namespace Nvllesson07.Controllers
{
    public class NvlEmployeeController : Controller
    {
        // Mock Data:
        private static List<NvlEmployee> nvlListEmployee = new List<NvlEmployee>()
        {
            new NvlEmployee
            {
                NvlId = 231090060,
                NvlName = "Nguyễn Văn Lượng",
                NvlBirthDay = new DateTime(1979, 5, 25),
                NvlEmail = "luonghn2005@gmail.com",
                NvlPhone = "094729904",
                NvlSalary = 12000000m,
                NvlStatus = true
            },
            new NvlEmployee
            {
                NvlId = 2,
                NvlName = "Trần Thị B",
                NvlBirthDay = new DateTime(1992, 8, 15),
                NvlEmail = "tranthib@example.com",
                NvlPhone = "0912345678",
                NvlSalary = 13500000m,
                NvlStatus = true
            },
            new NvlEmployee
            {
                NvlId = 3,
                NvlName = "Lê Văn C",
                NvlBirthDay = new DateTime(1988, 3, 22),
                NvlEmail = "levanc@example.com",
                NvlPhone = "0934567890",
                NvlSalary = 10000000m,
                NvlStatus = false
            },
            new NvlEmployee
            {
                NvlId = 4,
                NvlName = "Phạm Thị D",
                NvlBirthDay = new DateTime(1995, 11, 5),
                NvlEmail = "phamthid@example.com",
                NvlPhone = "0976543210",
                NvlSalary = 15000000m,
                NvlStatus = true
            },
            new NvlEmployee
            {
                NvlId = 5,
                NvlName = "Đỗ Văn E",
                NvlBirthDay = new DateTime(1991, 7, 18),
                NvlEmail = "dovane@example.com",
                NvlPhone = "0981122334",
                NvlSalary = 11000000m,
                NvlStatus = false
            }
        };
        // GET: NvlEmployeeController
        public ActionResult NvlIndex()
        {
            return View(nvlListEmployee);
        }

        // GET: NvlEmployeeController/NvlDetails/5
        public ActionResult NvlDetails(int id)
        {
            var nvlEmployee = nvlListEmployee.FirstOrDefault(x => x.NvlId == id);
            return View(nvlEmployee);
        }

        // GET: NvlEmployeeController/NvlCreate
        public ActionResult NvlCreate()
        {
            var nvlEmployee = new NvlEmployee();
            return View(nvlEmployee);
        }

        // POST: NvlEmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvlCreate(NvlEmployee nvlModel)
        {
            try
            {
                // Thêm mới nhân viên vào list
                nvlModel.NvlId = nvlListEmployee.Max(x => x.NvlId) + 1;
                nvlListEmployee.Add(nvlModel);
                return RedirectToAction(nameof(NvlIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: NvlEmployeeController/NvlEdit/5
        public ActionResult NvlEdit(int id)
        {
            var nvlEmployee = nvlListEmployee.FirstOrDefault(x => x.NvlId == id);
            return View(nvlEmployee);
        }

        // POST: NvlEmployeeController/NvlEdit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvlEdit(int id, NvlEmployee nvlModel)
        {
            try
            {
                for (int i = 0; i < nvlListEmployee.Count(); i++)
                {
                    if (nvlListEmployee[i].NvlId == id)
                    {
                        nvlListEmployee[i] = nvlModel;
                        break;
                    }
                }
                return RedirectToAction(nameof(NvlIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: NvlEmployeeController/Delete/5
        public ActionResult NvlDelete(int id)
        {
            var nvlEmployee = nvlListEmployee.FirstOrDefault(e => e.NvlId == id);
            if (nvlEmployee == null)
            {
                return NotFound();
            }
            return View(nvlEmployee);
        }

        // POST: NvlEmployeeController/NvlDelete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvlDelete(int id, NvlEmployee nvlModel)
        {
            try
            {
                for (int i = 0; i < nvlListEmployee.Count; i++)
                {
                    if (nvlListEmployee[i].NvlId == id)
                    {
                        nvlListEmployee.RemoveAt(i);
                        break;
                    }
                }
                return RedirectToAction(nameof(NvlIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}