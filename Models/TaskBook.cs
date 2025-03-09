using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    public class TaskBook
    {
        private readonly List<Task> _tasks;

        public TaskBook()
        {
            _tasks = new List<Task>();  
        }

        // public IEnumerable<Task> GetTasksForUsername(string username)
        //{

        //}
    }
}
