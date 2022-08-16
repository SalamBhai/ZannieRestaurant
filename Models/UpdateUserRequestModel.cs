using System.ComponentModel.DataAnnotations;
using Cakes_N_Treats_By_Zannie.Entities.Enums;
using Cakes_N_Treats_By_Zannie.Enums;
namespace Cakes_N_Treats_By_Zannie.Models
{
    public class UpdateUserRequestModel
    {
        [Required(ErrorMessage= "Fill in this field it is essential!")]

         public string PhoneNumber{get;set;}
         [Required(ErrorMessage= "Fill in this field it is essential!")]

         public string EmailAddress{get;set;}
         [Required(ErrorMessage= "Fill in this field it is essential!")]

         public string Address{get;set;}
         [Display()]
         [Required(ErrorMessage= "Fill in this field it is essential!")]
         public string FirstName{get;set;}
         [Required(ErrorMessage= "Fill in this field it is essential!")]
          
         public string LastName{get;set;}
         [Required(ErrorMessage= "Fill in this field it is essential!")]
          [Compare("Password", ErrorMessage ="Invalid Submission")]
         public string ConfirmPassword{get;set;}
         [Required(ErrorMessage ="Please make submission")]
           public string Password{get;set;}
           public UserType UserType{get;set;}
    }
}