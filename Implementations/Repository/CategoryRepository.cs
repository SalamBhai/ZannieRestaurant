using System.Collections.Generic;
using System.Linq;
using Cakes_N_Treats_By_Zannie.Context;
using Cakes_N_Treats_By_Zannie.Entities;
using Cakes_N_Treats_By_Zannie.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Cakes_N_Treats_By_Zannie.Implementations.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ZannieContext _zannie;
        public CategoryRepository(ZannieContext zannie)
        {
            _zannie= zannie;
        }
        public Category CreateCategory(Category category)
        {
            _zannie.Categories.Add(category);
            _zannie.SaveChanges();
            return category;
        }
       public Category UpdateCategory(Category category)
       {
           _zannie.Categories.Update(category);
           _zannie.SaveChanges();
           return category;
       }
       public void DeleteCategory(Category category)
       {
           _zannie.Categories.Remove(category);
           _zannie.SaveChanges();
       }
       public Category GetCategory(int id)
       {
          var thecategory= _zannie.Categories.Include(L=>L.Treats).SingleOrDefault(th=>th.Id==id);
          return thecategory;
       }
       public IEnumerable<Category> GetCategories()
       {
           var Categories = _zannie.Categories.Include(L=> L.Treats).ToList();
           return Categories;
       }


        public bool GetCategory(int id, string name)
        {
            return _zannie.Categories.Any(L=> L.Id==id && L.CategoryName==name);
        }
    }
}