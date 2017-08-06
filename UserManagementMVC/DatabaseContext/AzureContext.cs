using System.Data.Entity;
using UserManagementMVC.Models;

namespace UserManagementMVC.DatabaseContext
{
    public class AzureContext : DbContext
    {
        public AzureContext() : base("name=DefaultConnection") { }

        public DbSet<User> User { get; set; }
    }
}