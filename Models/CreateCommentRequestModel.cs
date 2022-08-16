using Cakes_N_Treats_By_Zannie.Enums;
using System;
 using Cakes_N_Treats_By_Zannie.Entities;
using user.Desktop.Cakes_N_Treats_By_Zannie.Entities;
namespace Cakes_N_Treats_By_Zannie.Models
{
    public class CreateCommentRequestModel
    {
        public string CommentContent{get;set;}
        public CommentsType CommentType{get;set;}
        public int? TreatId{get;set;}
         public string ToWhomCommentIsDirected{get;set;}
        public CommentCategory Category{get;set;}
    }
}