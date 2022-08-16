using System.Collections.Generic;
using Cakes_N_Treats_By_Zannie.Entities;
using Cakes_N_Treats_By_Zannie.Entities.Enums;
using Cakes_N_Treats_By_Zannie.Enums;
namespace Cakes_N_Treats_By_Zannie.Models
{
    public class ViewUserRequestModel
    {
        public int Id{get;set;}
        public string FullName{get;set;}
         public string EmailAddress{get;set;}
         public string CustomerAddress{get;set;}
         public string PhoneNumber{get;set;}
         public string UserPhoto{get;set;}
         public List<ViewOrderRequestModel> Orders {get;set;}= new List<ViewOrderRequestModel>();
         public string Role{get;set;}
         public UserType UserType{get;set;}
         public Gender Gender{get;set;}
         public string ConfirmPassword{get;set;}
    }
}