using System;
using System.Collections.Generic;
using Cakes_N_Treats_By_Zannie.Models;
using Cakes_N_Treats_By_Zannie.Enums;
namespace Cakes_N_Treats_By_Zannie.Entities
{
    public class Delivery
    {
        public int Id{get;set;}
        public DateTime DeliveryDate{get;set;}
        public List<Order> Orders{get;set;}
        public int DispatchRiderId{get;set;}
        public DispatchRider DispatchRider{get;set;}
        public decimal DeliveryCost{get;set;}
        public decimal TotalAccumulatedPrice{get;set;}
        public DeliveryStatus DeliveryStatus{get;set;}
    }
}