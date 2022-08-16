using System.Collections.Generic;
using Cakes_N_Treats_By_Zannie.Entities;

namespace Cakes_N_Treats_By_Zannie.Interfaces.IRepositories
{
    public interface ICategoryRepository
    {
       public Category CreateCategory(Category category);
       public Category UpdateCategory(Category category);
       public void DeleteCategory(Category category);
       public Category GetCategory(int id);
       public IEnumerable<Category> GetCategories();
       public bool GetCategory(int id, string name);
    }
}