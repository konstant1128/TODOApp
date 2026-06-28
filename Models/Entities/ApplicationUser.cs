using System; 
using Microsoft.AspNetCore.Identity;

namespace TodoApp.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName {get; set;}

        public ICollection<TaskItem> Tasks {get; set;} = new List<TaskItem> ();
    }
}