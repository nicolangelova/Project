using Microsoft.AspNetCore.Mvc;

namespace Expense_Tracker.Controllers
{
    public class BankAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
