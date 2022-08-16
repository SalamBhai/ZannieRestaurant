using Cakes_N_Treats_By_Zannie.Enums;
using Cakes_N_Treats_By_Zannie.Entities;
namespace Cakes_N_Treats_By_Zannie.Models
{
    public class CreateDeliveryRequestModel
    {
        public int DispatchRiderId{get;set;}
        public DispatchRider DispatchRider{get;set;}
        public decimal DeliveryCost{get;set;}
        public DeliveryStatus DeliveryStatus{get;set;}
        public string DeliveryAddress{get;set;}
    }
}