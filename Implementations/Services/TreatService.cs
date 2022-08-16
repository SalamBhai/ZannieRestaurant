using System;
using System.Collections.Generic;
using System.Linq;
using Cakes_N_Treats_By_Zannie.Entities;
using Cakes_N_Treats_By_Zannie.Interfaces.IRepositories;
using Cakes_N_Treats_By_Zannie.Interfaces.IServices;
using Cakes_N_Treats_By_Zannie.Models;
using user.Desktop.Cakes_N_Treats_By_Zannie.Entities;

namespace Cakes_N_Treats_By_Zannie.Implementations.Services
{
    public class TreatService :ITreatService
    {
        private readonly ITreatRepository TreatRepo;
        public TreatService(ITreatRepository treatrepo)
        {
            TreatRepo=treatrepo;
        }
        
        public bool CreateTreatRequest(CreateTreatRequestModel model)
        {
            var treat= new Treat
            {
               Name= model.Name,
               TreatPrice=model.Price,
               CategoryId=model.CategoryId,
               DateofTreatregistration= DateTime.Now,
               TreatPhoto=model.TreatPhoto,
               NumberofTreatsInPack=NumberofTreatsInPackDecision(model),
                TreatDescription= model.TreatDescription,
            };
            TreatRepo.CreateTreat(treat);
            return true;
        }
        private int NumberofTreatsInPackDecision(CreateTreatRequestModel model)
        {
            int NumberofTreatsInPack=1;
            if(model.TypeOfTreatPack ==Enums.TreatPackType.NotPacked)
            {
                model.NumberofTreatsInPack= (int)Enums.TreatPackType.NotPacked;
            }
            else if (model.TypeOfTreatPack==Enums.TreatPackType.Packed)
            {
                NumberofTreatsInPack=model.NumberofTreatsInPack;
            }
            return NumberofTreatsInPack;
        }
       public bool UpdateTreat(int id,UpdateTreatRequestModel model)
       {
           var treattoupdate= TreatRepo.GetTreat(id);
           if(treattoupdate==null)
           {
               throw new Exception("Not Found!");
           }
              treattoupdate.TreatPrice= model.Price;
               treattoupdate.Name= model.Name;
           TreatRepo.UpdateTreat(treattoupdate);
           return true;
       }

       public ViewTreatRequestModel GetTreatRequest(int id)
       {
           var treatfound= TreatRepo.GetTreat(id);
           var treatmodel= new ViewTreatRequestModel
           {
               id= treatfound.Id,
               Name= treatfound.Name,
               TreatPrice= treatfound.TreatPrice,
               CategoryName= treatfound.Category.CategoryName,
               TreatPhoto=treatfound.TreatPhoto,
               TreatDescription=treatfound.TreatDescription,
           };
           return treatmodel;
       }
       public IEnumerable<ViewTreatRequestModel> GetTreats()
       {
           return TreatRepo.GetTreats().Select(Treat=> new ViewTreatRequestModel
           {
               id=Treat.Id,
                Name=Treat.Name,
                TreatPrice=  Treat.TreatPrice,
                CategoryName= Treat.Category.CategoryName,
                TreatPhoto=Treat.TreatPhoto,
                TreatDescription=Treat.TreatDescription,
           }).ToList();
           
       }

       public bool DeleteTreat(int id)
       {
           var treattodelete= TreatRepo.GetTreat(id);
           TreatRepo.DeleteTreat(treattodelete);
           return true;
       }
       public bool FindExistenceoftreatbyname(string name)
       {
           var treatchecked= TreatRepo.FindTreatByName(name);
           if(treatchecked==true)
           {
               return treatchecked;
           }
           return treatchecked;
       }
       
       public IList<ViewTreatRequestModel> SearchTreats(string SearchText)
       {
           return TreatRepo.SearchTreats(SearchText).ToList();
       }
    }
}