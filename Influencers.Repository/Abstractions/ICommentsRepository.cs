using Influencers.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Influencers.Repository.Abstractions
{
    public interface ICommentsRepository : IRepository<Comments>
    {
        List<Comments> GetCommentsByArticleId(int id);

        string GetCommentByArticleId(int id);
    }
}
