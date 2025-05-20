using AcunMedya.Cafe.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Cafe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {

        private readonly CafeContext _context;

        public DashboardController(CafeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {


            ViewBag.V1 = _context.Products.Count();
            ViewBag.V2 = _context.Categories.Count();
            ViewBag.V3 = _context.Testimonials.Count();
            var categoryData = _context.Categories
      .Select(c => new
      {
          CategoryName = c.CategoryName,
          ProductCount = c.Products.Count()
      }).ToList();

            ViewBag.CategoryLabels = categoryData.Select(c => c.CategoryName).ToList();
            ViewBag.CategoryValues = categoryData.Select(c => c.ProductCount).ToList();


            return View();
        }



        public PartialViewResult Testimonials()
        {
          
            return PartialView();
        }

    }
}
