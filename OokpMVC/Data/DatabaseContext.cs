using System.Data.Entity;
using OokpMVC.Models;

namespace OokpMVC.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base(@"data source = KIRI-ENVY\SQLEXPRESS; initial catalog =PlateShop; trusted_connection=true") //Строка підключення
        { }
        public DbSet<AdminModel> Admin { get; set; }
        public DbSet<StuffModel> Stuff { get; set; }
    }
}
