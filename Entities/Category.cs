using System;
using System.Collections.Generic;
using Cakes_N_Treats_By_Zannie.Models;
using user.Desktop.Cakes_N_Treats_By_Zannie.Entities;

namespace Cakes_N_Treats_By_Zannie.Entities
{
    public class Category
    {
      public int Id{get;set;}  
      public string CategoryName{get;set;} 
      public DateTime DateOfCreation{get;set;}
      public string Description{get;set;}
      public IEnumerable<Treat> Treats {get;set;} = new List<Treat>();
    }
}