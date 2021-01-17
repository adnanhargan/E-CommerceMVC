using E_CommerceMVC.Data;
using E_CommerceMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceMVC.Services
{
    public class CategoryService
    {
        public bool SaveCategry(Category category)
        {
            ECommerceDataContext context = new ECommerceDataContext();

            context.Categories.Add(category);
            return context.SaveChanges() > 0;
        }
        public List<Category> GetAllCategories()
        {
            ECommerceDataContext context = new ECommerceDataContext();
            return context.Categories.ToList();
        }
    }
}
