 using user.Desktop.Cakes_N_Treats_By_Zannie.Entities;
namespace Cakes_N_Treats_By_Zannie.Entities
{
    public class TreatOrders
    {
        public int Id{get;set;}
        public int TreatId{get;set;}
        public Treat Treat {get;set;}
        public int OrderID{get;set;}
        public Order Order {get;set;}
        public decimal UnitPrice{get;set;}
        public int UnitQuantity{get;set;}
    }
}