using System.Collections.Generic;
using Cakes_N_Treats_By_Zannie.Entities;
using user.Desktop.Cakes_N_Treats_By_Zannie.Entities;
using Microsoft.AspNetCore.Mvc;
using Cakes_N_Treats_By_Zannie.Models;
using System.Linq.Expressions;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Cakes_N_Treats_By_Zannie.Interfaces.IRepositories
{
    public interface ITreatRepository
    {
      public Treat CreateTreat(Treat treat);
      public void DeleteTreat(Treat treat);
      public Treat UpdateTreat(Treat treat);
      public Treat GetTreat(int id);
      public IEnumerable<Treat> GetTreats();
      public bool FindTreatByName(string Name);
      public List<Treat> GetChosenTreats(List<int> ids);
       public IQueryable<Treat> Query();
       public IList<ViewTreatRequestModel> SearchTreats(string SearchText);
    }
}