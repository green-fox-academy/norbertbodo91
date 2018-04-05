using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoWebbApp.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoWebbApp.Controllers
{
    public class ToDoController : Controller
    {
        IToDo toDo;

        public ToDoController(IToDo todo)
        {
            toDo = todo;
        }

        [Route("Todo")]
        [HttpGet]
        public IActionResult Todo()
        {
            return View(toDo);
        }
        [Route("Create")]
        [HttpPost]
        public IActionResult Todo(string taskName)
        {
            toDo.Create(taskName);
            return View(toDo);
        }
        [Route("Delete")]
        public IActionResult Todo(int taskIndex)
        {
            toDo.Delete(taskIndex);
            return View(toDo);
        }
    }
}
