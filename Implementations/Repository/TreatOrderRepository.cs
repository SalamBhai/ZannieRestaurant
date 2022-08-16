using Cakes_N_Treats_By_Zannie.Context;
using Cakes_N_Treats_By_Zannie.Interfaces.IRepositories;
using System.Linq;
using Cakes_N_Treats_By_Zannie.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using user.Desktop.Cakes_N_Treats_By_Zannie.Entities;
namespace Cakes_N_Treats_By_Zannie.Implementations.Repository
{
    public class TreatOrderRepository : ITreatOrderRepository
    {
        private readonly ZannieContext _zannieContext;
        public TreatOrderRepository(ZannieContext zannieContext)
        {
            _zannieContext=zannieContext;
        }

        // public List<TreatOrders> GetTreatsOrderedForThisOrderId(int orderId)
        // {
        //    return _zannieContext.TreatOrders.Include(L=> L.Treat).Where(L=> L.OrderID == orderId).ToList();
        // }
          public int GetTreatsCountByOrderID(int orderId)
        {
            return _zannieContext.TreatOrders.Where(L=> L.OrderID==orderId).Count();
        }

          public List<TreatOrders> GetTreatsByOrderID(int orderId)
         {
          return  _zannieContext.TreatOrders.Include(L=> L.Treat).Where(L=> L.OrderID==orderId).ToList();
         }
    }
}