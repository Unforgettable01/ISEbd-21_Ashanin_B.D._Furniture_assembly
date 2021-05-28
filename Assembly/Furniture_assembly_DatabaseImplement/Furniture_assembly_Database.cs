using Furniture_assembly_DatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace Furniture_assembly_DatabaseImplement
{
   public class Furniture_assembly_Database: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;
                                           Initial Catalog=FurnitureAssemblyDatabaseComplicated;
                                           Integrated Security=True;
                                           MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Component> Components { set; get; }
        public virtual DbSet<Furniture> Furnitures { set; get; }
        public virtual DbSet<FurnitureComponent> FurnitureComponents { set; get; }
        public virtual DbSet<Order> Orders { set; get; }
        public virtual DbSet<StoreHouse> StoreHouses { set; get; }
        public virtual DbSet<StoreHouseComponent> StoreHouseComponents { set; get; }
    }
}
