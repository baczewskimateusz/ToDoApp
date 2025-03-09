using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    public class Task
    {
        public string Name { get; }
        public string Username { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        
        public string Description { get; }  
        public bool IsCompleted { get; }

        TimeSpan TimeRemaining => EndTime.Subtract(StartTime);

        public Task(string name, string username, DateTime startTime, DateTime endTime, bool isCompleted, string description)
        {
            Name = name;
            Username = username;
            StartTime = startTime;
            EndTime = endTime;
            IsCompleted = isCompleted;
            Description = description;
        }


    }
}
