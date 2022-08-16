using System;
using System.Collections.Generic;
using Cakes_N_Treats_By_Zannie.Entities;
using Cakes_N_Treats_By_Zannie.Enums;
namespace Cakes_N_Treats_By_Zannie.Models
{
    public class ViewOrderRequestModel
    {
       public decimal OrderPrice{get;set;} 
       public int QuantityOfTreats{get;set;}
       public string OrderReference {get;set;}
       public string CustomerName{get;set;}
       public string CustomerAddress{get;set;}
       public DateTime DeliveryDate{get;set;}
       public DateTime OrderDate{get;set;}
       public int Id{get;set;}
       public List<ViewTreatRequestModel> Treats {get;set;} = new List<ViewTreatRequestModel>();
       public string TreatName{get;set;}
       public string TreatPrice{get;set;}
       public int NumberofTreatsInPack{get;set;}
       public int TreatsContainedInOrder{get;set;}
       public int CustomerId{get;set;}
       public OrderStatus OrderStatus{get;set;}
      public string DeliveryAddress{get;set;}
    }
}