 using Cakes_N_Treats_By_Zannie.Models;
 using System.Collections.Generic;
namespace Cakes_N_Treats_By_Zannie.Interfaces.IServices
{
    public interface ICommentService
    {
          public bool CreateComment(CreateCommentRequestModel comment,int userId);
         public IEnumerable<ViewCommentRequestModel> GetComments();
         public IEnumerable<ViewCommentRequestModel> GetOrderRelatedComments();
         public ViewCommentRequestModel GetComment(int commentId);
         public IEnumerable<ViewCommentRequestModel> GetDispatchRiderComments();
         public IEnumerable<ViewCommentRequestModel> GetCommentsOnTreats();
         public IEnumerable<ViewCommentRequestModel> GetPositiveComments();
        public IEnumerable<ViewCommentRequestModel> GetNegativeComments();
    }
}