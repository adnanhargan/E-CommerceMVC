using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_CommerceMVC.Entities;

namespace E_CommerceMVC.Data
{
    public class ECommerceDataContext : DbContext
    {
        public ECommerceDataContext() : base("name=ECommerceDbConnection")
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
