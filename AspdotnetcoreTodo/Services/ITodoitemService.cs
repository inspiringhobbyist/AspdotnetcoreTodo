using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspdotnetcoreTodo.Models;

namespace AspdotnetcoreTodo.Services
{
     public interface ITodoItemService
     {
          Task<Todoitem[]> GetIncompleteItemsAsync();
     }
}