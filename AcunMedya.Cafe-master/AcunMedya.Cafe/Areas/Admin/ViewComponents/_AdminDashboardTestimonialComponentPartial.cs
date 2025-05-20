using AcunMedya.Cafe.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Cafe.Areas.Admin.ViewComponents
{
    public class _AdminDashboardTestimonialComponentPartial : ViewComponent
    {
        private readonly CafeContext _context;

        public _AdminDashboardTestimonialComponentPartial(CafeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var value = _context.Testimonials.ToList();
            return View(value);
        }
    }
}
