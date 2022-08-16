using System.Collections.Generic;
using Cakes_N_Treats_By_Zannie.Entities;

namespace Cakes_N_Treats_By_Zannie.Interfaces.IRepositories
{
    public interface ICommentRepository
    {
         public Comment CreateComment(Comment comment);
         public IEnumerable<Comment> GetComments();
         public Comment GetComment(int commentId);
    }
}