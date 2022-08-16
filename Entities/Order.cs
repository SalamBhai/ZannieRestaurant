using user.Desktop.Cakes_N_Treats_By_Zannie.Entities;
using System.Collections.Generic;
using System;
using Cakes_N_Treats_By_Zannie.Enums;

namespace Cakes_N_Treats_By_Zannie.Entities
{
    public class Order
    {
        public int Id {get;set;} 
        public string OrderReference{get;set;}
        public decimal OrderPrice{get;set;}
        public int TotalOrderQuantityOnAChosenTreat{get;set;}
        public DateTime DeliveryDate{get;set;}
        public DateTime DateOfOrder{get;set;}
        public ICollection<TreatOrders> TreatOrders {get;set;}= new List<TreatOrders>();
        public int UserId{get;set;}
        public User User {get;set;}
        public OrderStatus OrderStatus{get;set;}
        public bool PaymentPaid {get;set;}
        public int? DeliveryId{get;set;}
        public Delivery Delivery{get;set;}
        public string DeliveryAddress{get;set;}
    
    }
}