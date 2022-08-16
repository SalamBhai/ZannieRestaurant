using Cakes_N_Treats_By_Zannie.Entities;
using System.Collections.Generic;
using System;
using Cakes_N_Treats_By_Zannie.Enums;
namespace Cakes_N_Treats_By_Zannie.Models
{
    public class ViewDeliveryRequestModel
    {
        public int Id{get;set;}
        public DateTime DeliveryDate{get;set;}
        public List<Order> Orders{get;set;}
        public int DispatchRiderId{get;set;}
        public string DispatchRiderName{get;set;}
        public DeliveryStatus DeliveryStatus{get;set;}
        public string DeliveryAddress{get;set;}
    }
}