

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Cakes_N_Treats_By_Zannie.Enums;

namespace Cakes_N_Treats_By_Zannie.Models
{
    public class CreateTreatRequestModel
    {
        [Required(ErrorMessage ="Fill The Treat Name")]
        public string Name {get;set;}
        [Required(ErrorMessage ="Fill In A Price For The Food Item")]
        [DataType(DataType.Currency)]
          public decimal Price{get;set;}
          [Required(ErrorMessage ="Fill The Number Of Items A pack of it comes With Or Select The option Not Packed!")]
          [DisplayName("Quantity In Pack")]
          public int NumberofTreatsInPack {get;set;}
          [Required(ErrorMessage ="Select A Category For This Menu Item")]
          public int CategoryId{get;set;}
          [DisplayName("The Food's Photo")]
          public string TreatPhoto{get;set;}
          public string TreatDescription{get;set;}
          public TreatPackType TypeOfTreatPack{get;set;}
    }
}