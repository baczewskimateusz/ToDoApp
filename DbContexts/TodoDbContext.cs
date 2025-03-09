using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoApp.Models;
using Task = TodoApp.Models.Task;

namespace TodoApp.DbContexts
{
    public class TodoDbContext : DbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Task> Tasks { get; set; } 
    }
}
