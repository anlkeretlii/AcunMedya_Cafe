using AcunMedya.Cafe.Context;
using AcunMedya.Cafe.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Cafe.Controllers
{
    public class LoginController : Controller
    {
        private readonly CafeContext _context;

        public LoginController(CafeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(); // Login sayfası
        }

        [HttpPost]
        public IActionResult Index(User user)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            var userInfo = _context.Users
                .FirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);

            if (userInfo != null)
            {
                HttpContext.Session.SetString("username", userInfo.UserName);

                // Başarılı girişten sonra yönlendirme
                return Redirect("/Admin/Dashboard/Index");
            }
            else
            {
                ViewBag.ErrorMessage = "Geçersiz kullanıcı adı veya şifre.";
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
