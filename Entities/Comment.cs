using System;
using Cakes_N_Treats_By_Zannie.Enums;
using  user.Desktop.Cakes_N_Treats_By_Zannie.Entities;
namespace Cakes_N_Treats_By_Zannie.Entities
{
    public class Comment
    {
        public int Id{get;set;}
        public string CommentContent{get;set;}
        public User User {get;set;}
        public int UserId{get;set;}
        public CommentsType CommentType{get;set;}
        public DateTime CommentDate{get;set;}
        public Treat Treat{get;set;}
        public int? TreatId{get;set;}
        public string ToWhomCommentIsDirected{get;set;}
        public CommentCategory Category{get;set;}
    }
}