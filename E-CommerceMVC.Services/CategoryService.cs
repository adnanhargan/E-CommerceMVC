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
        public Category GetCategoryById(int ID)
        {
            ECommerceDataContext context = new ECommerceDataContext();
            return context.Categories.Find(ID);
        }
        public bool UpdateCategory(Category category)
        {
            ECommerceDataContext context = new ECommerceDataContext();
            var dbcategory = context.Categories.Find(category.ID);
            if(dbcategory != null)
            {
                dbcategory.Name = category.Name;
                dbcategory.Description = category.Description;
            }
            context.Entry(dbcategory).State = System.Data.Entity.EntityState.Modified;
            return context.SaveChanges() > 0;
        }

        public bool DeleteCategory(int CategoryID)
        {
            ECommerceDataContext context = new ECommerceDataContext();
            var dbcategory = context.Categories.Find(CategoryID);
            if (dbcategory != null)
            context.Entry(dbcategory).State = System.Data.Entity.EntityState.Deleted;
            return context.SaveChanges() > 0;
        }
    }
}
