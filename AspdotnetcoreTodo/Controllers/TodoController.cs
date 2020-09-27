using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspdotnetcoreTodo.Services;
using AspdotnetcoreTodo.Models;

namespace AspdotnetcoreTodo.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }
     
         public async Task<IActionResult> Index()
         {

             var items = await _todoItemService.GetIncompleteItemsAsync();  
             
             var model = new TodoViewModel()
             {
                  items = items
             };

             return View(model);
             
             // Get to-do items from database
             // put itetms into a model
             // render view using the model
         }
    }
}
