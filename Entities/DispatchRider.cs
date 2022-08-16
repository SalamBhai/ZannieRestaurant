using System.Collections.Generic;
namespace Cakes_N_Treats_By_Zannie.Entities
{
    public class DispatchRider: User
    {
        public List<Delivery> Deliveries{get;set;}
    }
}