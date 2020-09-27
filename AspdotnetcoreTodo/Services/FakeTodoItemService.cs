using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspdotnetcoreTodo.Models;

namespace AspdotnetcoreTodo.Services
{
    public class FakeTodoItemService : ITodoItemService
    {
         public Task<Todoitem[]> GetIncompleteItemAsync()
         {
             var item1 = new Todoitem
             {
                  Title = "Learn ASP .NET Core", 
                  DueAt = DateTimeOffset.Now.AddDays(1)
                
             };

             var item2 = new Todoitem
             {
                    Title = "Build awesome apps",
                    DueAt = DateTimeOffset.Now.AddDays(2)

             };
             
             return Task.FromResult(new[] { item1, item2});
         }
    }
}