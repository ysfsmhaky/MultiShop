using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Presistence.Context
{
    public class OrderContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =localhost,1440;initial Catalog =MultiShopOrderDb;User=sa;Password=Gncfb1907.");
        }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<OrderDetail> OrderDetails  { get; set; }
        public DbSet<Ordering> Orderings  { get; set; }
    }
}
