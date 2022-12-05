using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class ToDo
    {
        // Things that define what toDo item is
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }

        // Reference to the user
        public virtual ApplicationUser User { get; set; }
        // ApplicationUser is class that defines a user in this framework
    }
}