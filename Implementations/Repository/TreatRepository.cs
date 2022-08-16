using System.Collections.Generic;
using System.Linq;
using Cakes_N_Treats_By_Zannie.Context;
using Cakes_N_Treats_By_Zannie.Entities;
using Cakes_N_Treats_By_Zannie.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;
using user.Desktop.Cakes_N_Treats_By_Zannie.Entities;
using Microsoft.AspNetCore.Mvc;
using Cakes_N_Treats_By_Zannie.Models;
using System.Linq.Expressions;
using System.Threading.Tasks;
namespace Cakes_N_Treats_By_Zannie.Implementations.Repository
{
    public class TreatRepository : ITreatRepository
    {
        private readonly ZannieContext _zanniecontext;


        public TreatRepository(ZannieContext context)
        {
            _zanniecontext = context;
        }
        
        public bool FindTreatByName(string Name)
        {
            return _zanniecontext.Treats.Any(Treat => Treat.Name == Name);
        }

        public Treat CreateTreat(Treat treat)
        {
            _zanniecontext.Treats.Add(treat);
            _zanniecontext.SaveChanges();
            return treat;
        }

        public void DeleteTreat(Treat treat)
        {
             _zanniecontext.Treats.Remove(treat);
            _zanniecontext.SaveChanges();
        }

        public Treat UpdateTreat(Treat treat)
        {
            _zanniecontext.Treats.Update(treat);
            _zanniecontext.SaveChanges();
            return treat;
        }

        public Treat GetTreat(int id)
        {
            var treatfound = _zanniecontext.Treats.Include(t=>t.Category).SingleOrDefault(L=>L.Id==id);
            return treatfound;
   
        }

         public IEnumerable<Treat> GetTreats()
        {
            return _zanniecontext.Treats.Include(T=>T.Category).ToList();
        }

        public List<Treat> GetChosenTreats(List<int> ids)
        {
            return  _zanniecontext.Treats.Where(treat=> ids.Contains(treat.Id)).ToList();
        }
          public IQueryable<Treat> Query()
        {
            return _zanniecontext.Treats.AsQueryable();
        }
        public IList<ViewTreatRequestModel> SearchTreats(string SearchText)
        {
            return _zanniecontext.Treats.Where(treat=> EF.Functions.Like(treat.Name, $"%{SearchText}%")).Select(treat=> new ViewTreatRequestModel
            {
               id=treat.Id,
              Name=treat.Name,
               TreatPrice=treat.TreatPrice,
              CategoryName=treat.Category.CategoryName,
              NumberofTreatsInPack=treat.NumberofTreatsInPack,
               CategoryId=treat.CategoryId,
                TreatPhoto=treat.TreatPhoto,
              TreatDescription=treat.TreatDescription,
            }).ToList();
        }

    }
}