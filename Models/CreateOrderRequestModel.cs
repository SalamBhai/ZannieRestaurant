using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Cakes_N_Treats_By_Zannie.Entities;
using user.Desktop.Cakes_N_Treats_By_Zannie.Entities;
using static System.ComponentModel.DisplayNameAttribute;
namespace Cakes_N_Treats_By_Zannie.Models
{
    public class CreateOrderRequestModel
    {
        [Required(ErrorMessage= "Fill In This Essential Field")]
        [DisplayName("Your Preferred Date Of Delivery")]
        [DataType(DataType.DateTime)]
        public DateTime DeliveryDate{get;set;}
        [Required(ErrorMessage ="Select What Item You Are Ordering From The List")]
        public List<Cart> Treats {get;set;}= new List<Cart>();
        [Required(ErrorMessage ="Required! Fill In This Form")]
        public int NumberOfQuantities{get;set;}
        public string DeliveryAddress{get;set;}
        public int CustomerId{get;set;}
        public Treat Treat{ get; set; }
        public int id{get;set;}
        public int Userid{get;set;}
    }
}