using Microsoft.AspNetCore.Mvc;
using SpendSmart.Models;
using System.Diagnostics;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
 

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
       
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult SignUp()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }

    //public IActionResult Expenses()
    //{
    //    var allExpenses = _context.Expenses.ToList();
    //    return View(allExpenses);
    //}

    //[HttpGet]
    //public IActionResult CreateEditExpense(int? id)
    //{
    //    if (id != null)
    //    {
          
    //        var expenseInDb = _context.Expenses.SingleOrDefault(x => x.Id == id);

    //        if (expenseInDb == null)
    //        {
    //            return NotFound();
    //        }

           
    //        return View(expenseInDb);
    //    }

       
    //    return View();
    //}
    //[HttpPost]
    //public IActionResult Login(UserAccount model)
    //{


    //    return RedirectToAction("UserDashboard"); 

       
    //}


    //public IActionResult DeleteExpense(int? id)
    //{
    //    if (id != null)
    //    {
    //        var expenseInDb = _context.Expenses.SingleOrDefault(x => x.Id == id);
    //        if (expenseInDb != null)
    //        {
    //            _context.Expenses.Remove(expenseInDb);
    //            _context.SaveChanges();
    //        }
    //    }
    //    return RedirectToAction("Expenses");
    //}

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
