using System.Collections.Generic;
using Cakes_N_Treats_By_Zannie.Models;

namespace Cakes_N_Treats_By_Zannie.Interfaces.IServices
{
    public interface ICategoryService
    {
         public bool CreateCategory(CreateCategoryRequestModel model);
        
        public IEnumerable<ViewCategoryRequestModel> GetCategories();
        public  ViewCategoryRequestModel GetCategoryById(int id);
       public void DeleteCategory(int id);
       public bool UpdateCategory(int id, UpdateCategoryRequestModel model);
    }
}