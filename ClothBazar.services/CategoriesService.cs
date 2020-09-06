using ClothBazar.Database;
using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.services
{
public  class CategoriesService
    {
        public void SaveCategory(Category Category)
        {
            using (var context = new CBContext())
            {
                context.Categories.Add(Category);
                context.SaveChanges(); 
            }
          }

        public void EditCategory(Category Category)
        {
            using (var context = new CBContext())
            {
                context.Entry(Category).State=System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void deleteCategory(int  id)
        {
            using (var context = new CBContext())
            {
                //    context.Entry(Category).State = System.Data.Entity.EntityState.Deleted;
                var category = context.Categories.Find(id);
                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }
        public List<Category> GetCategories()
        {
            using (var context = new CBContext())
            {
                return context.Categories.ToList();
            }
        }

        public Category GetCategory(int id)
        {
            using (var context = new CBContext())
            {
                return context.Categories.Find(id);
            }
        }
    }
}
