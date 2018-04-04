using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimbaBankAccount.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimbaBankAccount.Controllers
{
    [Route("accounts")]
    public class BankController : Controller
    {
        [Route("simba")]
        public IActionResult Simba()
        {
            return View();
        }

        [HttpGet]
        [Route("all")]
        public IActionResult All()
        {
            return View(BankAccountList.Accounts);
        }

        [HttpPost]
        [Route("add")]
        public IActionResult All(int index)
        {
            var bank = new BankAccountList();

            if (BankAccountList.Accounts[index - 1].IsKing)
            {
                BankAccountList.Accounts[index - 1].Balance += 100;
            }
            else
            {
                BankAccountList.Accounts[index - 1].Balance += 10;
            }
            return View(BankAccountList.Accounts);
        }
    }
}
