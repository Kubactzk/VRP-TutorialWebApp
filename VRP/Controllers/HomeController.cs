using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VRP.Data;
using VRP.Models;
using VRP.ViewModels;

namespace VRP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Customers()
        {
            var allData = _context.Customers.ToList();
            CustomerVM model = new CustomerVM();
            model.Customers = allData;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Customers(CustomerVM model)
        {
            if (ModelState.IsValid)
            {
                await  _context.AddAsync(model.Customer);
                await _context.SaveChangesAsync();

                model.Customers = _context.Customers.ToList();
                return View(model);
            }

            model.Customers = _context.Customers.ToList();
            return View(model);
            /*return PartialView("_CustomerFormPartial", model);*/
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
