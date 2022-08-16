using  Cakes_N_Treats_By_Zannie.Entities;
using System.Collections.Generic;
using Cakes_N_Treats_By_Zannie.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Cakes_N_Treats_By_Zannie.Implementations.Repository
{
    public class DeliveryRepository
    {
       private readonly ZannieContext _zannie;
        public DeliveryRepository(ZannieContext zannie)
        {
            _zannie = zannie;
        }
        public Delivery CreateDelivery(Delivery delivery)
        {
            _zannie.Deliveries.Add(delivery);
            _zannie.SaveChanges();
            return delivery;
        }
    
       public Delivery GetDelivery(int id)
       {
          var theDelivery= _zannie.Deliveries.Include(L=>L.Orders).SingleOrDefault(th=>th.Id==id);
          return theDelivery;
       }
       public IEnumerable<Delivery> GetDeliveries()
       {
           var Deliveries= _zannie.Deliveries.Include(L=> L.Orders).ToList();
           return Deliveries;
       }
        
    }
}