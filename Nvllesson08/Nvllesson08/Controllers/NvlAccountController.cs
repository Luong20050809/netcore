using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nvllesson08.Models;

namespace Nvllesson08.Controllers
{


    public class NvlAccountController : Controller
    {
        private static List<NvlAccount> nvlListAccount = new List<NvlAccount>()
        {
            new NvlAccount
                {
                    NvlId = 231090060,
                    NvlFullName = "Nguyễn Văn Lượng",
                    NvlEmail = "luonghn2005@gmail.com",
                    NvlPhone = "0964729904",
                    NvlAddress = "Lớp K23CNT2",
                    NvlAvatar = "banbe.jpg",
                    NvlBirthday = new DateTime(2005, 9, 8),
                    NvlGender = "Nam",
                    NvlPassword = "0978611889",
                    NvlFacebook = "https://facebook.com/banbe"
                },
                new NvlAccount
                {
                    NvlId = 2,
                    NvlFullName = "Trần Thị B",
                    NvlEmail = "tranthib@example.com",
                    NvlPhone = "0987654321",
                    NvlAddress = "456 Đường B, Quận 3, TP.HCM",
                    NvlAvatar = "avatar2.jpg",
                    NvlBirthday = new DateTime(1992, 8, 15),
                    NvlGender = "Nữ",
                    NvlPassword = "password2",
                    NvlFacebook = "https://facebook.com/tranthib"
                },
                new NvlAccount
                {
                    NvlId = 3,
                    NvlFullName = "Lê Văn C",
                    NvlEmail = "levanc@example.com",
                    NvlPhone = "0911222333",
                    NvlAddress = "789 Đường C, Quận 5, TP.HCM",
                    NvlAvatar = "avatar3.jpg",
                    NvlBirthday = new DateTime(1988, 12, 1),
                    NvlGender = "Nam",
                    NvlPassword = "password3",
                    NvlFacebook = "https://facebook.com/levanc"
                },
                new NvlAccount
                {
                    NvlId = 4,
                    NvlFullName = "Phạm Thị D",
                    NvlEmail = "phamthid@example.com",
                    NvlPhone = "0909876543",
                    NvlAddress = "321 Đường D, Quận 7, TP.HCM",
                    NvlAvatar = "avatar4.jpg",
                    NvlBirthday = new DateTime(1995, 3, 10),
                    NvlGender = "Nữ",
                    NvlPassword = "password4",
                    NvlFacebook = "https://facebook.com/phamthid"
                },
                new NvlAccount
                {
                    NvlId = 5,
                    NvlFullName = "Hoàng Văn E",
                    NvlEmail = "hoangvane@example.com",
                    NvlPhone = "0933444555",
                    NvlAddress = "654 Đường E, Quận 10, TP.HCM",
                    NvlAvatar = "avatar5.jpg",
                    NvlBirthday = new DateTime(1991, 7, 22),
                    NvlGender = "Nam",
                    NvlPassword = "password5",
                    NvlFacebook = "https://facebook.com/hoangvane"
                }
        };
        // GET: NvlAccountController
        public ActionResult NvlIndex()
        {
            return View(nvlListAccount);
        }

        // GET: NvlAccountController/Details/5
        public ActionResult NvlDetails(int id)
        {
            var nvlModel = nvlListAccount.FirstOrDefault(x => x.NvlId == id);
            return View(nvlModel);
        }
        // GET: NvlAccountController/Create
        public ActionResult NvlCreate()
        {
            var nvlModel = new NvlAccount();
            return View(nvlModel);
        }

        // POST: NvlAccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvlCreate(NvlAccount nvlModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    nvlListAccount.Add(nvlModel);
                    return RedirectToAction(nameof(NvlIndex));
                }

                // Nếu dữ liệu không hợp lệ, trả về View để người dùng sửa
                return View(nvlModel);
            }
            catch (Exception ex)
            {
                // Bạn có thể log lỗi ở đây nếu cần
                ModelState.AddModelError("", "Có lỗi xảy ra khi thêm mới: " + ex.Message);
                return View(nvlModel);
            }
        }

        // GET: NvlAccountController/Edit/5
        public ActionResult NvlEdit(int id)
        {
            var nvlModel = nvlListAccount.FirstOrDefault(x => x.NvlId == id);
            return View(nvlModel);
        }

        // POST: NvlAccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvlEdit(int id, NvlAccount nvlModel)
        {
            try
            {
                for (int i = 0; i < nvlListAccount.Count(); i++)
                {
                    if (nvlListAccount[i].NvlId == id)
                    {
                        nvlListAccount[i] = nvlModel;
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

        // GET: NvlAccountController/Delete/5
        public ActionResult NvlDelete(int id)
        {
            var nvlModel = nvlListAccount.FirstOrDefault(e => e.NvlId == id);
            if (nvlModel == null)
            {
                return NotFound();
            }
            return View(nvlModel);
        }

        // POST: NvlAccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvlDelete(int id, NvlAccount nvlModel)
        {
            try
            {
                for (int i = 0; i < nvlListAccount.Count; i++)
                {
                    if (nvlListAccount[i].NvlId == id)
                    {
                        nvlListAccount.RemoveAt(i);
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