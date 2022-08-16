
namespace  Cakes_N_Treats_By_Zannie.Models
{
    public class ViewTreatRequestModel
    {
        public int id{get;set;}
        public string Name {get;set;}
        public decimal TreatPrice{get;set;}
        public string CategoryName{get;set;}
         public int NumberofTreatsInPack {get;set;}
         public int CategoryId{get;set;}
         public string TreatPhoto{get;set;}
         public string TreatDescription{get;set;}

    }
}