using AdminProject.Entities;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace AdminProject.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<UserTask> UserTasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) 
            : base(options)
        {
        }
    }
}
