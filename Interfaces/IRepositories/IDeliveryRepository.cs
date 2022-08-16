using Cakes_N_Treats_By_Zannie.Entities;
using System.Collections.Generic;
namespace Cakes_N_Treats_By_Zannie.Interfaces.IRepositories
{
    public interface IDeliveryRepository
    {
          public Delivery CreateDelivery(Delivery delivery);
         public Delivery GetDelivery(int id);
         public IEnumerable<Delivery> GetDeliveries();
          public User GetDispatchRider(int id);
    }
}