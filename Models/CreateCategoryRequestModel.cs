using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cakes_N_Treats_By_Zannie.Models
{
    public class CreateCategoryRequestModel
    {
        [DisplayName("Name Of Category")]
        [Required(ErrorMessage ="Fill In This Necessary Form")]
        public string CategoryName{get;set;}
        [Required(ErrorMessage ="Add The Description Of This Food Category")]
        public string Description{get;set;}
        [DisplayName("Date Of Creation")]
        [Required(ErrorMessage ="Fill The Date You are creating This Category")]
        public DateTime DateOfCreation{get;set;}
    }
}