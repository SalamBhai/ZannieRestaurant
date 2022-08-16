using System.Collections.Generic;
using Cakes_N_Treats_By_Zannie.Models;
namespace Cakes_N_Treats_By_Zannie.Interfaces.IServices
{
    public interface  ITreatService
    {
       public bool CreateTreatRequest(CreateTreatRequestModel model);
       public bool UpdateTreat(int id,UpdateTreatRequestModel model);
       public ViewTreatRequestModel GetTreatRequest(int id);
       public IEnumerable<ViewTreatRequestModel> GetTreats();
       public bool DeleteTreat(int id);
       public bool FindExistenceoftreatbyname(string name);
       
        public IList<ViewTreatRequestModel> SearchTreats(string searchText);
       
    }
}