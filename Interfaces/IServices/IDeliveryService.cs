using System.Collections.Generic;
using Cakes_N_Treats_By_Zannie.Models;
namespace Cakes_N_Treats_By_Zannie.Interfaces.IServices
{
    public interface IDeliveryService
    {
           public bool CreateDelivery(CreateDeliveryRequestModel model);
         public ViewDeliveryRequestModel GetDelivery(int id);
         public IEnumerable<ViewDeliveryRequestModel> GetDeliveries();
         public IEnumerable<ViewDeliveryRequestModel> GetDeliveriesByADispatcher();
    }
}