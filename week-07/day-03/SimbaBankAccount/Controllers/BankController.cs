using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimbaBankAccount.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimbaBankAccount.Controllers
{
    public class BankController : Controller
    {
        [Route("Simba")]
        public IActionResult Simba()
        {
            var accounts = new List<BankAccount>();

            accounts.Add(new BankAccount() { Name = "Simba", Balance = 2000.00, AnimalType = "Lion", IsKing = true });

            return View(accounts);
        }
    }
}
