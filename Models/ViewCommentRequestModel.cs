using System;
using Cakes_N_Treats_By_Zannie.Enums;
using Cakes_N_Treats_By_Zannie.Entities;
namespace Cakes_N_Treats_By_Zannie.Models
{
    public class ViewCommentRequestModel
    {
        public int Id{get;set;}
        public string CommentContent{get;set;}
        public string UserName{get;set;}
        public int UserId{get;set;}
        public CommentsType CommentType{get;set;}
        public DateTime CommentDate{get;set;}
        public ViewTreatRequestModel Treat{get;set;}
        public int? TreatId{get;set;}
         public string ToWhomCommentIsDirected{get;set;}
        public CommentCategory Category{get;set;}
        public string TreatName {get;set;}
    }
}