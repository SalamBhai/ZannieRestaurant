using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Cakes_N_Treats_By_Zannie.Entities.Enums;
using Cakes_N_Treats_By_Zannie.Enums;
namespace Cakes_N_Treats_By_Zannie.Models
{
    public class CreateUserRequestModel
    {
        
         [Required(ErrorMessage= "Fill in this field it is essential!")]
         [DisplayName(" First Name")]
         public string FirstName{get;set;}
         [Required(ErrorMessage = "Fill in this form, it is important")]
         [DisplayName("Last Name")]
          public string LastName{get;set;}
          [Required(ErrorMessage= "Fill in this field it is essential!")]
          [DisplayName(" Email Address")]
        [DataType(DataType.EmailAddress)]
          public string EmailAddress{get;set;}
         [Required(ErrorMessage= "Fill in this field it is essential!")]
         [StringLength(maximumLength:100,MinimumLength =10)]
         [DisplayName("Customer Address")]
         public string CustomerAddress{get;set;}
         [Required(ErrorMessage ="Fill in this necessary field")]
         public string PhoneNumber{get;set;}
         [Required(ErrorMessage =" Fill in this required field please")]
         [DataType(DataType.Password)]
         [DisplayName("Your Password")]
         public string Password{get;set;}
         [Required(ErrorMessage= "Fill in this field it is essential!")]
         [DisplayName("Your Image")]
         public string UserPhoto {get;set;}
         
         [Required(ErrorMessage ="Fill In This Required Field")]
         [Compare("Password",ErrorMessage = "Invalid Password")]
         [DataType(DataType.Password)]
         [DisplayName("Confirm Password")]
         public string ConfirmPassword{get;set;}
         [Required(ErrorMessage ="Field Is Necessary")]
         public Gender Gender{get;set;}
    }
}