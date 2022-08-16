using Cakes_N_Treats_By_Zannie.Entities;
using Cakes_N_Treats_By_Zannie.Interfaces.IRepositories;
using Cakes_N_Treats_By_Zannie.Interfaces.IServices;
using Cakes_N_Treats_By_Zannie.Models;
using System.Collections.Generic;
using System.Linq;
using user.Desktop.Cakes_N_Treats_By_Zannie.Entities;
namespace Cakes_N_Treats_By_Zannie.Implementations.Services
{
    public class CategoryService :ICategoryService
    {
        private readonly ICategoryRepository CategoryRepo;
        public CategoryService(ICategoryRepository categoryrepo)
        {
            CategoryRepo=categoryrepo;
        }
         public bool CreateCategory(CreateCategoryRequestModel model)
         {
             var category = new Category
             {
                 CategoryName= model.CategoryName,
                 DateOfCreation=model.DateOfCreation,  
                 Description=model.Description,
             };
             CategoryRepo.CreateCategory(category);
             return true;
         }
        public void DeleteCategory(int id)
        {
            var categorytodelete= CategoryRepo.GetCategory(id);
            if(categorytodelete==null)
            {
                System.Console.WriteLine("Error!Category Not  Found");
            }
            CategoryRepo.DeleteCategory(categorytodelete);
        }
        public bool UpdateCategory(int id, UpdateCategoryRequestModel model)
        {
            var categorytoupdate= CategoryRepo.GetCategory(id);
            categorytoupdate.CategoryName= model.CategoryName;
            categorytoupdate.DateOfCreation= model.DateOfCreation;
            CategoryRepo.UpdateCategory(categorytoupdate);
            return true;
        }
        public ViewCategoryRequestModel GetCategoryById(int id)
        {
            var Categorytosee= CategoryRepo.GetCategory(id);
            return new ViewCategoryRequestModel
            {
                id=Categorytosee.Id,
              CategoryName= Categorytosee.CategoryName,
               Description= Categorytosee.Description,
              NumberOfTreatsInCategory= Categorytosee.Treats.Count(),
              DateOfCreation=Categorytosee.DateOfCreation,
              TreatNames= Categorytosee.Treats.Select(treat=> new ViewTreatRequestModel
              {
                 Name=treat.Name,
                 id= treat.Id,
              }).ToList(),
            };
        }
        public IEnumerable<ViewCategoryRequestModel> GetCategories()
        {
            return CategoryRepo.GetCategories().Select(Lin=> new ViewCategoryRequestModel
            {
                id= Lin.Id,
               CategoryName= Lin.CategoryName,
               Description=Lin.Description,
               DateOfCreation=Lin.DateOfCreation,
            }).ToList();
        }
        public bool FindTreatExistenceByName(int id,string name)
        {
            var ifcatexists= CategoryRepo.GetCategory(id,name);
            return ifcatexists;
        }
    }
}