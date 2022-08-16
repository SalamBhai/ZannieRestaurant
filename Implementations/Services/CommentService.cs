using  Cakes_N_Treats_By_Zannie.Interfaces.IServices;
using Cakes_N_Treats_By_Zannie.Models;
using System.Collections.Generic;
using Cakes_N_Treats_By_Zannie.Interfaces.IRepositories;
using System.Linq;
using System;
using Cakes_N_Treats_By_Zannie.Enums;
using Cakes_N_Treats_By_Zannie.Entities;
namespace Cakes_N_Treats_By_Zannie.Implementations.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository= commentRepository;
        }
        public ViewCommentRequestModel GetComment(int id)
        {
           var comment= _commentRepository.GetComment(id);
           var commentReturn= new ViewCommentRequestModel
           {
               Id=comment.Id,
              CommentContent =comment.CommentContent,
              UserId= comment.UserId,
              CommentType=comment.CommentType,
                CommentDate=comment.CommentDate,
                TreatName= comment.Treat.Name,
                   TreatId=comment.TreatId,
                  ToWhomCommentIsDirected=comment.ToWhomCommentIsDirected,
               Category=comment.Category,
           };
           return commentReturn;
        }
        public bool CreateComment(CreateCommentRequestModel model, int userId)
        {
            var comment= new Comment
            {
                CommentContent= model.CommentContent,
                UserId= userId,
               CommentType=model.CommentType,
                CommentDate=DateTime.Now,
               TreatId=model.TreatId,
               ToWhomCommentIsDirected= model.ToWhomCommentIsDirected,
               Category= model.Category,
            };
            _commentRepository.CreateComment(comment);
            return true;
        }
         public IEnumerable<ViewCommentRequestModel> GetComments()
        {
           return _commentRepository.GetComments().Select(comment=> new ViewCommentRequestModel 
           {
               Id=comment.Id,
              CommentContent =comment.CommentContent,
              UserId= comment.UserId,
              CommentType=comment.CommentType,
                CommentDate=comment.CommentDate,
                TreatName= comment.Treat.Name,
                TreatId=comment.TreatId,
                ToWhomCommentIsDirected=comment.ToWhomCommentIsDirected,
               Category=comment.Category,
           }).ToList();
        }
         public IEnumerable<ViewCommentRequestModel> GetDispatchRiderComments()
        {
           return _commentRepository.GetComments().Where(comm=> comm.CommentType==Enums.CommentsType.DispatcherRelationComments).Select(comment=> new ViewCommentRequestModel 
           {
               Id=comment.Id,
              CommentContent =comment.CommentContent,
              UserId= comment.UserId,
              CommentType=comment.CommentType,
                CommentDate=comment.CommentDate,
                TreatName= comment.Treat.Name,
                TreatId=comment.TreatId,
                ToWhomCommentIsDirected=comment.ToWhomCommentIsDirected,
               Category=comment.Category,
           }).ToList();
        }   
        public IEnumerable<ViewCommentRequestModel> GetCommentsOnTreats()
        {
           return _commentRepository.GetComments().Where(comm=> comm.CommentType==CommentsType.TreatComments).Select(comment=> new ViewCommentRequestModel 
           {
               Id=comment.Id,
              CommentContent =comment.CommentContent,
              UserId= comment.UserId,
              CommentType=comment.CommentType,
                CommentDate=comment.CommentDate,
                TreatName= comment.Treat.Name,
                TreatId=comment.TreatId,
                ToWhomCommentIsDirected=comment.ToWhomCommentIsDirected,
               Category=comment.Category,
           }).ToList();
        }
         public IEnumerable<ViewCommentRequestModel> GetOrderRelatedComments()
        {
           return _commentRepository.GetComments().Where(comm=> comm.CommentType==CommentsType.OrderComments).Select(comment=> new ViewCommentRequestModel 
           {
               Id=comment.Id,
              CommentContent =comment.CommentContent,
              UserId= comment.UserId,
              CommentType=comment.CommentType,
                CommentDate=comment.CommentDate,
                TreatName= comment.Treat.Name,
                TreatId=comment.TreatId,
                ToWhomCommentIsDirected=comment.ToWhomCommentIsDirected,
               Category=comment.Category,
           }).ToList();
        }

          public IEnumerable<ViewCommentRequestModel> GetPositiveComments()
        {
           return _commentRepository.GetComments().Where(comm=> comm.Category==Enums.CommentCategory.Positive).Select(comment=> new ViewCommentRequestModel 
           {
               Id=comment.Id,
              CommentContent =comment.CommentContent,
              UserId= comment.UserId,
              CommentType=comment.CommentType,
                CommentDate=comment.CommentDate,
                TreatName= comment.Treat.Name,
                TreatId=comment.TreatId,
                ToWhomCommentIsDirected=comment.ToWhomCommentIsDirected,
               Category=comment.Category,
           }).ToList();
        }
         public IEnumerable<ViewCommentRequestModel> GetNegativeComments()
        {
           return _commentRepository.GetComments().Where(comm=> comm.Category==Enums.CommentCategory.Negative).Select(comment=> new ViewCommentRequestModel 
           {
               Id=comment.Id,
              CommentContent =comment.CommentContent,
              UserId= comment.UserId,
              CommentType=comment.CommentType,
                CommentDate=comment.CommentDate,
                TreatName= comment.Treat.Name,
                TreatId=comment.TreatId,
                ToWhomCommentIsDirected=comment.ToWhomCommentIsDirected,
               Category=comment.Category,
           }).ToList();
        }
    }
}