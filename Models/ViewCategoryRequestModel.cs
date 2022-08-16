using System;
using System.Collections.Generic;

namespace Cakes_N_Treats_By_Zannie.Models
{
    public class ViewCategoryRequestModel
    {
        public int id{get;set;}
        public string CategoryName{get;set;}
        public int NumberOfTreatsInCategory{get;set;}
        public DateTime DateOfCreation{get;set;}
        public string Description{get;set;}
        public IEnumerable<ViewTreatRequestModel> TreatNames {get;set;}
    }
}