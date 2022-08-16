using System.Collections.Generic;
using System.Linq;
using Cakes_N_Treats_By_Zannie.Context;
using Cakes_N_Treats_By_Zannie.Entities;
using Cakes_N_Treats_By_Zannie.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Cakes_N_Treats_By_Zannie.Implementations.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ZannieContext _zannie;
        public CommentRepository(ZannieContext zannie)
        {
            _zannie= zannie;
        }
        public Comment CreateComment(Comment comment)
        {
            _zannie.Comments.Add(comment);
            _zannie.SaveChanges();
            return comment;
        }
    
       public Comment GetComment(int id)
       {
          var thecategory= _zannie.Comments.Include(L=>L.Treat).SingleOrDefault(th=>th.Id==id);
          return thecategory;
       }
       public IEnumerable<Comment> GetComments()
       {
           var Comments = _zannie.Comments.Include(L=> L.Treat).ToList();
           return Comments;
       }
    }
}