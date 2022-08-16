using System.Collections.Generic;
using Cakes_N_Treats_By_Zannie.Entities.Enums;
using Cakes_N_Treats_By_Zannie.Enums;
namespace Cakes_N_Treats_By_Zannie.Entities
{
    public class User
    {
         public int Id{get;set;}
         public string FirstName{get;set;}
          public string LastName{get;set;}
         public string EmailAddress{get;set;}
         public string UserAddress{get;set;}
         public string PhoneNumber{get;set;}
         public string UserPhoto{get;set;}
         public string Password{get;set;}
         public List<Order> Orders {get;set;}= new List<Order>();
         public UserType UserType{get;set;}
         public Gender Gender{get;set;}
         public List<Comment> Comments{get;set;}

    }
}