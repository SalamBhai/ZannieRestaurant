using System.Collections.Generic;
using Cakes_N_Treats_By_Zannie.Models;
using System;
using Cakes_N_Treats_By_Zannie.Entities;
namespace user.Desktop.Cakes_N_Treats_By_Zannie.Entities
{
    public class Treat
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public decimal TreatPrice {get;set;}
        public DateTime DateofTreatregistration {get;set;}
        public  ICollection<TreatOrders> TreatOrders{get;set;}= new List<TreatOrders>();
        public int CategoryId{get;set;}
        public Category Category{get;set;}
        public string TreatPhoto{get;set;}
        public int NumberofTreatsInPack{get;set;}
        public List<Comment> Comments {get;set;}
        public string TreatDescription{get;set;}
    }
}