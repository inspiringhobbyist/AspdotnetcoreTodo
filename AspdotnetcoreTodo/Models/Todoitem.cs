using System;
using System.ComponentModel.DataAnnotations;

namespace AspdotnetcoreTodo.Models
{
     public class Todoitem
     {
         public Guid Id { get; set; }

         public bool IsDone { get; set; }

         [Required]

         public string Title {get; set; }

         public DateTimeOffset? Dueat { get;set; }
         
     }
}