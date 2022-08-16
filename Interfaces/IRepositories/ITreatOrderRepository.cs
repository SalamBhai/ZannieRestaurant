using System.Collections.Generic;
using Cakes_N_Treats_By_Zannie.Entities;
using user.Desktop.Cakes_N_Treats_By_Zannie.Entities;
namespace Cakes_N_Treats_By_Zannie.Interfaces.IRepositories
{
    public interface ITreatOrderRepository
    {
        // public List<TreatOrders> GetTreatsOrderedForThisOrderId(int orderid);
        public int GetTreatsCountByOrderID(int id);
        public List<TreatOrders> GetTreatsByOrderID(int id);


    }
    
}